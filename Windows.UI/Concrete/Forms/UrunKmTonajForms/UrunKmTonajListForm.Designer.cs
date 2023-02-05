
namespace Windows.UI.Concrete.Forms.UrunKmTonajForms
{
    partial class UrunKmTonajListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunKmTonajListForm));
            this.longNavigator = new Windows.UI.Concrete.UseControls.Navigators.LongNavigator();
            this.grid = new Windows.UI.Concrete.UseControls.Grid.MyGridControl();
            this.tablo = new Windows.UI.Concrete.UseControls.Grid.MyGridView();
            this.colId = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colKod = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colUrunIsletmeAdi = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
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
            this.ribbonControl.Size = new System.Drawing.Size(1359, 109);
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
            this.longNavigator.Location = new System.Drawing.Point(0, 479);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1359, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 109);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.MinimumSize = new System.Drawing.Size(1359, 370);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1359, 370);
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
            this.colId,
            this.colKod,
            this.colUrunIsletmeAdi,
            this.colKayitTarihi,
            this.colGirisSaat,
            this.colCikisSaat,
            this.colPhDegeri,
            this.colNem,
            this.colKmOrani,
            this.colTonajMiktari,
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
            this.tablo.ViewCaption = "Ürün Sevkiyat Değeleri";
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
            this.colKod.Caption = "Fiş No";
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
            // colUrunIsletmeAdi
            // 
            this.colUrunIsletmeAdi.AppearanceCell.Options.UseTextOptions = true;
            this.colUrunIsletmeAdi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUrunIsletmeAdi.Caption = "Geldiği Yer";
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
            this.colKayitTarihi.VisibleIndex = 2;
            this.colKayitTarihi.Width = 120;
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
            this.colGirisSaat.VisibleIndex = 3;
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
            this.colCikisSaat.VisibleIndex = 4;
            this.colCikisSaat.Width = 100;
            // 
            // colPhDegeri
            // 
            this.colPhDegeri.AppearanceCell.Options.UseTextOptions = true;
            this.colPhDegeri.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPhDegeri.Caption = "Ph Değeri";
            this.colPhDegeri.FieldName = "PhDegeri";
            this.colPhDegeri.ImageOptions.Image = global::Windows.UI.Properties.Resources.hight_16x16;
            this.colPhDegeri.Name = "colPhDegeri";
            this.colPhDegeri.OptionsColumn.AllowEdit = false;
            this.colPhDegeri.StatusBarAciklama = null;
            this.colPhDegeri.StatusBarKisayol = null;
            this.colPhDegeri.StatusBarKisayolAciklama = null;
            this.colPhDegeri.Visible = true;
            this.colPhDegeri.VisibleIndex = 5;
            this.colPhDegeri.Width = 120;
            // 
            // colNem
            // 
            this.colNem.AppearanceCell.Options.UseTextOptions = true;
            this.colNem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colNem.Caption = "Nem";
            this.colNem.FieldName = "Nem";
            this.colNem.ImageOptions.Image = global::Windows.UI.Properties.Resources.medium_16x16;
            this.colNem.Name = "colNem";
            this.colNem.OptionsColumn.AllowEdit = false;
            this.colNem.StatusBarAciklama = null;
            this.colNem.StatusBarKisayol = null;
            this.colNem.StatusBarKisayolAciklama = null;
            this.colNem.Visible = true;
            this.colNem.VisibleIndex = 6;
            this.colNem.Width = 120;
            // 
            // colKmOrani
            // 
            this.colKmOrani.AppearanceCell.Options.UseTextOptions = true;
            this.colKmOrani.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colKmOrani.Caption = "Km Oranı";
            this.colKmOrani.FieldName = "KmOrani";
            this.colKmOrani.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colKmOrani.ImageOptions.Image")));
            this.colKmOrani.Name = "colKmOrani";
            this.colKmOrani.OptionsColumn.AllowEdit = false;
            this.colKmOrani.StatusBarAciklama = null;
            this.colKmOrani.StatusBarKisayol = null;
            this.colKmOrani.StatusBarKisayolAciklama = null;
            this.colKmOrani.Visible = true;
            this.colKmOrani.VisibleIndex = 7;
            this.colKmOrani.Width = 120;
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
            this.colTonajMiktari.VisibleIndex = 8;
            this.colTonajMiktari.Width = 120;
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
            this.colAciklama.VisibleIndex = 9;
            this.colAciklama.Width = 300;
            // 
            // UrunKmTonajListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 529);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "UrunKmTonajListForm";
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
        private UseControls.Grid.MyGridColumn colId;
        private UseControls.Grid.MyGridColumn colKod;
        private UseControls.Grid.MyGridColumn colUrunIsletmeAdi;
        private UseControls.Grid.MyGridColumn colKayitTarihi;
        private UseControls.Grid.MyGridColumn colGirisSaat;
        private UseControls.Grid.MyGridColumn colCikisSaat;
        private UseControls.Grid.MyGridColumn colPhDegeri;
        private UseControls.Grid.MyGridColumn colNem;
        private UseControls.Grid.MyGridColumn colKmOrani;
        private UseControls.Grid.MyGridColumn colTonajMiktari;
        private UseControls.Grid.MyGridColumn colAciklama;
    }
}