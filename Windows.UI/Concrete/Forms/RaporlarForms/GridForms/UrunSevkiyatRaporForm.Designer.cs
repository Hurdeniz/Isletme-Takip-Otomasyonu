
namespace Windows.UI.Concrete.Forms.RaporlarForms.GridForms
{
    partial class UrunSevkiyatRaporForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunSevkiyatRaporForm));
            this.longNavigator = new Windows.UI.Concrete.UseControls.Navigators.LongNavigator();
            this.grid = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridControl();
            this.tablo = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colUrunNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUrunAdi = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colUrunSevkiyatNo = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colUrunSevkiyatTarih = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colUrunSevkiyatSaat = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colSoforAdiSoyadi = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colAracPlaka = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colAciklama = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
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
            this.longNavigator.Location = new System.Drawing.Point(0, 575);
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
            this.grid.Size = new System.Drawing.Size(1179, 496);
            this.grid.TabIndex = 3;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
            this.tablo.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.BandPanel.ForeColor = System.Drawing.Color.DarkBlue;
            this.tablo.Appearance.BandPanel.Options.UseFont = true;
            this.tablo.Appearance.BandPanel.Options.UseForeColor = true;
            this.tablo.Appearance.BandPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            this.tablo.BandPanelRowHeight = 40;
            this.tablo.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colUrunNo,
            this.colUrunAdi,
            this.colUrunSevkiyatNo,
            this.colUrunSevkiyatTarih,
            this.colUrunSevkiyatSaat,
            this.colSoforAdiSoyadi,
            this.colAracPlaka,
            this.colAciklama});
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
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colUrunAdi, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.tablo.ViewCaption = "Ürün Sevkiyat Raporu";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Ürün Bilgileri";
            this.gridBand1.Columns.Add(this.colUrunNo);
            this.gridBand1.Columns.Add(this.colUrunAdi);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 270;
            // 
            // colUrunNo
            // 
            this.colUrunNo.AppearanceCell.Options.UseTextOptions = true;
            this.colUrunNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUrunNo.Caption = "Ürün No";
            this.colUrunNo.FieldName = "UrunNo";
            this.colUrunNo.Name = "colUrunNo";
            this.colUrunNo.OptionsColumn.AllowEdit = false;
            this.colUrunNo.Visible = true;
            this.colUrunNo.Width = 120;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.Caption = "Ürün Adı";
            this.colUrunAdi.FieldName = "UrunAdi";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.OptionsColumn.AllowEdit = false;
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.Width = 150;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Sevkiyat Bilgileri";
            this.gridBand2.Columns.Add(this.colUrunSevkiyatNo);
            this.gridBand2.Columns.Add(this.colUrunSevkiyatTarih);
            this.gridBand2.Columns.Add(this.colUrunSevkiyatSaat);
            this.gridBand2.Columns.Add(this.colSoforAdiSoyadi);
            this.gridBand2.Columns.Add(this.colAracPlaka);
            this.gridBand2.Columns.Add(this.colAciklama);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 820;
            // 
            // colUrunSevkiyatNo
            // 
            this.colUrunSevkiyatNo.AppearanceCell.Options.UseTextOptions = true;
            this.colUrunSevkiyatNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUrunSevkiyatNo.Caption = "Sevkiyat No";
            this.colUrunSevkiyatNo.FieldName = "UrunSevkiyatNo";
            this.colUrunSevkiyatNo.Name = "colUrunSevkiyatNo";
            this.colUrunSevkiyatNo.OptionsColumn.AllowEdit = false;
            this.colUrunSevkiyatNo.Visible = true;
            this.colUrunSevkiyatNo.Width = 120;
            // 
            // colUrunSevkiyatTarih
            // 
            this.colUrunSevkiyatTarih.AppearanceCell.Options.UseTextOptions = true;
            this.colUrunSevkiyatTarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUrunSevkiyatTarih.Caption = "Sevkiyat Tarihi";
            this.colUrunSevkiyatTarih.FieldName = "UrunSevkiyatTarih";
            this.colUrunSevkiyatTarih.Name = "colUrunSevkiyatTarih";
            this.colUrunSevkiyatTarih.OptionsColumn.AllowEdit = false;
            this.colUrunSevkiyatTarih.Visible = true;
            this.colUrunSevkiyatTarih.Width = 100;
            // 
            // colUrunSevkiyatSaat
            // 
            this.colUrunSevkiyatSaat.AppearanceCell.Options.UseTextOptions = true;
            this.colUrunSevkiyatSaat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUrunSevkiyatSaat.Caption = "Sevkiyat Saati";
            this.colUrunSevkiyatSaat.FieldName = "UrunSevkiyatSaat";
            this.colUrunSevkiyatSaat.Name = "colUrunSevkiyatSaat";
            this.colUrunSevkiyatSaat.OptionsColumn.AllowEdit = false;
            this.colUrunSevkiyatSaat.Visible = true;
            this.colUrunSevkiyatSaat.Width = 100;
            // 
            // colSoforAdiSoyadi
            // 
            this.colSoforAdiSoyadi.AppearanceCell.Options.UseTextOptions = true;
            this.colSoforAdiSoyadi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoforAdiSoyadi.Caption = "Şoför Adı";
            this.colSoforAdiSoyadi.FieldName = "SoforAdiSoyadi";
            this.colSoforAdiSoyadi.Name = "colSoforAdiSoyadi";
            this.colSoforAdiSoyadi.OptionsColumn.AllowEdit = false;
            this.colSoforAdiSoyadi.Visible = true;
            this.colSoforAdiSoyadi.Width = 100;
            // 
            // colAracPlaka
            // 
            this.colAracPlaka.AppearanceCell.Options.UseTextOptions = true;
            this.colAracPlaka.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAracPlaka.Caption = "Araç Plaka";
            this.colAracPlaka.FieldName = "AracPlaka";
            this.colAracPlaka.Name = "colAracPlaka";
            this.colAracPlaka.OptionsColumn.AllowEdit = false;
            this.colAracPlaka.Visible = true;
            this.colAracPlaka.Width = 100;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.Width = 300;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // UrunSevkiyatRaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 625);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "UrunSevkiyatRaporForm";
            this.Text = "Ürün Sevkiyat Raporu";
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
        private UseControls.Grid.MyBandedGridControl grid;
        private UseControls.Grid.MyBandedGridView tablo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUrunNo;
        private UseControls.Grid.MyBandedGridColumn colUrunAdi;
        private UseControls.Grid.MyBandedGridColumn colUrunSevkiyatNo;
        private UseControls.Grid.MyBandedGridColumn colUrunSevkiyatTarih;
        private UseControls.Grid.MyBandedGridColumn colUrunSevkiyatSaat;
        private UseControls.Grid.MyBandedGridColumn colSoforAdiSoyadi;
        private UseControls.Grid.MyBandedGridColumn colAracPlaka;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private UseControls.Grid.MyBandedGridColumn colAciklama;
    }
}