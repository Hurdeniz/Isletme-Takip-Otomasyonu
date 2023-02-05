
namespace Windows.UI.Concrete.Forms.RaporlarForms.GridForms
{
    partial class IsletmeSevkiyatDegerleriForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IsletmeSevkiyatDegerleriForm));
            this.longNavigator = new Windows.UI.Concrete.UseControls.Navigators.LongNavigator();
            this.grid = new Windows.UI.Concrete.UseControls.Grid.MyGridControl();
            this.tablo = new Windows.UI.Concrete.UseControls.Grid.MyGridView();
            this.colIsletmeNo = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colIsletmeAdi = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colIsletmeSevkiyatTarih = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colIsletmeSevkiyatNo = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colKod = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colKayitTarihi = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colGirisSaat = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colCikisSaat = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colPhDegeri = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colNem = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colKmOrani = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colTonajMiktari = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
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
            this.ribbonControl.Size = new System.Drawing.Size(1326, 79);
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
            this.longNavigator.Size = new System.Drawing.Size(1326, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 79);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1326, 496);
            this.grid.TabIndex = 3;
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
            this.colIsletmeNo,
            this.colIsletmeAdi,
            this.colIsletmeSevkiyatTarih,
            this.colIsletmeSevkiyatNo,
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
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIsletmeAdi, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIsletmeSevkiyatTarih, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisayol = null;
            this.tablo.StatusBarKisayolAciklama = null;
            this.tablo.ViewCaption = "İşletme Sevkiyat Değerleri";
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
            this.colIsletmeNo.StatusBarAciklama = null;
            this.colIsletmeNo.StatusBarKisayol = null;
            this.colIsletmeNo.StatusBarKisayolAciklama = null;
            this.colIsletmeNo.Visible = true;
            this.colIsletmeNo.VisibleIndex = 0;
            this.colIsletmeNo.Width = 120;
            // 
            // colIsletmeAdi
            // 
            this.colIsletmeAdi.Caption = "İşletme Adı";
            this.colIsletmeAdi.FieldName = "IsletmeAdi";
            this.colIsletmeAdi.Name = "colIsletmeAdi";
            this.colIsletmeAdi.OptionsColumn.AllowEdit = false;
            this.colIsletmeAdi.StatusBarAciklama = null;
            this.colIsletmeAdi.StatusBarKisayol = null;
            this.colIsletmeAdi.StatusBarKisayolAciklama = null;
            this.colIsletmeAdi.Visible = true;
            this.colIsletmeAdi.VisibleIndex = 1;
            this.colIsletmeAdi.Width = 150;
            // 
            // colIsletmeSevkiyatTarih
            // 
            this.colIsletmeSevkiyatTarih.AppearanceCell.Options.UseTextOptions = true;
            this.colIsletmeSevkiyatTarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsletmeSevkiyatTarih.Caption = "Sevkiyat Tarihi";
            this.colIsletmeSevkiyatTarih.FieldName = "IsletmeSevkiyatTarih";
            this.colIsletmeSevkiyatTarih.Name = "colIsletmeSevkiyatTarih";
            this.colIsletmeSevkiyatTarih.OptionsColumn.AllowEdit = false;
            this.colIsletmeSevkiyatTarih.StatusBarAciklama = null;
            this.colIsletmeSevkiyatTarih.StatusBarKisayol = null;
            this.colIsletmeSevkiyatTarih.StatusBarKisayolAciklama = null;
            this.colIsletmeSevkiyatTarih.Visible = true;
            this.colIsletmeSevkiyatTarih.VisibleIndex = 2;
            this.colIsletmeSevkiyatTarih.Width = 100;
            // 
            // colIsletmeSevkiyatNo
            // 
            this.colIsletmeSevkiyatNo.AppearanceCell.Options.UseTextOptions = true;
            this.colIsletmeSevkiyatNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsletmeSevkiyatNo.Caption = "Sevkiyat No";
            this.colIsletmeSevkiyatNo.FieldName = "IsletmeSevkiyatNo";
            this.colIsletmeSevkiyatNo.ImageOptions.Image = global::Windows.UI.Properties.Resources.gettingstarted_16x16;
            this.colIsletmeSevkiyatNo.Name = "colIsletmeSevkiyatNo";
            this.colIsletmeSevkiyatNo.OptionsColumn.AllowEdit = false;
            this.colIsletmeSevkiyatNo.StatusBarAciklama = null;
            this.colIsletmeSevkiyatNo.StatusBarKisayol = null;
            this.colIsletmeSevkiyatNo.StatusBarKisayolAciklama = null;
            this.colIsletmeSevkiyatNo.Visible = true;
            this.colIsletmeSevkiyatNo.VisibleIndex = 2;
            this.colIsletmeSevkiyatNo.Width = 120;
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
            this.colKod.VisibleIndex = 1;
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
            this.colKayitTarihi.VisibleIndex = 3;
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
            this.colGirisSaat.VisibleIndex = 4;
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
            this.colCikisSaat.VisibleIndex = 5;
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
            this.colPhDegeri.VisibleIndex = 6;
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
            this.colNem.VisibleIndex = 7;
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
            this.colKmOrani.VisibleIndex = 8;
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
            this.colTonajMiktari.VisibleIndex = 9;
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
            this.colAciklama.VisibleIndex = 10;
            this.colAciklama.Width = 300;
            // 
            // IsletmeSevkiyatDegerleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 625);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "IsletmeSevkiyatDegerleriForm";
            this.Text = "İşletme Sevkiyat Değerleri ";
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
        private UseControls.Grid.MyGridColumn colIsletmeAdi;
        private UseControls.Grid.MyGridColumn colIsletmeSevkiyatTarih;
        private UseControls.Grid.MyGridColumn colIsletmeSevkiyatNo;
        private UseControls.Grid.MyGridColumn colKod;
        private UseControls.Grid.MyGridColumn colKayitTarihi;
        private UseControls.Grid.MyGridColumn colGirisSaat;
        private UseControls.Grid.MyGridColumn colCikisSaat;
        private UseControls.Grid.MyGridColumn colPhDegeri;
        private UseControls.Grid.MyGridColumn colNem;
        private UseControls.Grid.MyGridColumn colKmOrani;
        private UseControls.Grid.MyGridColumn colTonajMiktari;
        private UseControls.Grid.MyGridColumn colAciklama;
        private UseControls.Grid.MyGridColumn colIsletmeNo;
    }
}