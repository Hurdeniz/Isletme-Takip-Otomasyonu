using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Entities.Abstract.Base;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Windows.UI.Abstract.Functions
{
    public class SelectRowFunctions
    {
        #region Variables
        private GridView _tablo;
        private GridColumn _column;
        private RepositoryItemCheckEdit _checkEdit;
        private readonly IList<BaseEntity> _selectedRows;
        #endregion

        public SelectRowFunctions(GridView tablo)
        {
            _tablo = tablo;
            _selectedRows = new List<BaseEntity>();

            RemoveEvents();
            AddEvents(tablo);
        }

        public int SelectedRowCount => _selectedRows.Count; //seçilen rowların sayısı
     
        public BaseEntity GetSelectedRow(int index)
        {
            return _selectedRows[index];//seçilen row bilgi
        }

        public IList<BaseEntity> GetSelectedRows()
        {
            return _selectedRows;//seçilen Tüm Rowlar
        }

        public int GetSelectedRowIndex(BaseEntity row)
        {
            return _selectedRows.IndexOf(row);//seçilen row indexi
        }

        public bool IsRowSelected(int rowHandle)
        {
            var row = _tablo.GetRow<BaseEntity>(rowHandle);
            return GetSelectedRowIndex(row) > -1;//indexten 0 dan küçük değer dönerse seçili değili
        }

        public void SelectAll()
        {
            _selectedRows.Clear();//tüm rowları temizle

            for (int i = 0; i < _tablo.DataRowCount; i++)
            {
                _selectedRows.Add(_tablo.GetRow<BaseEntity>(i));
            }

            Update();
        }

        private void Update()
        {
            _tablo.BeginUpdate();//Yapılan İşlemleri Anında Ekrana Yansıması
            _tablo.EndUpdate();//Yapılan İşlemleri Anında Ekrana Yansıması
        }

        public void ClearSelection()
        {
            _selectedRows.Clear();
            Update();
        }

        public void RowSelection(int rowHandle)
        {
            if (!_tablo.IsDataRow(rowHandle)) return;
            SelectRow(rowHandle, !IsRowSelected(rowHandle));
        }

        private void SelectRow(int rowHandle, bool select)
        {
            if (IsRowSelected(rowHandle) == select) return;
            var row = _tablo.GetRow<BaseEntity>(rowHandle);

            if (select)
                _selectedRows.Add(row);
            else
                _selectedRows.Remove(row);

            Update();
        }

        private void AddEvents(GridView tablo)
        {
            if (tablo == null) return;
            _selectedRows.Clear();
            _tablo = tablo;

            _checkEdit = (RepositoryItemCheckEdit)_tablo.GridControl.RepositoryItems.Add("CheckEdit");
            _column = tablo.Columns.Add();
            _column.OptionsColumn.AllowSort = DefaultBoolean.False; //sıralama devre dışı
            _column.Visible = true;
            _column.VisibleIndex = 0;//en solda
            _column.FieldName = "Secim";
            _column.OptionsColumn.ShowCaption = false;
            _column.OptionsColumn.AllowEdit = false;
            _column.OptionsColumn.AllowSize = false;
            _column.UnboundType = UnboundColumnType.Boolean;
            _column.Width = 35;
            _column.ColumnEdit = _checkEdit;
            _tablo.FocusedColumn = _column;

            if (_tablo is BandedGridView bView)
            {
                bView.Bands["bndSecim"].Visible = true;
                bView.Bands["bndSecim"].VisibleIndex = 0;
                bView.Bands["bndSecim"].Columns.Add((BandedGridColumn)_column);
            }

            _tablo.Click += Tablo_Click;
            _tablo.CustomDrawColumnHeader += Tablo_CustomDrawColumnHeader;
            _tablo.CustomUnboundColumnData += Tablo_CustomUnboundColumnData;
            _tablo.KeyDown += Tablo_KeyDown;
            _tablo.RowStyle += Tablo_RowStyle;
        }

        private void RemoveEvents()
        {
            if (_tablo == null) return;
            _column?.Dispose();

            if (_checkEdit != null)
            {
                _tablo.GridControl.RepositoryItems.Remove(_checkEdit);
                _checkEdit.Dispose();
            }

            _tablo.Click -= Tablo_Click;
            _tablo.CustomDrawColumnHeader -= Tablo_CustomDrawColumnHeader;
            _tablo.CustomUnboundColumnData -= Tablo_CustomUnboundColumnData;
            _tablo.KeyDown -= Tablo_KeyDown;
            _tablo.RowStyle -= Tablo_RowStyle;

            _tablo = null;
        }

        private void CheckBoxEkle(GraphicsCache cache, Rectangle r, bool check)
        {
            var info = (CheckEditViewInfo)_checkEdit.CreateViewInfo();
            var painter = (CheckEditPainter)_checkEdit.CreatePainter();
            if (info == null) return;
            info.EditValue = check;
            info.Bounds = r;
            info.CalcViewInfo(cache.Graphics);
            var arg = new ControlGraphicsInfoArgs(info, cache, r);
            painter?.Draw(arg);

        }

        private void Tablo_Click(object sender, EventArgs e)
        {
            var point = _tablo.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo info = _tablo.CalcHitInfo(point);

            // başlık cubugunda checkbox tıklanması durumunda hepsi seçili ise hepsini kaldır seçili değil ise hepsini seç
            if (info.Column == _column)
            {
                if (info.InColumn)
                {
                    if (SelectedRowCount == _tablo.DataRowCount)
                        ClearSelection();
                    else
                        SelectAll();

                }
                else if (info.InRowCell)// bir hücreye tıklanması durumunda seç ve ya kaldır
                    RowSelection(info.RowHandle);
            }
            else if (info.InRow)
                RowSelection(info.RowHandle);//row tıklanıldıgı zamanda seçim yapması
        }

        private void Tablo_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column != _column) return;
            e.Info.InnerElements.Clear();
            e.Painter.DrawObject(e.Info);
            CheckBoxEkle(e.Cache, e.Bounds, SelectedRowCount == _tablo.DataRowCount);
            e.Handled = true;
        }

        private void Tablo_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column != _column) return;
            e.Value = IsRowSelected(_tablo.GetRowHandle(e.ListSourceRowIndex));//yüklenme aşamasında rowların alacağı checkbox değeri
        }

        private void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Space) return;
            RowSelection(_tablo.FocusedRowHandle);//boşluk tuşuna basınca seçim yap
        }

        private void Tablo_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (!IsRowSelected(e.RowHandle)) return;
            e.Appearance.BackColor = SystemColors.Highlight;
            e.Appearance.ForeColor = SystemColors.HighlightText;
        }
    }
}
