
namespace Windows.UI.Concrete.Forms.UrunIsletmeForms
{
    partial class UrunIsletmeListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunIsletmeListForm));
            this.longNavigator = new Windows.UI.Concrete.UseControls.Navigators.LongNavigator();
            this.grid = new Windows.UI.Concrete.UseControls.Grid.MyGridControl();
            this.tablo = new Windows.UI.Concrete.UseControls.Grid.MyGridView();
            this.colId = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colKod = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colUrunIsletmeAdi = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colUrunIsletmeTelefon = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colKayitTarihi = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
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
            this.ribbonControl.Size = new System.Drawing.Size(1314, 109);
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
            this.longNavigator.Location = new System.Drawing.Point(0, 470);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1314, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 109);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1314, 361);
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
            this.colId,
            this.colKod,
            this.colUrunIsletmeAdi,
            this.colUrunIsletmeTelefon,
            this.colKayitTarihi,
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
            this.tablo.ViewCaption = "Ürün İşletme Kartları";
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
            this.colKod.Width = 120;
            // 
            // colUrunIsletmeAdi
            // 
            this.colUrunIsletmeAdi.AppearanceCell.Options.UseTextOptions = true;
            this.colUrunIsletmeAdi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUrunIsletmeAdi.Caption = "İşletme Adı";
            this.colUrunIsletmeAdi.FieldName = "UrunIsletmeAdi";
            this.colUrunIsletmeAdi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colUrunIsletmeAdi.ImageOptions.Image")));
            this.colUrunIsletmeAdi.Name = "colUrunIsletmeAdi";
            this.colUrunIsletmeAdi.OptionsColumn.AllowEdit = false;
            this.colUrunIsletmeAdi.StatusBarAciklama = null;
            this.colUrunIsletmeAdi.StatusBarKisayol = null;
            this.colUrunIsletmeAdi.StatusBarKisayolAciklama = null;
            this.colUrunIsletmeAdi.Visible = true;
            this.colUrunIsletmeAdi.VisibleIndex = 1;
            this.colUrunIsletmeAdi.Width = 150;
            // 
            // colUrunIsletmeTelefon
            // 
            this.colUrunIsletmeTelefon.AppearanceCell.Options.UseTextOptions = true;
            this.colUrunIsletmeTelefon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUrunIsletmeTelefon.Caption = "Telefon";
            this.colUrunIsletmeTelefon.FieldName = "UrunIsletmeTelefon";
            this.colUrunIsletmeTelefon.ImageOptions.Image = global::Windows.UI.Properties.Resources.mobilephone2_16x16;
            this.colUrunIsletmeTelefon.Name = "colUrunIsletmeTelefon";
            this.colUrunIsletmeTelefon.OptionsColumn.AllowEdit = false;
            this.colUrunIsletmeTelefon.StatusBarAciklama = null;
            this.colUrunIsletmeTelefon.StatusBarKisayol = null;
            this.colUrunIsletmeTelefon.StatusBarKisayolAciklama = null;
            this.colUrunIsletmeTelefon.Visible = true;
            this.colUrunIsletmeTelefon.VisibleIndex = 2;
            this.colUrunIsletmeTelefon.Width = 120;
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
            // colIlAdi
            // 
            this.colIlAdi.AppearanceCell.Options.UseTextOptions = true;
            this.colIlAdi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIlAdi.Caption = "İl Adı";
            this.colIlAdi.FieldName = "IlAdi";
            this.colIlAdi.ImageOptions.Image = global::Windows.UI.Properties.Resources.country_16x16;
            this.colIlAdi.Name = "colIlAdi";
            this.colIlAdi.OptionsColumn.AllowEdit = false;
            this.colIlAdi.StatusBarAciklama = null;
            this.colIlAdi.StatusBarKisayol = null;
            this.colIlAdi.StatusBarKisayolAciklama = null;
            this.colIlAdi.Visible = true;
            this.colIlAdi.VisibleIndex = 4;
            this.colIlAdi.Width = 120;
            // 
            // colIlceAdi
            // 
            this.colIlceAdi.AppearanceCell.Options.UseTextOptions = true;
            this.colIlceAdi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIlceAdi.Caption = "İlçe Adı";
            this.colIlceAdi.FieldName = "IlceAdi";
            this.colIlceAdi.ImageOptions.Image = global::Windows.UI.Properties.Resources.language_16x16;
            this.colIlceAdi.Name = "colIlceAdi";
            this.colIlceAdi.OptionsColumn.AllowEdit = false;
            this.colIlceAdi.StatusBarAciklama = null;
            this.colIlceAdi.StatusBarKisayol = null;
            this.colIlceAdi.StatusBarKisayolAciklama = null;
            this.colIlceAdi.Visible = true;
            this.colIlceAdi.VisibleIndex = 5;
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
            this.colAdres.VisibleIndex = 6;
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
            this.colAciklama.VisibleIndex = 7;
            this.colAciklama.Width = 300;
            // 
            // UrunIsletmeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 520);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.MinimumSize = new System.Drawing.Size(1314, 520);
            this.Name = "UrunIsletmeListForm";
            this.Text = "Ürün İşletme Kartları";
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
        private UseControls.Grid.MyGridColumn colUrunIsletmeTelefon;
        private UseControls.Grid.MyGridColumn colKayitTarihi;
        private UseControls.Grid.MyGridColumn colIlAdi;
        private UseControls.Grid.MyGridColumn colIlceAdi;
        private UseControls.Grid.MyGridColumn colAdres;
        private UseControls.Grid.MyGridColumn colAciklama;
    }
}