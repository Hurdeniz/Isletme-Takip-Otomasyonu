
namespace Windows.UI.Concrete.UseControls.UrunSevkiyatTable
{
    partial class UrunSevkiyatHareketTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunSevkiyatHareketTable));
            this.grid = new Windows.UI.Concrete.UseControls.Grid.MyGridControl();
            this.tablo = new Windows.UI.Concrete.UseControls.Grid.MyGridView();
            this.colUrunNo = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colUrunAdi = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colSoforId = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colSoforAdiSoyadi = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.repositorySofor = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colAracId = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colAracPlaka = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.repositoryArac = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colAciklama = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorySofor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryArac)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositorySofor,
            this.repositoryArac});
            this.grid.Size = new System.Drawing.Size(872, 459);
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
            this.colUrunNo,
            this.colUrunAdi,
            this.colSoforId,
            this.colSoforAdiSoyadi,
            this.colAracId,
            this.colAracPlaka,
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
            this.tablo.ViewCaption = "Ürün Kartları";
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
            this.colUrunAdi.AppearanceCell.Options.UseTextOptions = true;
            this.colUrunAdi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUrunAdi.Caption = "Ürün Adı";
            this.colUrunAdi.FieldName = "UrunAdi";
            this.colUrunAdi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colUrunAdi.ImageOptions.Image")));
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.OptionsColumn.AllowEdit = false;
            this.colUrunAdi.StatusBarAciklama = null;
            this.colUrunAdi.StatusBarKisayol = null;
            this.colUrunAdi.StatusBarKisayolAciklama = null;
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 1;
            this.colUrunAdi.Width = 150;
            // 
            // colSoforId
            // 
            this.colSoforId.Caption = "SoforId";
            this.colSoforId.FieldName = "SoforId";
            this.colSoforId.Name = "colSoforId";
            this.colSoforId.OptionsColumn.AllowEdit = false;
            this.colSoforId.OptionsColumn.ShowInCustomizationForm = false;
            this.colSoforId.StatusBarAciklama = null;
            this.colSoforId.StatusBarKisayol = null;
            this.colSoforId.StatusBarKisayolAciklama = null;
            // 
            // colSoforAdiSoyadi
            // 
            this.colSoforAdiSoyadi.AppearanceCell.Options.UseTextOptions = true;
            this.colSoforAdiSoyadi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoforAdiSoyadi.Caption = "Şoför Adı Soyadı";
            this.colSoforAdiSoyadi.ColumnEdit = this.repositorySofor;
            this.colSoforAdiSoyadi.FieldName = "SoforAdiSoyadi";
            this.colSoforAdiSoyadi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colSoforAdiSoyadi.ImageOptions.Image")));
            this.colSoforAdiSoyadi.Name = "colSoforAdiSoyadi";
            this.colSoforAdiSoyadi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSoforAdiSoyadi.StatusBarAciklama = "Şoför Seçiniz.";
            this.colSoforAdiSoyadi.StatusBarKisayol = "F4 :";
            this.colSoforAdiSoyadi.StatusBarKisayolAciklama = "Şoför Seç.";
            this.colSoforAdiSoyadi.Visible = true;
            this.colSoforAdiSoyadi.VisibleIndex = 2;
            this.colSoforAdiSoyadi.Width = 150;
            // 
            // repositorySofor
            // 
            this.repositorySofor.AutoHeight = false;
            this.repositorySofor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositorySofor.Name = "repositorySofor";
            // 
            // colAracId
            // 
            this.colAracId.Caption = "AracId";
            this.colAracId.FieldName = "AracId";
            this.colAracId.Name = "colAracId";
            this.colAracId.OptionsColumn.AllowEdit = false;
            this.colAracId.OptionsColumn.ShowInCustomizationForm = false;
            this.colAracId.StatusBarAciklama = null;
            this.colAracId.StatusBarKisayol = null;
            this.colAracId.StatusBarKisayolAciklama = null;
            // 
            // colAracPlaka
            // 
            this.colAracPlaka.AppearanceCell.Options.UseTextOptions = true;
            this.colAracPlaka.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAracPlaka.Caption = "Araç Plaka";
            this.colAracPlaka.ColumnEdit = this.repositoryArac;
            this.colAracPlaka.FieldName = "AracPlaka";
            this.colAracPlaka.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colAracPlaka.ImageOptions.Image")));
            this.colAracPlaka.Name = "colAracPlaka";
            this.colAracPlaka.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAracPlaka.StatusBarAciklama = "Araç Plakası Seçiniz.";
            this.colAracPlaka.StatusBarKisayol = "F4 :";
            this.colAracPlaka.StatusBarKisayolAciklama = "Araç Seçiniz.";
            this.colAracPlaka.Visible = true;
            this.colAracPlaka.VisibleIndex = 3;
            this.colAracPlaka.Width = 120;
            // 
            // repositoryArac
            // 
            this.repositoryArac.AutoHeight = false;
            this.repositoryArac.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryArac.Name = "repositoryArac";
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.ImageOptions.Image = global::Windows.UI.Properties.Resources.comment_16x16;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAciklama.StatusBarAciklama = "Açıklama Giriniz.";
            this.colAciklama.StatusBarKisayol = null;
            this.colAciklama.StatusBarKisayolAciklama = null;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 4;
            this.colAciklama.Width = 300;
            // 
            // UrunSevkiyatHareketTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "UrunSevkiyatHareketTable";
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorySofor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryArac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyGridControl grid;
        private Grid.MyGridView tablo;
        private Grid.MyGridColumn colUrunNo;
        private Grid.MyGridColumn colSoforAdiSoyadi;
        private Grid.MyGridColumn colAracPlaka;
        private Grid.MyGridColumn colAciklama;
        private Grid.MyGridColumn colUrunAdi;
        private Grid.MyGridColumn colSoforId;
        private Grid.MyGridColumn colAracId;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositorySofor;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryArac;
    }
}
