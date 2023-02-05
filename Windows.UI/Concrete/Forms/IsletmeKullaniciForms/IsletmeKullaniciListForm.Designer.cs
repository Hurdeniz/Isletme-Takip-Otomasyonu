
namespace Windows.UI.Concrete.Forms.IsletmeKullanici
{
    partial class IsletmeKullaniciListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IsletmeKullaniciListForm));
            this.longNavigator = new Windows.UI.Concrete.UseControls.Navigators.LongNavigator();
            this.grid = new Windows.UI.Concrete.UseControls.Grid.MyGridControl();
            this.tablo = new Windows.UI.Concrete.UseControls.Grid.MyGridView();
            this.colId = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colKod = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colAdiSoyadi = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colKullaniciTelefon = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colBaslamaTarihi = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colBitisTarihi = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
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
            this.ribbonControl.Size = new System.Drawing.Size(1012, 109);
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
            this.longNavigator.Location = new System.Drawing.Point(0, 371);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1012, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 109);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1012, 262);
            this.grid.TabIndex = 3;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            this.grid.Click += new System.EventHandler(this.grid_Click);
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
            this.colAdiSoyadi,
            this.colKullaniciTelefon,
            this.colBaslamaTarihi,
            this.colBitisTarihi,
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
            this.tablo.ViewCaption = "İşletme Kullanıcı Kişi Kartları";
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
            this.colKod.Caption = "Kullanıcı No";
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
            // colAdiSoyadi
            // 
            this.colAdiSoyadi.AppearanceCell.Options.UseTextOptions = true;
            this.colAdiSoyadi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAdiSoyadi.Caption = "Adı Soyadı";
            this.colAdiSoyadi.FieldName = "KullaniciKisiAdiSoyadi";
            this.colAdiSoyadi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colAdiSoyadi.ImageOptions.Image")));
            this.colAdiSoyadi.Name = "colAdiSoyadi";
            this.colAdiSoyadi.OptionsColumn.AllowEdit = false;
            this.colAdiSoyadi.StatusBarAciklama = null;
            this.colAdiSoyadi.StatusBarKisayol = null;
            this.colAdiSoyadi.StatusBarKisayolAciklama = null;
            this.colAdiSoyadi.Visible = true;
            this.colAdiSoyadi.VisibleIndex = 1;
            this.colAdiSoyadi.Width = 150;
            // 
            // colKullaniciTelefon
            // 
            this.colKullaniciTelefon.AppearanceCell.Options.UseTextOptions = true;
            this.colKullaniciTelefon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKullaniciTelefon.Caption = "Telefon";
            this.colKullaniciTelefon.FieldName = "KullaniciKisiTelefon";
            this.colKullaniciTelefon.ImageOptions.Image = global::Windows.UI.Properties.Resources.mobilephone2_16x16;
            this.colKullaniciTelefon.Name = "colKullaniciTelefon";
            this.colKullaniciTelefon.OptionsColumn.AllowEdit = false;
            this.colKullaniciTelefon.StatusBarAciklama = null;
            this.colKullaniciTelefon.StatusBarKisayol = null;
            this.colKullaniciTelefon.StatusBarKisayolAciklama = null;
            this.colKullaniciTelefon.Visible = true;
            this.colKullaniciTelefon.VisibleIndex = 2;
            this.colKullaniciTelefon.Width = 120;
            // 
            // colBaslamaTarihi
            // 
            this.colBaslamaTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colBaslamaTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBaslamaTarihi.Caption = "Başlama Tarihi";
            this.colBaslamaTarihi.FieldName = "BaslamaTarihi";
            this.colBaslamaTarihi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colBaslamaTarihi.ImageOptions.Image")));
            this.colBaslamaTarihi.Name = "colBaslamaTarihi";
            this.colBaslamaTarihi.OptionsColumn.AllowEdit = false;
            this.colBaslamaTarihi.StatusBarAciklama = null;
            this.colBaslamaTarihi.StatusBarKisayol = null;
            this.colBaslamaTarihi.StatusBarKisayolAciklama = null;
            this.colBaslamaTarihi.Visible = true;
            this.colBaslamaTarihi.VisibleIndex = 3;
            this.colBaslamaTarihi.Width = 120;
            // 
            // colBitisTarihi
            // 
            this.colBitisTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colBitisTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBitisTarihi.Caption = "Bitiş Tarihi";
            this.colBitisTarihi.FieldName = "BitisTarihi";
            this.colBitisTarihi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colBitisTarihi.ImageOptions.Image")));
            this.colBitisTarihi.Name = "colBitisTarihi";
            this.colBitisTarihi.OptionsColumn.AllowEdit = false;
            this.colBitisTarihi.StatusBarAciklama = null;
            this.colBitisTarihi.StatusBarKisayol = null;
            this.colBitisTarihi.StatusBarKisayolAciklama = null;
            this.colBitisTarihi.Visible = true;
            this.colBitisTarihi.VisibleIndex = 4;
            this.colBitisTarihi.Width = 120;
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
            this.colAciklama.VisibleIndex = 5;
            this.colAciklama.Width = 300;
            // 
            // IsletmeKullaniciListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 421);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.MinimumSize = new System.Drawing.Size(1010, 420);
            this.Name = "IsletmeKullaniciListForm";
            this.Text = "İşletme Kullanıcı Kişi Kartları";
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
        private UseControls.Grid.MyGridColumn colAdiSoyadi;
        private UseControls.Grid.MyGridColumn colKullaniciTelefon;
        private UseControls.Grid.MyGridColumn colBaslamaTarihi;
        private UseControls.Grid.MyGridColumn colBitisTarihi;
        private UseControls.Grid.MyGridColumn colAciklama;
    }
}