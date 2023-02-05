
namespace Windows.UI.Concrete.Forms.SevkiyatListesiForms
{
    partial class UrunSevkiyatListesiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunSevkiyatListesiForm));
            this.longNavigator = new Windows.UI.Concrete.UseControls.Navigators.LongNavigator();
            this.grid = new Windows.UI.Concrete.UseControls.Grid.MyGridControl();
            this.tablo = new Windows.UI.Concrete.UseControls.Grid.MyGridView();
            this.colSevkiyatNo = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colSevkiyatTarih = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colUrunNo = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colUrunAdi = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colSoforAdiSoyadi = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colAracPlaka = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.SearchEditItem.UseEditorPadding = false;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 577);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1179, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 79);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1179, 498);
            this.grid.TabIndex = 5;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
            this.tablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.FooterPanel.Options.UseFont = true;
            this.tablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSevkiyatNo,
            this.colSevkiyatTarih,
            this.colUrunNo,
            this.colUrunAdi,
            this.colSoforAdiSoyadi,
            this.colAracPlaka});
            this.tablo.GridControl = this.grid;
            this.tablo.GroupCount = 1;
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintFooter = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.ColumnAutoWidth = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowAutoFilterRow = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSevkiyatNo, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisayol = null;
            this.tablo.StatusBarKisayolAciklama = null;
            this.tablo.ViewCaption = "Ürün Sevkiyat Listesi";
            // 
            // colSevkiyatNo
            // 
            this.colSevkiyatNo.AppearanceCell.Options.UseTextOptions = true;
            this.colSevkiyatNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSevkiyatNo.Caption = "Sevkiyat No";
            this.colSevkiyatNo.FieldName = "UrunSevkiyatNo";
            this.colSevkiyatNo.ImageOptions.Image = global::Windows.UI.Properties.Resources.gettingstarted_16x16;
            this.colSevkiyatNo.Name = "colSevkiyatNo";
            this.colSevkiyatNo.OptionsColumn.AllowEdit = false;
            this.colSevkiyatNo.StatusBarAciklama = null;
            this.colSevkiyatNo.StatusBarKisayol = null;
            this.colSevkiyatNo.StatusBarKisayolAciklama = null;
            this.colSevkiyatNo.Visible = true;
            this.colSevkiyatNo.VisibleIndex = 0;
            this.colSevkiyatNo.Width = 120;
            // 
            // colSevkiyatTarih
            // 
            this.colSevkiyatTarih.AppearanceCell.Options.UseTextOptions = true;
            this.colSevkiyatTarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSevkiyatTarih.Caption = "Sevkiyat Tarihi";
            this.colSevkiyatTarih.FieldName = "UrunSevkiyatTarih";
            this.colSevkiyatTarih.ImageOptions.Image = global::Windows.UI.Properties.Resources.calendar_16x16;
            this.colSevkiyatTarih.Name = "colSevkiyatTarih";
            this.colSevkiyatTarih.OptionsColumn.AllowEdit = false;
            this.colSevkiyatTarih.StatusBarAciklama = null;
            this.colSevkiyatTarih.StatusBarKisayol = null;
            this.colSevkiyatTarih.StatusBarKisayolAciklama = null;
            this.colSevkiyatTarih.Visible = true;
            this.colSevkiyatTarih.VisibleIndex = 0;
            this.colSevkiyatTarih.Width = 120;
            // 
            // colUrunNo
            // 
            this.colUrunNo.AppearanceCell.Options.UseTextOptions = true;
            this.colUrunNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUrunNo.Caption = "Ürün No";
            this.colUrunNo.FieldName = "UrunNo";
            this.colUrunNo.ImageOptions.Image = global::Windows.UI.Properties.Resources.gettingstarted_16x16;
            this.colUrunNo.Name = "colUrunNo";
            this.colUrunNo.OptionsColumn.AllowEdit = false;
            this.colUrunNo.StatusBarAciklama = null;
            this.colUrunNo.StatusBarKisayol = null;
            this.colUrunNo.StatusBarKisayolAciklama = null;
            this.colUrunNo.Visible = true;
            this.colUrunNo.VisibleIndex = 1;
            this.colUrunNo.Width = 120;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.Caption = "Ürün Adı";
            this.colUrunAdi.FieldName = "UrunAdi";
            this.colUrunAdi.ImageOptions.Image = global::Windows.UI.Properties.Resources.card_16x16;
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.OptionsColumn.AllowEdit = false;
            this.colUrunAdi.StatusBarAciklama = null;
            this.colUrunAdi.StatusBarKisayol = null;
            this.colUrunAdi.StatusBarKisayolAciklama = null;
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 2;
            this.colUrunAdi.Width = 150;
            // 
            // colSoforAdiSoyadi
            // 
            this.colSoforAdiSoyadi.AppearanceCell.Options.UseTextOptions = true;
            this.colSoforAdiSoyadi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoforAdiSoyadi.Caption = "Şoför";
            this.colSoforAdiSoyadi.FieldName = "SoforAdiSoyadi";
            this.colSoforAdiSoyadi.ImageOptions.Image = global::Windows.UI.Properties.Resources.newitem_16x161;
            this.colSoforAdiSoyadi.Name = "colSoforAdiSoyadi";
            this.colSoforAdiSoyadi.OptionsColumn.AllowEdit = false;
            this.colSoforAdiSoyadi.StatusBarAciklama = null;
            this.colSoforAdiSoyadi.StatusBarKisayol = null;
            this.colSoforAdiSoyadi.StatusBarKisayolAciklama = null;
            this.colSoforAdiSoyadi.Visible = true;
            this.colSoforAdiSoyadi.VisibleIndex = 3;
            this.colSoforAdiSoyadi.Width = 120;
            // 
            // colAracPlaka
            // 
            this.colAracPlaka.AppearanceCell.Options.UseTextOptions = true;
            this.colAracPlaka.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAracPlaka.Caption = "Araç Plakası";
            this.colAracPlaka.FieldName = "AracPlaka";
            this.colAracPlaka.ImageOptions.Image = global::Windows.UI.Properties.Resources.driving_16x16;
            this.colAracPlaka.Name = "colAracPlaka";
            this.colAracPlaka.OptionsColumn.AllowEdit = false;
            this.colAracPlaka.StatusBarAciklama = null;
            this.colAracPlaka.StatusBarKisayol = null;
            this.colAracPlaka.StatusBarKisayolAciklama = null;
            this.colAracPlaka.Visible = true;
            this.colAracPlaka.VisibleIndex = 4;
            this.colAracPlaka.Width = 100;
            // 
            // UrunSevkiyatListesiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 625);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "UrunSevkiyatListesiForm";
            this.Text = "Ürün Sevkiyat Listesi";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UseControls.Navigators.LongNavigator longNavigator;
        private UseControls.Grid.MyGridControl grid;
        private UseControls.Grid.MyGridView tablo;
        private UseControls.Grid.MyGridColumn colSevkiyatNo;
        private UseControls.Grid.MyGridColumn colSevkiyatTarih;
        private UseControls.Grid.MyGridColumn colUrunNo;
        private UseControls.Grid.MyGridColumn colUrunAdi;
        private UseControls.Grid.MyGridColumn colSoforAdiSoyadi;
        private UseControls.Grid.MyGridColumn colAracPlaka;
    }
}