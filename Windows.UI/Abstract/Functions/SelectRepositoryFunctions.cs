using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Entitiess.Concrete;
using Model.Enums;
using System.Windows.Forms;
using Windows.UI.Abstract.Show;
using Windows.UI.Concrete.Forms.AracForms;
using Windows.UI.Concrete.Forms.SoforForms;

namespace Windows.UI.Abstract.Functions
{
    public static class SelectRepositoryFunctions
    {
        #region Variables
        private static GridView _tablo;
        private static ControlNavigator _navigator;
        private static RepositoryItemButtonEdit _buttonEdit;
        private static GridColumn _idColumn;
        private static GridColumn _nameColumn; 
        #endregion

        private static void RemoveEvent()
        {
            if (_buttonEdit == null) return;
            _buttonEdit.ButtonClick -= ButtonEdit_ButtonClick;
            _buttonEdit.KeyDown -= ButtonEdit_KeyDown;
            _buttonEdit.DoubleClick -= ButtonEdit_DoubleClick;
            _tablo.KeyDown -= Tablo_KeyDown;
        }

        public static void Sec(this GridColumn nameColumn, GridView tablo, ControlNavigator navigator, RepositoryItemButtonEdit buttonEdit, GridColumn idColumn)
        {
            RemoveEvent();

            _tablo = tablo;
            _navigator = navigator;
            _buttonEdit = buttonEdit;
            _idColumn = idColumn;
            _nameColumn = nameColumn;

            _buttonEdit.ButtonClick += ButtonEdit_ButtonClick;
            _buttonEdit.KeyDown += ButtonEdit_KeyDown;
            _buttonEdit.DoubleClick += ButtonEdit_DoubleClick;
            _tablo.KeyDown += Tablo_KeyDown;
        }

        private static void ButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SecimYap();
        }

        private static void ButtonEdit_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //ctrl+shift+delete basınca kolonun hangi hücresinde ise değer ataması yapıyor yani siliyoruz
                case Keys.Delete when e.Control && e.Shift:
                    _tablo.SetFocusedRowCellValue(_idColumn, null);
                    _tablo.SetFocusedRowCellValue(_nameColumn, null);
                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);//yazma modundan ilgili kolonu cıkarmıs oluyoruz
                    break;
                case Keys.F4:
                    // case Keys.Down when e.Alt:
                    SecimYap();
                    break;
            }
        }

        private static void ButtonEdit_DoubleClick(object sender, System.EventArgs e)
        {
            SecimYap();
        }

        private static void Tablo_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (_tablo.FocusedColumn.ColumnEdit == null) return;

            var type = _tablo.FocusedColumn.ColumnEdit.GetType();
            if (type != typeof(RepositoryItemButtonEdit)) return;


            switch (e.KeyCode)
            {
                //ctrl+shift+delete basınca kolonun hangi hücresinde ise değer ataması yapıyor yani siliyoruz
                case Keys.Delete when e.Control && e.Shift:
                    _tablo.SetFocusedRowCellValue(_idColumn, null);
                    _tablo.SetFocusedRowCellValue(_nameColumn, null);
                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);//yazma modundan ilgili kolonu cıkarmıs oluyoruz
                    break;
                case Keys.F4:
                    // case Keys.Down when e.Alt:
                    SecimYap();
                    break;
            }

        }

        private static void SecimYap()
        {
            switch (_buttonEdit.Name)
            {
                case "repositorySofor":
                    {
                         var id = _tablo.GetRowCellId(_idColumn);
                        //var id =(long) _tablo.GetRowCellValue(_tablo.FocusedRowHandle, _idColumn);
                        var entity = (Sofor)ShowListForm<SoforListForm>.ShowDialogListForm(KartTuru.Sofor,id);
                        if (entity != null)
                        {
                            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _tablo.SetFocusedRowCellValue(_nameColumn, entity.SoforAdiSoyadi);
                            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                        }
                    }
                    break;
                case "repositoryArac":
                    {
                        var id = _tablo.GetRowCellId(_idColumn);
                        //var id =(long) _tablo.GetRowCellValue(_tablo.FocusedRowHandle, _idColumn);
                        var entity = (Arac)ShowListForm<AracListForm>.ShowDialogListForm(KartTuru.Arac, id);
                        if (entity != null)
                        {
                            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _tablo.SetFocusedRowCellValue(_nameColumn, entity.AracPlaka);
                            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                        }
                    }
                    break;
            }
        }

    }
}
