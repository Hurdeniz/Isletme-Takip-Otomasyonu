
namespace Windows.UI.Concrete.Forms.RaporlarForms
{
    partial class IsletmeRaporForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IsletmeRaporForm));
            this.longNavigator = new Windows.UI.Concrete.UseControls.Navigators.LongNavigator();
            this.grid = new Windows.UI.Concrete.UseControls.Grid.MyGridControl();
            this.tablo = new Windows.UI.Concrete.UseControls.Grid.MyGridView();
            this.colId = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colKod = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colIsletmeAdı = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colIsletmeSahibi = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colTelefon = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colIsletmeKullanici = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colKullaniciTelefon = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colGrupAdi = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colKayitTarihi = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colKapasite = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colHayvanSayisi = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colPompaAdi = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colPompaCesiti = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colIlAdi = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colIlceAdi = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colAdres = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colAciklama = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
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
            this.ribbonControl.Size = new System.Drawing.Size(2409, 79);
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
            this.longNavigator.Location = new System.Drawing.Point(0, 544);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(2409, 24);
            this.longNavigator.TabIndex = 3;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 79);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(2409, 465);
            this.grid.TabIndex = 4;
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
            this.colId,
            this.colKod,
            this.colIsletmeAdı,
            this.colIsletmeSahibi,
            this.colTelefon,
            this.colIsletmeKullanici,
            this.colKullaniciTelefon,
            this.colGrupAdi,
            this.colKayitTarihi,
            this.colKapasite,
            this.colHayvanSayisi,
            this.colPompaAdi,
            this.colPompaCesiti,
            this.colIlAdi,
            this.colIlceAdi,
            this.colAdres,
            this.colAciklama});
            this.tablo.GridControl = this.grid;
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
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisayol = null;
            this.tablo.StatusBarKisayolAciklama = null;
            this.tablo.ViewCaption = "İşletme Kartları";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.StatusBarAciklama = null;
            this.colId.StatusBarKisayol = null;
            this.colId.StatusBarKisayolAciklama = null;
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "İşletme No";
            this.colKod.FieldName = "Kod";
            this.colKod.ImageOptions.Image = global::Windows.UI.Properties.Resources.gettingstarted_16x16;
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.StatusBarAciklama = null;
            this.colKod.StatusBarKisayol = null;
            this.colKod.StatusBarKisayolAciklama = null;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 0;
            this.colKod.Width = 100;
            // 
            // colIsletmeAdı
            // 
            this.colIsletmeAdı.Caption = "İşletme Adı";
            this.colIsletmeAdı.FieldName = "IsletmeAdi";
            this.colIsletmeAdı.ImageOptions.Image = global::Windows.UI.Properties.Resources.card_16x16;
            this.colIsletmeAdı.Name = "colIsletmeAdı";
            this.colIsletmeAdı.OptionsColumn.AllowEdit = false;
            this.colIsletmeAdı.StatusBarAciklama = null;
            this.colIsletmeAdı.StatusBarKisayol = null;
            this.colIsletmeAdı.StatusBarKisayolAciklama = null;
            this.colIsletmeAdı.Visible = true;
            this.colIsletmeAdı.VisibleIndex = 1;
            this.colIsletmeAdı.Width = 150;
            // 
            // colIsletmeSahibi
            // 
            this.colIsletmeSahibi.Caption = "İşletme Sahibi";
            this.colIsletmeSahibi.FieldName = "IsletmeSahibiAdi";
            this.colIsletmeSahibi.ImageOptions.Image = global::Windows.UI.Properties.Resources.customer_16x16;
            this.colIsletmeSahibi.Name = "colIsletmeSahibi";
            this.colIsletmeSahibi.OptionsColumn.AllowEdit = false;
            this.colIsletmeSahibi.StatusBarAciklama = null;
            this.colIsletmeSahibi.StatusBarKisayol = null;
            this.colIsletmeSahibi.StatusBarKisayolAciklama = null;
            this.colIsletmeSahibi.Visible = true;
            this.colIsletmeSahibi.VisibleIndex = 2;
            this.colIsletmeSahibi.Width = 150;
            // 
            // colTelefon
            // 
            this.colTelefon.AppearanceCell.Options.UseTextOptions = true;
            this.colTelefon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTelefon.Caption = "Telefon";
            this.colTelefon.FieldName = "IsletmeSahibiTelefon";
            this.colTelefon.ImageOptions.Image = global::Windows.UI.Properties.Resources.mobilephone2_16x16;
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.OptionsColumn.AllowEdit = false;
            this.colTelefon.StatusBarAciklama = null;
            this.colTelefon.StatusBarKisayol = null;
            this.colTelefon.StatusBarKisayolAciklama = null;
            this.colTelefon.Visible = true;
            this.colTelefon.VisibleIndex = 3;
            this.colTelefon.Width = 120;
            // 
            // colIsletmeKullanici
            // 
            this.colIsletmeKullanici.AppearanceCell.Options.UseTextOptions = true;
            this.colIsletmeKullanici.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsletmeKullanici.Caption = "İşletme Kullanıcı";
            this.colIsletmeKullanici.FieldName = "IsletmeKullaniciKisiAdiSoyadi";
            this.colIsletmeKullanici.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colIsletmeKullanici.ImageOptions.Image")));
            this.colIsletmeKullanici.Name = "colIsletmeKullanici";
            this.colIsletmeKullanici.OptionsColumn.AllowEdit = false;
            this.colIsletmeKullanici.StatusBarAciklama = null;
            this.colIsletmeKullanici.StatusBarKisayol = null;
            this.colIsletmeKullanici.StatusBarKisayolAciklama = null;
            this.colIsletmeKullanici.Visible = true;
            this.colIsletmeKullanici.VisibleIndex = 4;
            this.colIsletmeKullanici.Width = 150;
            // 
            // colKullaniciTelefon
            // 
            this.colKullaniciTelefon.AppearanceCell.Options.UseTextOptions = true;
            this.colKullaniciTelefon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKullaniciTelefon.Caption = "Kullanıcı Telefon";
            this.colKullaniciTelefon.FieldName = "IsletmeKullaniciKisiTelefon";
            this.colKullaniciTelefon.ImageOptions.Image = global::Windows.UI.Properties.Resources.mobilephone2_16x16;
            this.colKullaniciTelefon.Name = "colKullaniciTelefon";
            this.colKullaniciTelefon.OptionsColumn.AllowEdit = false;
            this.colKullaniciTelefon.StatusBarAciklama = null;
            this.colKullaniciTelefon.StatusBarKisayol = null;
            this.colKullaniciTelefon.StatusBarKisayolAciklama = null;
            this.colKullaniciTelefon.Visible = true;
            this.colKullaniciTelefon.VisibleIndex = 5;
            this.colKullaniciTelefon.Width = 120;
            // 
            // colGrupAdi
            // 
            this.colGrupAdi.AppearanceCell.Options.UseTextOptions = true;
            this.colGrupAdi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGrupAdi.Caption = "Grup Adı";
            this.colGrupAdi.FieldName = "GrupKodAdi";
            this.colGrupAdi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colGrupAdi.ImageOptions.Image")));
            this.colGrupAdi.Name = "colGrupAdi";
            this.colGrupAdi.OptionsColumn.AllowEdit = false;
            this.colGrupAdi.StatusBarAciklama = null;
            this.colGrupAdi.StatusBarKisayol = null;
            this.colGrupAdi.StatusBarKisayolAciklama = null;
            this.colGrupAdi.Visible = true;
            this.colGrupAdi.VisibleIndex = 6;
            this.colGrupAdi.Width = 150;
            // 
            // colKayitTarihi
            // 
            this.colKayitTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colKayitTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKayitTarihi.Caption = "Kayıt Tarihi";
            this.colKayitTarihi.FieldName = "KayitTarihi";
            this.colKayitTarihi.ImageOptions.Image = global::Windows.UI.Properties.Resources.calendar_16x16;
            this.colKayitTarihi.Name = "colKayitTarihi";
            this.colKayitTarihi.OptionsColumn.AllowEdit = false;
            this.colKayitTarihi.StatusBarAciklama = null;
            this.colKayitTarihi.StatusBarKisayol = null;
            this.colKayitTarihi.StatusBarKisayolAciklama = null;
            this.colKayitTarihi.Visible = true;
            this.colKayitTarihi.VisibleIndex = 7;
            this.colKayitTarihi.Width = 150;
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
            this.colKapasite.StatusBarAciklama = null;
            this.colKapasite.StatusBarKisayol = null;
            this.colKapasite.StatusBarKisayolAciklama = null;
            this.colKapasite.Visible = true;
            this.colKapasite.VisibleIndex = 8;
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
            this.colHayvanSayisi.StatusBarAciklama = null;
            this.colHayvanSayisi.StatusBarKisayol = null;
            this.colHayvanSayisi.StatusBarKisayolAciklama = null;
            this.colHayvanSayisi.Visible = true;
            this.colHayvanSayisi.VisibleIndex = 9;
            this.colHayvanSayisi.Width = 100;
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
            this.colPompaAdi.StatusBarAciklama = null;
            this.colPompaAdi.StatusBarKisayol = null;
            this.colPompaAdi.StatusBarKisayolAciklama = null;
            this.colPompaAdi.Visible = true;
            this.colPompaAdi.VisibleIndex = 10;
            this.colPompaAdi.Width = 120;
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
            this.colPompaCesiti.StatusBarAciklama = null;
            this.colPompaCesiti.StatusBarKisayol = null;
            this.colPompaCesiti.StatusBarKisayolAciklama = null;
            this.colPompaCesiti.Visible = true;
            this.colPompaCesiti.VisibleIndex = 11;
            this.colPompaCesiti.Width = 120;
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
            this.colIlAdi.StatusBarAciklama = null;
            this.colIlAdi.StatusBarKisayol = null;
            this.colIlAdi.StatusBarKisayolAciklama = null;
            this.colIlAdi.Visible = true;
            this.colIlAdi.VisibleIndex = 12;
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
            this.colIlceAdi.StatusBarAciklama = null;
            this.colIlceAdi.StatusBarKisayol = null;
            this.colIlceAdi.StatusBarKisayolAciklama = null;
            this.colIlceAdi.Visible = true;
            this.colIlceAdi.VisibleIndex = 13;
            this.colIlceAdi.Width = 120;
            // 
            // colAdres
            // 
            this.colAdres.Caption = "Adres";
            this.colAdres.FieldName = "Adres";
            this.colAdres.ImageOptions.Image = global::Windows.UI.Properties.Resources.mapit_16x16;
            this.colAdres.Name = "colAdres";
            this.colAdres.OptionsColumn.AllowEdit = false;
            this.colAdres.StatusBarAciklama = null;
            this.colAdres.StatusBarKisayol = null;
            this.colAdres.StatusBarKisayolAciklama = null;
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 14;
            this.colAdres.Width = 250;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.ImageOptions.Image = global::Windows.UI.Properties.Resources.comment_16x16;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.StatusBarAciklama = null;
            this.colAciklama.StatusBarKisayol = null;
            this.colAciklama.StatusBarKisayolAciklama = null;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 15;
            this.colAciklama.Width = 300;
            // 
            // IsletmeRaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2409, 594);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "IsletmeRaporForm";
            this.Text = "İşletme Raporu";
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
        private UseControls.Grid.MyGridColumn colId;
        private UseControls.Grid.MyGridColumn colKod;
        private UseControls.Grid.MyGridColumn colIsletmeAdı;
        private UseControls.Grid.MyGridColumn colIsletmeSahibi;
        private UseControls.Grid.MyGridColumn colTelefon;
        private UseControls.Grid.MyGridColumn colIsletmeKullanici;
        private UseControls.Grid.MyGridColumn colKullaniciTelefon;
        private UseControls.Grid.MyGridColumn colGrupAdi;
        private UseControls.Grid.MyGridColumn colKayitTarihi;
        private UseControls.Grid.MyGridColumn colKapasite;
        private UseControls.Grid.MyGridColumn colHayvanSayisi;
        private UseControls.Grid.MyGridColumn colPompaAdi;
        private UseControls.Grid.MyGridColumn colPompaCesiti;
        private UseControls.Grid.MyGridColumn colIlAdi;
        private UseControls.Grid.MyGridColumn colIlceAdi;
        private UseControls.Grid.MyGridColumn colAdres;
        private UseControls.Grid.MyGridColumn colAciklama;
    }
}