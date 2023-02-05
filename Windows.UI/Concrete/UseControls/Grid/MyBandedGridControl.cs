using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using System.ComponentModel;
using System.Drawing;

namespace Windows.UI.Concrete.UseControls.Grid
{
    [ToolboxItem(true)]
    public class MyBandedGridControl : GridControl
    {
        protected override BaseView CreateDefaultView()
        {
            var view = (MyBandedGridView)CreateView("MyBandedGridView");

            //Band Panel Rengi
            view.Appearance.BandPanel.ForeColor = Color.DarkBlue;
            view.Appearance.BandPanel.Font = new Font(new FontFamily("Tahoma"), 8.25f, FontStyle.Bold);
            view.Appearance.BandPanel.TextOptions.HAlignment = HorzAlignment.Center;
            view.BandPanelRowHeight = 40;


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
            // gruplama panelini gizleme
            view.OptionsView.ShowGroupPanel = false;
            //oto column özelliğini devre dışı bırakma
            view.OptionsView.ColumnAutoWidth = false;
            //column yükseklik ayarını otomatik ayarlama
            view.OptionsView.RowAutoHeight = true;
            //header filtercontrol button olarak gösterme
            view.OptionsView.HeaderFilterButtonShowMode = FilterButtonShowMode.Button;

            var columns = new[]
            {

              new BandedGridColumn
              {
                 Caption = "Id",
                 FieldName = "Id",

                 OptionsColumn = { AllowEdit = false, ShowInCustomizationForm = false }
              },
               new BandedGridColumn
               {
                   Caption ="Kod",
                   FieldName ="Kod",
                   Visible=true,
                   OptionsColumn = { AllowEdit = false },
                   AppearanceCell={ TextOptions = { HAlignment=HorzAlignment.Center }, Options = { UseTextOptions = true } }
               }
            };

            view.Columns.AddRange(columns);
            return view;
        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);

            collection.Add(new MyBandedGridInfoRegistrator());
        }

        private class MyBandedGridInfoRegistrator : BandedGridInfoRegistrator
        {
            public override string ViewName => "MyBandedGridView";
            public override BaseView CreateView(GridControl grid)
            {
                return new MyBandedGridView(grid);
            }
        }
    }


    public class MyBandedGridView : BandedGridView
    {

        public MyBandedGridView() { }

        public MyBandedGridView(GridControl ownerGrid) : base(ownerGrid) { }

        protected override void OnColumnChangedCore(GridColumn column)
        {
            base.OnColumnChangedCore(column);

            if (column.ColumnEdit == null) return;
            if (column.ColumnEdit.GetType() == typeof(RepositoryItemDateEdit))
            {
                column.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                ((RepositoryItemDateEdit)column.ColumnEdit).Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            }
        }
        protected override GridColumnCollection CreateColumnCollection()
        {
            return new MyGridColumnCollection(this);
        }

        private class MyGridColumnCollection : BandedGridColumnCollection
        {
            public MyGridColumnCollection(ColumnView view) : base(view) { }

            protected override GridColumn CreateColumn()
            {
                var column = new MyBandedGridColumn();
                column.OptionsColumn.AllowEdit = false;
                return column;
            }

        }
    }
    public class MyBandedGridColumn : BandedGridColumn
    {
   
    }
}
