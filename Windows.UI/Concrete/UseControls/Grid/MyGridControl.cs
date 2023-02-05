using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.ComponentModel;
using System.Drawing;
using Windows.UI.Abstract.Interfaces;

namespace Windows.UI.Concrete.UseControls.Grid
{
    [ToolboxItem(true)]
    public class MyGridControl : GridControl
    {
        protected override BaseView CreateDefaultView()
        {
            var view = (GridView)CreateView("MyGridView");
            // gridview başlık rengini değiştirme
            view.Appearance.ViewCaption.ForeColor = Color.Maroon;
            // header panellerin rengini değiştirme
            view.Appearance.HeaderPanel.ForeColor = Color.Maroon;
            // header daki başlık kısımları ortalama
            view.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;
            // footer panel renk değiştirme yazı tipi boyutu ve kalınlık ayarı
            view.Appearance.FooterPanel.ForeColor = Color.Maroon;
            view.Appearance.FooterPanel.Font = new Font(new FontFamily("Tahoma"), 8.25f, FontStyle.Bold);

            //menülerin üzerine sağ tıklandıgında default menüyü kapatma
            view.OptionsMenu.EnableColumnMenu = false;
            view.OptionsMenu.EnableFooterMenu = false;
            view.OptionsMenu.EnableGroupPanelMenu = false;

            //kolonlar hücreleri arasında dolaşma 
            view.OptionsNavigation.EnterMoveNextColumn = true;

            //yazdırma işleminde kolon alanlarının otomatik daralmasını kapatma
            view.OptionsPrint.AutoWidth = false;
            //footer bölümleri yazıcıya gönderilmesin
            view.OptionsPrint.PrintFooter = false;
            view.OptionsPrint.PrintGroupFooter = false;

            // grid caption göster
            view.OptionsView.ShowViewCaption = true;
            // filtreleme bölümünü açma
            view.OptionsView.ShowAutoFilterRow = true;
            // gruplama panelini gizleme / açma
            view.OptionsView.ShowGroupPanel = false;
            //oto column özelliğini devre dışı bırakma
            view.OptionsView.ColumnAutoWidth = false;
            //column yükseklik ayarını otomatik ayarlama
            view.OptionsView.RowAutoHeight = true;
            //header filtercontrol button olarak gösterme
            view.OptionsView.HeaderFilterButtonShowMode = FilterButtonShowMode.Button;

            //kolon ekleme
            var idColumn = new MyGridColumn();
            idColumn.Caption = "Id";//kolon başlığı
            idColumn.FieldName = "Id";// verinin databasedeki kolon adı
            idColumn.OptionsColumn.AllowEdit = false;
            idColumn.OptionsColumn.ShowInCustomizationForm = false;//id kolon gizleme
            view.Columns.Add(idColumn);

            var kodColumn = new MyGridColumn();
            kodColumn.Caption = "Kod";
            kodColumn.FieldName = "Kod";
            kodColumn.OptionsColumn.AllowEdit = false;
            kodColumn.Visible = true;
            kodColumn.AppearanceCell.Options.UseTextOptions = true;
            kodColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            view.Columns.Add(kodColumn);

            return view;

        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyGridInfoRegistrator());
        }

        private class MyGridInfoRegistrator : GridInfoRegistrator
        {
            public override string ViewName => "MyGridView";

            public override BaseView CreateView(GridControl grid) => new MyGridView(grid);

        }


    }

    public class MyGridView : GridView, IStatusBarKisaYol
    {

        #region Properties
        public string StatusBarKisayol { get; set; }

        public string StatusBarKisayolAciklama { get; set; }

        public string StatusBarAciklama { get; set; }
        #endregion
        public MyGridView() { }
        public MyGridView(GridControl ownerGrid) : base(ownerGrid) { }

        protected override void OnColumnChangedCore(GridColumn column)
        {
            base.OnColumnChangedCore(column);
            //eğer kolonun columnedit yoksa
            if (column.ColumnEdit == null) return;
            //eğer atanan column edit repositoryiyemdateedite eşit ise 
            if (column.ColumnEdit.GetType() == typeof(RepositoryItemDateEdit))
            {
                // içerisindeli value ortalama apperencacell=value
                column.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                //gun kısmı yazılınca otomatık ay kısmına gecmesı sonra yıl
                ((RepositoryItemDateEdit)column.ColumnEdit).Mask.MaskType = MaskType.DateTimeAdvancingCaret;

            }
        }
        // kolon eklenmesi durumunda 
        protected override GridColumnCollection CreateColumnCollection()
        {
            return new MyGridColumnCollection(this);
        }
        // kolonu eklerken calısır
        private class MyGridColumnCollection : GridColumnCollection
        {
            public MyGridColumnCollection(ColumnView view) : base(view) { }

            protected override GridColumn CreateColumn()
            {
                var column = new MyGridColumn();
                column.OptionsColumn.AllowEdit = false;
                return column;
            }
        }
    }

    public class MyGridColumn : GridColumn, IStatusBarKisaYol
    {
        #region Properties
        public string StatusBarKisayol { get; set; }

        public string StatusBarKisayolAciklama { get; set; }

        public string StatusBarAciklama { get; set; }
        #endregion

    }
}
