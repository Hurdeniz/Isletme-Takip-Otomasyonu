
namespace Windows.UI.Concrete.Forms.RaporlarForms.GridForms
{
    partial class UrunSevkiyatDegerleriForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunSevkiyatDegerleriForm));
            this.longNavigator = new Windows.UI.Concrete.UseControls.Navigators.LongNavigator();
            this.grid = new Windows.UI.Concrete.UseControls.Grid.MyGridControl();
            this.tablo = new Windows.UI.Concrete.UseControls.Grid.MyGridView();
            this.colUrunNo = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colUrunAdi = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colUrunSevkiyatTarih = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colUrunSevkiyatNo = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colKod = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colKayitTarihi = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colGirisSaat = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colCikisSaat = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colPhDegeri = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colNem = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colKmOrani = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colTonajMiktari = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colAciklama = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colUrunIsletmeAdi = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
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
            this.colUrunNo,
            this.colUrunAdi,
            this.colUrunIsletmeAdi,
            this.colUrunSevkiyatTarih,
            this.colUrunSevkiyatNo,
            this.colKod,
            this.colKayitTarihi,
            this.colGirisSaat,
            this.colCikisSaat,
            this.colPhDegeri,
            this.colNem,
            this.colKmOrani,
            this.colTonajMiktari,
            this.colAciklama});
            this.tablo.GridControl = this.grid;
            this.tablo.GroupCount = 2;
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
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colUrunAdi, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colUrunSevkiyatTarih, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisayol = null;
            this.tablo.StatusBarKisayolAciklama = null;
            this.tablo.ViewCaption = "Ürün Sevkiyat Değerleri";
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
            this.colUrunNo.VisibleIndex = 0;
            this.colUrunNo.Width = 120;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.Caption = "Ürün Adı";
            this.colUrunAdi.FieldName = "UrunAdi";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.OptionsColumn.AllowEdit = false;
            this.colUrunAdi.StatusBarAciklama = null;
            this.colUrunAdi.StatusBarKisayol = null;
            this.colUrunAdi.StatusBarKisayolAciklama = null;
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 1;
            this.colUrunAdi.Width = 150;
            // 
            // colUrunSevkiyatTarih
            // 
            this.colUrunSevkiyatTarih.AppearanceCell.Options.UseTextOptions = true;
            this.colUrunSevkiyatTarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUrunSevkiyatTarih.Caption = "Sevkiyat Tarihi";
            this.colUrunSevkiyatTarih.FieldName = "UrunSevkiyatTarih";
            this.colUrunSevkiyatTarih.Name = "colUrunSevkiyatTarih";
            this.colUrunSevkiyatTarih.OptionsColumn.AllowEdit = false;
            this.colUrunSevkiyatTarih.StatusBarAciklama = null;
            this.colUrunSevkiyatTarih.StatusBarKisayol = null;
            this.colUrunSevkiyatTarih.StatusBarKisayolAciklama = null;
            this.colUrunSevkiyatTarih.Visible = true;
            this.colUrunSevkiyatTarih.VisibleIndex = 2;
            this.colUrunSevkiyatTarih.Width = 100;
            // 
            // colUrunSevkiyatNo
            // 
            this.colUrunSevkiyatNo.AppearanceCell.Options.UseTextOptions = true;
            this.colUrunSevkiyatNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUrunSevkiyatNo.Caption = "Sevkiyat No";
            this.colUrunSevkiyatNo.FieldName = "UrunSevkiyatNo";
            this.colUrunSevkiyatNo.ImageOptions.Image = global::Windows.UI.Properties.Resources.gettingstarted_16x16;
            this.colUrunSevkiyatNo.Name = "colUrunSevkiyatNo";
            this.colUrunSevkiyatNo.OptionsColumn.AllowEdit = false;
            this.colUrunSevkiyatNo.StatusBarAciklama = null;
            this.colUrunSevkiyatNo.StatusBarKisayol = null;
            this.colUrunSevkiyatNo.StatusBarKisayolAciklama = null;
            this.colUrunSevkiyatNo.Visible = true;
            this.colUrunSevkiyatNo.VisibleIndex = 2;
            this.colUrunSevkiyatNo.Width = 120;
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Fiş No";
            this.colKod.FieldName = "Kod";
            this.colKod.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colKod.ImageOptions.Image")));
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.StatusBarAciklama = null;
            this.colKod.StatusBarKisayol = null;
            this.colKod.StatusBarKisayolAciklama = null;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 3;
            this.colKod.Width = 100;
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
            this.colKayitTarihi.VisibleIndex = 4;
            this.colKayitTarihi.Width = 100;
            // 
            // colGirisSaat
            // 
            this.colGirisSaat.AppearanceCell.Options.UseTextOptions = true;
            this.colGirisSaat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGirisSaat.Caption = "Giriş Saati";
            this.colGirisSaat.FieldName = "GirisSaat";
            this.colGirisSaat.ImageOptions.Image = global::Windows.UI.Properties.Resources.time_16x16;
            this.colGirisSaat.Name = "colGirisSaat";
            this.colGirisSaat.OptionsColumn.AllowEdit = false;
            this.colGirisSaat.StatusBarAciklama = null;
            this.colGirisSaat.StatusBarKisayol = null;
            this.colGirisSaat.StatusBarKisayolAciklama = null;
            this.colGirisSaat.Visible = true;
            this.colGirisSaat.VisibleIndex = 5;
            this.colGirisSaat.Width = 100;
            // 
            // colCikisSaat
            // 
            this.colCikisSaat.AppearanceCell.Options.UseTextOptions = true;
            this.colCikisSaat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCikisSaat.Caption = "Çıkış Saati";
            this.colCikisSaat.FieldName = "CikisSaat";
            this.colCikisSaat.ImageOptions.Image = global::Windows.UI.Properties.Resources.time_16x16;
            this.colCikisSaat.Name = "colCikisSaat";
            this.colCikisSaat.OptionsColumn.AllowEdit = false;
            this.colCikisSaat.StatusBarAciklama = null;
            this.colCikisSaat.StatusBarKisayol = null;
            this.colCikisSaat.StatusBarKisayolAciklama = null;
            this.colCikisSaat.Visible = true;
            this.colCikisSaat.VisibleIndex = 6;
            this.colCikisSaat.Width = 100;
            // 
            // colPhDegeri
            // 
            this.colPhDegeri.AppearanceCell.Options.UseTextOptions = true;
            this.colPhDegeri.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPhDegeri.Caption = "PH Değeri";
            this.colPhDegeri.FieldName = "PhDegeri";
            this.colPhDegeri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colPhDegeri.ImageOptions.Image")));
            this.colPhDegeri.Name = "colPhDegeri";
            this.colPhDegeri.OptionsColumn.AllowEdit = false;
            this.colPhDegeri.StatusBarAciklama = null;
            this.colPhDegeri.StatusBarKisayol = null;
            this.colPhDegeri.StatusBarKisayolAciklama = null;
            this.colPhDegeri.Visible = true;
            this.colPhDegeri.VisibleIndex = 7;
            this.colPhDegeri.Width = 100;
            // 
            // colNem
            // 
            this.colNem.AppearanceCell.Options.UseTextOptions = true;
            this.colNem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colNem.Caption = "Nem Oranı";
            this.colNem.FieldName = "Nem";
            this.colNem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colNem.ImageOptions.Image")));
            this.colNem.Name = "colNem";
            this.colNem.OptionsColumn.AllowEdit = false;
            this.colNem.StatusBarAciklama = null;
            this.colNem.StatusBarKisayol = null;
            this.colNem.StatusBarKisayolAciklama = null;
            this.colNem.Visible = true;
            this.colNem.VisibleIndex = 8;
            this.colNem.Width = 100;
            // 
            // colKmOrani
            // 
            this.colKmOrani.AppearanceCell.Options.UseTextOptions = true;
            this.colKmOrani.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colKmOrani.Caption = "K.M. Oranı";
            this.colKmOrani.FieldName = "KmOrani";
            this.colKmOrani.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colKmOrani.ImageOptions.Image")));
            this.colKmOrani.Name = "colKmOrani";
            this.colKmOrani.OptionsColumn.AllowEdit = false;
            this.colKmOrani.StatusBarAciklama = null;
            this.colKmOrani.StatusBarKisayol = null;
            this.colKmOrani.StatusBarKisayolAciklama = null;
            this.colKmOrani.Visible = true;
            this.colKmOrani.VisibleIndex = 10;
            this.colKmOrani.Width = 100;
            // 
            // colTonajMiktari
            // 
            this.colTonajMiktari.AppearanceCell.Options.UseTextOptions = true;
            this.colTonajMiktari.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTonajMiktari.Caption = "Tonaj Miktarı";
            this.colTonajMiktari.FieldName = "TonajMiktari";
            this.colTonajMiktari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colTonajMiktari.ImageOptions.Image")));
            this.colTonajMiktari.Name = "colTonajMiktari";
            this.colTonajMiktari.OptionsColumn.AllowEdit = false;
            this.colTonajMiktari.StatusBarAciklama = null;
            this.colTonajMiktari.StatusBarKisayol = null;
            this.colTonajMiktari.StatusBarKisayolAciklama = null;
            this.colTonajMiktari.Visible = true;
            this.colTonajMiktari.VisibleIndex = 11;
            this.colTonajMiktari.Width = 100;
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
            this.colAciklama.VisibleIndex = 12;
            this.colAciklama.Width = 300;
            // 
            // colUrunIsletmeAdi
            // 
            this.colUrunIsletmeAdi.Caption = "Geldiği İşletme";
            this.colUrunIsletmeAdi.FieldName = "UrunIsletmeAdi";
            this.colUrunIsletmeAdi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colUrunIsletmeAdi.ImageOptions.Image")));
            this.colUrunIsletmeAdi.Name = "colUrunIsletmeAdi";
            this.colUrunIsletmeAdi.OptionsColumn.AllowEdit = false;
            this.colUrunIsletmeAdi.StatusBarAciklama = null;
            this.colUrunIsletmeAdi.StatusBarKisayol = null;
            this.colUrunIsletmeAdi.StatusBarKisayolAciklama = null;
            this.colUrunIsletmeAdi.Visible = true;
            this.colUrunIsletmeAdi.VisibleIndex = 1;
            this.colUrunIsletmeAdi.Width = 120;
            // 
            // UrunSevkiyatDegerleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 625);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "UrunSevkiyatDegerleriForm";
            this.Text = "Ürün Sevkiyat Değerleri";
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
        private UseControls.Grid.MyGridColumn colUrunNo;
        private UseControls.Grid.MyGridColumn colUrunAdi;
        private UseControls.Grid.MyGridColumn colUrunSevkiyatTarih;
        private UseControls.Grid.MyGridColumn colUrunSevkiyatNo;
        private UseControls.Grid.MyGridColumn colKod;
        private UseControls.Grid.MyGridColumn colKayitTarihi;
        private UseControls.Grid.MyGridColumn colGirisSaat;
        private UseControls.Grid.MyGridColumn colCikisSaat;
        private UseControls.Grid.MyGridColumn colPhDegeri;
        private UseControls.Grid.MyGridColumn colNem;
        private UseControls.Grid.MyGridColumn colKmOrani;
        private UseControls.Grid.MyGridColumn colTonajMiktari;
        private UseControls.Grid.MyGridColumn colAciklama;
        private UseControls.Grid.MyGridColumn colUrunIsletmeAdi;
    }
}