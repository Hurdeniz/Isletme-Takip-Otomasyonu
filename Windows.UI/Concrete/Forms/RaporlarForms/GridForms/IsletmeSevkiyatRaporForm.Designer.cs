
namespace Windows.UI.Concrete.Forms.RaporlarForms.GridForms
{
    partial class IsletmeSevkiyatRaporForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IsletmeSevkiyatRaporForm));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRule2ColorScale formatConditionRule2ColorScale1 = new DevExpress.XtraEditors.FormatConditionRule2ColorScale();
            this.colIsletmeAdi = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colSevkiyatNo = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.longNavigator = new Windows.UI.Concrete.UseControls.Navigators.LongNavigator();
            this.grid = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridControl();
            this.tablo = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridView();
            this.bandIsletmeBilgileri = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colIsletmeNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colIsletmeSahibiAdi = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colIsletmeKullaniciKisi = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colPompaAdi = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colPompaCesiti = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colKapasite = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colHayvanSayisi = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colAdresBilgileri = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colIlAdi = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colIlceAdi = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colAdres = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.bandSevkiyatBilgileri = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSevkiyatTarih = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colSevkiyatSaat = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colSoforAdiSoyadi = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colAracTipi = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colAracSayisi = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colAracPlaka = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colJsb = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
            this.colAciklama = new Windows.UI.Concrete.UseControls.Grid.MyBandedGridColumn();
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
            this.ribbonControl.Size = new System.Drawing.Size(1940, 79);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // colIsletmeAdi
            // 
            this.colIsletmeAdi.AppearanceCell.Options.UseTextOptions = true;
            this.colIsletmeAdi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsletmeAdi.Caption = "İşletme Adı";
            this.colIsletmeAdi.FieldName = "IsletmeAdi";
            this.colIsletmeAdi.ImageOptions.Image = global::Windows.UI.Properties.Resources.card_16x16;
            this.colIsletmeAdi.Name = "colIsletmeAdi";
            this.colIsletmeAdi.OptionsColumn.AllowEdit = false;
            this.colIsletmeAdi.Visible = true;
            this.colIsletmeAdi.Width = 120;
            // 
            // colSevkiyatNo
            // 
            this.colSevkiyatNo.AppearanceCell.Options.UseTextOptions = true;
            this.colSevkiyatNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSevkiyatNo.Caption = "Sevkiyat No";
            this.colSevkiyatNo.FieldName = "SevkiyatNo";
            this.colSevkiyatNo.ImageOptions.Image = global::Windows.UI.Properties.Resources.gettingstarted_16x16;
            this.colSevkiyatNo.Name = "colSevkiyatNo";
            this.colSevkiyatNo.OptionsColumn.AllowEdit = false;
            this.colSevkiyatNo.Visible = true;
            this.colSevkiyatNo.Width = 120;
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 495);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1940, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 79);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1940, 416);
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
            this.bandIsletmeBilgileri,
            this.colAdresBilgileri,
            this.bandSevkiyatBilgileri});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colIsletmeNo,
            this.colIsletmeAdi,
            this.colIsletmeSahibiAdi,
            this.colIsletmeKullaniciKisi,
            this.colKapasite,
            this.colHayvanSayisi,
            this.colPompaAdi,
            this.colPompaCesiti,
            this.colIlAdi,
            this.colIlceAdi,
            this.colAdres,
            this.colSevkiyatNo,
            this.colSevkiyatTarih,
            this.colSevkiyatSaat,
            this.colJsb,
            this.colAracTipi,
            this.colSoforAdiSoyadi,
            this.colAracSayisi,
            this.colAracPlaka,
            this.colAciklama});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colIsletmeAdi;
            gridFormatRule1.ColumnApplyTo = this.colSevkiyatNo;
            gridFormatRule1.Name = "Format0";
            gridFormatRule1.Rule = formatConditionRule2ColorScale1;
            this.tablo.FormatRules.Add(gridFormatRule1);
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
            this.tablo.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowAutoFilterRow = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIsletmeAdi, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.tablo.ViewCaption = "İşletme Sevkiyat Kartları";
            // 
            // bandIsletmeBilgileri
            // 
            this.bandIsletmeBilgileri.Caption = "İşletme Bilgileri";
            this.bandIsletmeBilgileri.Columns.Add(this.colIsletmeNo);
            this.bandIsletmeBilgileri.Columns.Add(this.colIsletmeAdi);
            this.bandIsletmeBilgileri.Columns.Add(this.colIsletmeSahibiAdi);
            this.bandIsletmeBilgileri.Columns.Add(this.colIsletmeKullaniciKisi);
            this.bandIsletmeBilgileri.Columns.Add(this.colPompaAdi);
            this.bandIsletmeBilgileri.Columns.Add(this.colPompaCesiti);
            this.bandIsletmeBilgileri.Columns.Add(this.colKapasite);
            this.bandIsletmeBilgileri.Columns.Add(this.colHayvanSayisi);
            this.bandIsletmeBilgileri.Name = "bandIsletmeBilgileri";
            this.bandIsletmeBilgileri.VisibleIndex = 0;
            this.bandIsletmeBilgileri.Width = 890;
            // 
            // colIsletmeNo
            // 
            this.colIsletmeNo.AppearanceCell.Options.UseTextOptions = true;
            this.colIsletmeNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsletmeNo.Caption = "İşletme No";
            this.colIsletmeNo.FieldName = "IsletmeNo";
            this.colIsletmeNo.ImageOptions.Image = global::Windows.UI.Properties.Resources.gettingstarted_16x16;
            this.colIsletmeNo.Name = "colIsletmeNo";
            this.colIsletmeNo.OptionsColumn.AllowEdit = false;
            this.colIsletmeNo.Visible = true;
            this.colIsletmeNo.Width = 120;
            // 
            // colIsletmeSahibiAdi
            // 
            this.colIsletmeSahibiAdi.AppearanceCell.Options.UseTextOptions = true;
            this.colIsletmeSahibiAdi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsletmeSahibiAdi.Caption = "İşletme Sahibi";
            this.colIsletmeSahibiAdi.FieldName = "IsletmeSahibiAdi";
            this.colIsletmeSahibiAdi.ImageOptions.Image = global::Windows.UI.Properties.Resources.customer_16x16;
            this.colIsletmeSahibiAdi.Name = "colIsletmeSahibiAdi";
            this.colIsletmeSahibiAdi.OptionsColumn.AllowEdit = false;
            this.colIsletmeSahibiAdi.Visible = true;
            this.colIsletmeSahibiAdi.Width = 120;
            // 
            // colIsletmeKullaniciKisi
            // 
            this.colIsletmeKullaniciKisi.AppearanceCell.Options.UseTextOptions = true;
            this.colIsletmeKullaniciKisi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsletmeKullaniciKisi.Caption = "İşletme Kullanıcı";
            this.colIsletmeKullaniciKisi.FieldName = "IsletmeKullaniciKisi";
            this.colIsletmeKullaniciKisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colIsletmeKullaniciKisi.ImageOptions.Image")));
            this.colIsletmeKullaniciKisi.Name = "colIsletmeKullaniciKisi";
            this.colIsletmeKullaniciKisi.OptionsColumn.AllowEdit = false;
            this.colIsletmeKullaniciKisi.Visible = true;
            this.colIsletmeKullaniciKisi.Width = 120;
            // 
            // colPompaAdi
            // 
            this.colPompaAdi.AppearanceCell.Options.UseTextOptions = true;
            this.colPompaAdi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPompaAdi.Caption = "Pompa Adı";
            this.colPompaAdi.FieldName = "PompaAdi";
            this.colPompaAdi.ImageOptions.Image = global::Windows.UI.Properties.Resources.filterbyargument_pie_16x16;
            this.colPompaAdi.Name = "colPompaAdi";
            this.colPompaAdi.OptionsColumn.AllowEdit = false;
            this.colPompaAdi.Visible = true;
            this.colPompaAdi.Width = 110;
            // 
            // colPompaCesiti
            // 
            this.colPompaCesiti.AppearanceCell.Options.UseTextOptions = true;
            this.colPompaCesiti.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPompaCesiti.Caption = "Pompa Çeşiti";
            this.colPompaCesiti.FieldName = "PompaCesiti";
            this.colPompaCesiti.ImageOptions.Image = global::Windows.UI.Properties.Resources.filter_16x16;
            this.colPompaCesiti.Name = "colPompaCesiti";
            this.colPompaCesiti.OptionsColumn.AllowEdit = false;
            this.colPompaCesiti.Visible = true;
            this.colPompaCesiti.Width = 100;
            // 
            // colKapasite
            // 
            this.colKapasite.AppearanceCell.Options.UseTextOptions = true;
            this.colKapasite.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKapasite.Caption = "Kapasite";
            this.colKapasite.FieldName = "Kapasite";
            this.colKapasite.ImageOptions.Image = global::Windows.UI.Properties.Resources.piestyledonut_16x16;
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
            this.colHayvanSayisi.ImageOptions.Image = global::Windows.UI.Properties.Resources.show_16x16;
            this.colHayvanSayisi.Name = "colHayvanSayisi";
            this.colHayvanSayisi.OptionsColumn.AllowEdit = false;
            this.colHayvanSayisi.Visible = true;
            this.colHayvanSayisi.Width = 100;
            // 
            // colAdresBilgileri
            // 
            this.colAdresBilgileri.Caption = "Adres Bilgileri";
            this.colAdresBilgileri.Columns.Add(this.colIlAdi);
            this.colAdresBilgileri.Columns.Add(this.colIlceAdi);
            this.colAdresBilgileri.Columns.Add(this.colAdres);
            this.colAdresBilgileri.Name = "colAdresBilgileri";
            this.colAdresBilgileri.VisibleIndex = 1;
            this.colAdresBilgileri.Width = 540;
            // 
            // colIlAdi
            // 
            this.colIlAdi.AppearanceCell.Options.UseTextOptions = true;
            this.colIlAdi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIlAdi.Caption = "İl";
            this.colIlAdi.FieldName = "IlAdi";
            this.colIlAdi.ImageOptions.Image = global::Windows.UI.Properties.Resources.country_16x16;
            this.colIlAdi.Name = "colIlAdi";
            this.colIlAdi.OptionsColumn.AllowEdit = false;
            this.colIlAdi.Visible = true;
            this.colIlAdi.Width = 120;
            // 
            // colIlceAdi
            // 
            this.colIlceAdi.AppearanceCell.Options.UseTextOptions = true;
            this.colIlceAdi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIlceAdi.Caption = "İlçe";
            this.colIlceAdi.FieldName = "IlceAdi";
            this.colIlceAdi.ImageOptions.Image = global::Windows.UI.Properties.Resources.language_16x16;
            this.colIlceAdi.Name = "colIlceAdi";
            this.colIlceAdi.OptionsColumn.AllowEdit = false;
            this.colIlceAdi.Visible = true;
            this.colIlceAdi.Width = 120;
            // 
            // colAdres
            // 
            this.colAdres.Caption = "Adres";
            this.colAdres.FieldName = "Adres";
            this.colAdres.ImageOptions.Image = global::Windows.UI.Properties.Resources.mapit_16x16;
            this.colAdres.Name = "colAdres";
            this.colAdres.OptionsColumn.AllowEdit = false;
            this.colAdres.Visible = true;
            this.colAdres.Width = 300;
            // 
            // bandSevkiyatBilgileri
            // 
            this.bandSevkiyatBilgileri.Caption = "Sevkiyat Bilgileri";
            this.bandSevkiyatBilgileri.Columns.Add(this.colSevkiyatNo);
            this.bandSevkiyatBilgileri.Columns.Add(this.colSevkiyatTarih);
            this.bandSevkiyatBilgileri.Columns.Add(this.colSevkiyatSaat);
            this.bandSevkiyatBilgileri.Columns.Add(this.colSoforAdiSoyadi);
            this.bandSevkiyatBilgileri.Columns.Add(this.colAracTipi);
            this.bandSevkiyatBilgileri.Columns.Add(this.colAracSayisi);
            this.bandSevkiyatBilgileri.Columns.Add(this.colAracPlaka);
            this.bandSevkiyatBilgileri.Columns.Add(this.colJsb);
            this.bandSevkiyatBilgileri.Columns.Add(this.colAciklama);
            this.bandSevkiyatBilgileri.Name = "bandSevkiyatBilgileri";
            this.bandSevkiyatBilgileri.VisibleIndex = 2;
            this.bandSevkiyatBilgileri.Width = 1050;
            // 
            // colSevkiyatTarih
            // 
            this.colSevkiyatTarih.AppearanceCell.Options.UseTextOptions = true;
            this.colSevkiyatTarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSevkiyatTarih.Caption = "Sevkiyat Tarihi";
            this.colSevkiyatTarih.FieldName = "SevkiyatTarih";
            this.colSevkiyatTarih.ImageOptions.Image = global::Windows.UI.Properties.Resources.calendar_16x16;
            this.colSevkiyatTarih.Name = "colSevkiyatTarih";
            this.colSevkiyatTarih.OptionsColumn.AllowEdit = false;
            this.colSevkiyatTarih.Visible = true;
            this.colSevkiyatTarih.Width = 110;
            // 
            // colSevkiyatSaat
            // 
            this.colSevkiyatSaat.AppearanceCell.Options.UseTextOptions = true;
            this.colSevkiyatSaat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSevkiyatSaat.Caption = "Sevkiyat Saati";
            this.colSevkiyatSaat.FieldName = "SevkiyatSaat";
            this.colSevkiyatSaat.ImageOptions.Image = global::Windows.UI.Properties.Resources.time_16x16;
            this.colSevkiyatSaat.Name = "colSevkiyatSaat";
            this.colSevkiyatSaat.OptionsColumn.AllowEdit = false;
            this.colSevkiyatSaat.Visible = true;
            this.colSevkiyatSaat.Width = 100;
            // 
            // colSoforAdiSoyadi
            // 
            this.colSoforAdiSoyadi.AppearanceCell.Options.UseTextOptions = true;
            this.colSoforAdiSoyadi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoforAdiSoyadi.Caption = "Şoför";
            this.colSoforAdiSoyadi.FieldName = "SoforAdiSoyadi";
            this.colSoforAdiSoyadi.ImageOptions.Image = global::Windows.UI.Properties.Resources.contact_16x16;
            this.colSoforAdiSoyadi.Name = "colSoforAdiSoyadi";
            this.colSoforAdiSoyadi.OptionsColumn.AllowEdit = false;
            this.colSoforAdiSoyadi.Visible = true;
            this.colSoforAdiSoyadi.Width = 120;
            // 
            // colAracTipi
            // 
            this.colAracTipi.AppearanceCell.Options.UseTextOptions = true;
            this.colAracTipi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAracTipi.Caption = "Araç Tipi";
            this.colAracTipi.FieldName = "AracTipi";
            this.colAracTipi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colAracTipi.ImageOptions.Image")));
            this.colAracTipi.Name = "colAracTipi";
            this.colAracTipi.OptionsColumn.AllowEdit = false;
            this.colAracTipi.Visible = true;
            this.colAracTipi.Width = 100;
            // 
            // colAracSayisi
            // 
            this.colAracSayisi.AppearanceCell.Options.UseTextOptions = true;
            this.colAracSayisi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAracSayisi.Caption = "Araç Sayısı";
            this.colAracSayisi.FieldName = "AracSayisi";
            this.colAracSayisi.ImageOptions.Image = global::Windows.UI.Properties.Resources.driving_16x16;
            this.colAracSayisi.Name = "colAracSayisi";
            this.colAracSayisi.OptionsColumn.AllowEdit = false;
            this.colAracSayisi.Visible = true;
            this.colAracSayisi.Width = 100;
            // 
            // colAracPlaka
            // 
            this.colAracPlaka.AppearanceCell.Options.UseTextOptions = true;
            this.colAracPlaka.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAracPlaka.Caption = "Araç Plaka";
            this.colAracPlaka.FieldName = "AracPlaka";
            this.colAracPlaka.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colAracPlaka.ImageOptions.Image")));
            this.colAracPlaka.Name = "colAracPlaka";
            this.colAracPlaka.OptionsColumn.AllowEdit = false;
            this.colAracPlaka.Visible = true;
            this.colAracPlaka.Width = 100;
            // 
            // colJsb
            // 
            this.colJsb.AppearanceCell.Options.UseTextOptions = true;
            this.colJsb.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colJsb.Caption = "Jsb";
            this.colJsb.FieldName = "Jsb";
            this.colJsb.ImageOptions.Image = global::Windows.UI.Properties.Resources.apply_16x16;
            this.colJsb.Name = "colJsb";
            this.colJsb.OptionsColumn.AllowEdit = false;
            this.colJsb.Visible = true;
            this.colJsb.Width = 100;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.ImageOptions.Image = global::Windows.UI.Properties.Resources.comment_16x16;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.Width = 200;
            // 
            // IsletmeSevkiyatRaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 545);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "IsletmeSevkiyatRaporForm";
            this.Text = "İşletme Sevkiyat Raporu";
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
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIsletmeNo;
        private UseControls.Grid.MyBandedGridColumn colIsletmeAdi;
        private UseControls.Grid.MyBandedGridColumn colIsletmeSahibiAdi;
        private UseControls.Grid.MyBandedGridColumn colIsletmeKullaniciKisi;
        private UseControls.Grid.MyBandedGridColumn colKapasite;
        private UseControls.Grid.MyBandedGridColumn colHayvanSayisi;
        private UseControls.Grid.MyBandedGridColumn colPompaAdi;
        private UseControls.Grid.MyBandedGridColumn colPompaCesiti;
        private UseControls.Grid.MyBandedGridColumn colIlAdi;
        private UseControls.Grid.MyBandedGridColumn colIlceAdi;
        private UseControls.Grid.MyBandedGridColumn colAdres;
        private UseControls.Grid.MyBandedGridColumn colSevkiyatNo;
        private UseControls.Grid.MyBandedGridColumn colSevkiyatTarih;
        private UseControls.Grid.MyBandedGridColumn colSevkiyatSaat;
        private UseControls.Grid.MyBandedGridColumn colSoforAdiSoyadi;
        private UseControls.Grid.MyBandedGridColumn colAracTipi;
        private UseControls.Grid.MyBandedGridColumn colAracSayisi;
        private UseControls.Grid.MyBandedGridColumn colAracPlaka;
        private UseControls.Grid.MyBandedGridColumn colJsb;
        private UseControls.Grid.MyBandedGridColumn colAciklama;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandIsletmeBilgileri;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand colAdresBilgileri;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandSevkiyatBilgileri;
    }
}