
namespace Windows.UI.Concrete.Forms.RaporlarForms.GridForms
{
    partial class BesihaneRaporForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BesihaneRaporForm));
            this.longNavigator1 = new Windows.UI.Concrete.UseControls.Navigators.LongNavigator();
            this.grid = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridControl();
            this.tablo = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colKod = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colKapasite = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colHayvanSayisi = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colKayitTarihi = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colPompaAdi = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colPompaCesit = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colAciklama = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colIlAdi = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colIlceAdi = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colAdres = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colIsletmeAdi = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
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
            this.ribbonControl.Size = new System.Drawing.Size(1600, 79);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // longNavigator1
            // 
            this.longNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator1.Location = new System.Drawing.Point(0, 575);
            this.longNavigator1.Name = "longNavigator1";
            this.longNavigator1.Size = new System.Drawing.Size(1600, 24);
            this.longNavigator1.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 79);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1600, 496);
            this.grid.TabIndex = 4;
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
            this.colIsletmeAdi,
            this.colKod,
            this.colKapasite,
            this.colHayvanSayisi,
            this.colKayitTarihi,
            this.colPompaAdi,
            this.colPompaCesit,
            this.colIlAdi,
            this.colIlceAdi,
            this.colAdres,
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
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIsletmeAdi, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.tablo.ViewCaption = "Besihane Kartları";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Depo Bilgileri";
            this.gridBand1.Columns.Add(this.colKod);
            this.gridBand1.Columns.Add(this.colKapasite);
            this.gridBand1.Columns.Add(this.colHayvanSayisi);
            this.gridBand1.Columns.Add(this.colKayitTarihi);
            this.gridBand1.Columns.Add(this.colPompaAdi);
            this.gridBand1.Columns.Add(this.colPompaCesit);
            this.gridBand1.Columns.Add(this.colAciklama);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 960;
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Besihane No";
            this.colKod.FieldName = "Kod";
            this.colKod.ImageOptions.Image = global::Windows.UI.Properties.Resources.gettingstarted_16x16;
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.Visible = true;
            this.colKod.Width = 120;
            // 
            // colKapasite
            // 
            this.colKapasite.AppearanceCell.Options.UseTextOptions = true;
            this.colKapasite.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKapasite.Caption = "Depo Kapasitesi";
            this.colKapasite.FieldName = "Kapasite";
            this.colKapasite.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colKapasite.ImageOptions.Image")));
            this.colKapasite.Name = "colKapasite";
            this.colKapasite.OptionsColumn.AllowEdit = false;
            this.colKapasite.Visible = true;
            this.colKapasite.Width = 100;
            // 
            // colHayvanSayisi
            // 
            this.colHayvanSayisi.AppearanceCell.Options.UseTextOptions = true;
            this.colHayvanSayisi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHayvanSayisi.Caption = "Hayvan Sayısı";
            this.colHayvanSayisi.FieldName = "HayvanSayisi";
            this.colHayvanSayisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colHayvanSayisi.ImageOptions.Image")));
            this.colHayvanSayisi.Name = "colHayvanSayisi";
            this.colHayvanSayisi.OptionsColumn.AllowEdit = false;
            this.colHayvanSayisi.Visible = true;
            this.colHayvanSayisi.Width = 100;
            // 
            // colKayitTarihi
            // 
            this.colKayitTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colKayitTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKayitTarihi.Caption = "Kayıt Tarihi";
            this.colKayitTarihi.FieldName = "KayitTarih";
            this.colKayitTarihi.ImageOptions.Image = global::Windows.UI.Properties.Resources.calendar_16x16;
            this.colKayitTarihi.Name = "colKayitTarihi";
            this.colKayitTarihi.OptionsColumn.AllowEdit = false;
            this.colKayitTarihi.Visible = true;
            this.colKayitTarihi.Width = 120;
            // 
            // colPompaAdi
            // 
            this.colPompaAdi.Caption = "Pompa Durumu";
            this.colPompaAdi.FieldName = "PompaAdi";
            this.colPompaAdi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colPompaAdi.ImageOptions.Image")));
            this.colPompaAdi.Name = "colPompaAdi";
            this.colPompaAdi.OptionsColumn.AllowEdit = false;
            this.colPompaAdi.Visible = true;
            this.colPompaAdi.Width = 120;
            // 
            // colPompaCesit
            // 
            this.colPompaCesit.Caption = "Pompa Çeşiti";
            this.colPompaCesit.FieldName = "PompaCesiti";
            this.colPompaCesit.ImageOptions.Image = global::Windows.UI.Properties.Resources.filter_16x16;
            this.colPompaCesit.Name = "colPompaCesit";
            this.colPompaCesit.OptionsColumn.AllowEdit = false;
            this.colPompaCesit.Visible = true;
            this.colPompaCesit.Width = 100;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.ImageOptions.Image = global::Windows.UI.Properties.Resources.comment_16x16;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.Width = 300;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Adres Bilgileri";
            this.gridBand2.Columns.Add(this.colIlAdi);
            this.gridBand2.Columns.Add(this.colIlceAdi);
            this.gridBand2.Columns.Add(this.colAdres);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 550;
            // 
            // colIlAdi
            // 
            this.colIlAdi.Caption = "İl";
            this.colIlAdi.FieldName = "IlAdi";
            this.colIlAdi.ImageOptions.Image = global::Windows.UI.Properties.Resources.country_16x16;
            this.colIlAdi.Name = "colIlAdi";
            this.colIlAdi.OptionsColumn.AllowEdit = false;
            this.colIlAdi.Visible = true;
            this.colIlAdi.Width = 150;
            // 
            // colIlceAdi
            // 
            this.colIlceAdi.Caption = "İlçe";
            this.colIlceAdi.FieldName = "IlceAdi";
            this.colIlceAdi.ImageOptions.Image = global::Windows.UI.Properties.Resources.language_16x16;
            this.colIlceAdi.Name = "colIlceAdi";
            this.colIlceAdi.OptionsColumn.AllowEdit = false;
            this.colIlceAdi.Visible = true;
            this.colIlceAdi.Width = 150;
            // 
            // colAdres
            // 
            this.colAdres.Caption = "Adres";
            this.colAdres.FieldName = "Adres";
            this.colAdres.ImageOptions.Image = global::Windows.UI.Properties.Resources.mapit_16x16;
            this.colAdres.Name = "colAdres";
            this.colAdres.OptionsColumn.AllowEdit = false;
            this.colAdres.Visible = true;
            this.colAdres.Width = 250;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colIsletmeAdi
            // 
            this.colIsletmeAdi.Caption = "İşletme Adı";
            this.colIsletmeAdi.FieldName = "IsletmeAdi";
            this.colIsletmeAdi.ImageOptions.Image = global::Windows.UI.Properties.Resources.card_16x16;
            this.colIsletmeAdi.Name = "colIsletmeAdi";
            this.colIsletmeAdi.OptionsColumn.AllowEdit = false;
            this.colIsletmeAdi.Visible = true;
            // 
            // BesihaneRaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 625);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator1);
            this.IconOptions.ShowIcon = false;
            this.Name = "BesihaneRaporForm";
            this.Text = "Besihane Raporu";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator1, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UseControls.Navigators.LongNavigator longNavigator1;
        private UseControls.Grid.MyBandedGridControl grid;
        private UseControls.Grid.MyBandedGridView tablo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKod;
        private UseControls.Grid.MyBandedGridColumn colKapasite;
        private UseControls.Grid.MyBandedGridColumn colHayvanSayisi;
        private UseControls.Grid.MyBandedGridColumn colKayitTarihi;
        private UseControls.Grid.MyBandedGridColumn colPompaAdi;
        private UseControls.Grid.MyBandedGridColumn colPompaCesit;
        private UseControls.Grid.MyBandedGridColumn colAciklama;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private UseControls.Grid.MyBandedGridColumn colIlAdi;
        private UseControls.Grid.MyBandedGridColumn colIlceAdi;
        private UseControls.Grid.MyBandedGridColumn colAdres;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private UseControls.Grid.MyBandedGridColumn colIsletmeAdi;
    }
}