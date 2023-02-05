
namespace Windows.UI.Concrete.UseControls.IsletmeSevkiyatTable
{
    partial class IsletmeSevkiyatTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IsletmeSevkiyatTable));
            this.grid = new Windows.UI.Concrete.UseControls.Grid.MyGridControl();
            this.tablo = new Windows.UI.Concrete.UseControls.Grid.MyGridView();
            this.colIsletmeNo = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colIsletmeAdi = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colJsb = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.repositoryCombo = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colArs = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.repositorySpin = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colAracTipi = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.repositoryAracTipi = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colSoforId = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colSoforAdiSoyadi = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.repositorySofor = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colAracId = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.colAracPlaka = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            this.repositoryArac = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repsitoryDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colAciklama = new Windows.UI.Concrete.UseControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorySpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryAracTipi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorySofor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryArac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repsitoryDecimal)).BeginInit();
            this.SuspendLayout();
            // 
            // insUpNavigator
            // 
            this.insUpNavigator.Location = new System.Drawing.Point(0, 390);
            this.insUpNavigator.Size = new System.Drawing.Size(1705, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repsitoryDecimal,
            this.repositorySpin,
            this.repositoryCombo,
            this.repositorySofor,
            this.repositoryArac,
            this.repositoryAracTipi});
            this.grid.Size = new System.Drawing.Size(1705, 390);
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
            this.colIsletmeNo,
            this.colIsletmeAdi,
            this.colJsb,
            this.colArs,
            this.colAracTipi,
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
            this.tablo.OptionsView.ShowFooter = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = "Oluşturulacak Sevkiyat İçin İşletme Kartları Seçiniz.";
            this.tablo.StatusBarKisayol = "Shift + Insert :";
            this.tablo.StatusBarKisayolAciklama = "İşletme Kartı Ekle.";
            this.tablo.ViewCaption = "İşletme Kartları";
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
            this.colIsletmeNo.Width = 150;
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
            this.colIsletmeAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsletmeAdi.StatusBarAciklama = null;
            this.colIsletmeAdi.StatusBarKisayol = null;
            this.colIsletmeAdi.StatusBarKisayolAciklama = null;
            this.colIsletmeAdi.Visible = true;
            this.colIsletmeAdi.VisibleIndex = 1;
            this.colIsletmeAdi.Width = 175;
            // 
            // colJsb
            // 
            this.colJsb.AppearanceCell.Options.UseTextOptions = true;
            this.colJsb.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colJsb.Caption = "Jsb";
            this.colJsb.ColumnEdit = this.repositoryCombo;
            this.colJsb.FieldName = "Jsb";
            this.colJsb.ImageOptions.Image = global::Windows.UI.Properties.Resources.apply_16x16;
            this.colJsb.Name = "colJsb";
            this.colJsb.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colJsb.StatusBarAciklama = "Jsb Durumu Giriniz.";
            this.colJsb.StatusBarKisayol = null;
            this.colJsb.StatusBarKisayolAciklama = null;
            this.colJsb.Visible = true;
            this.colJsb.VisibleIndex = 2;
            this.colJsb.Width = 100;
            // 
            // repositoryCombo
            // 
            this.repositoryCombo.AutoHeight = false;
            this.repositoryCombo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryCombo.Items.AddRange(new object[] {
            "Hazır",
            "Karışacak"});
            this.repositoryCombo.Name = "repositoryCombo";
            // 
            // colArs
            // 
            this.colArs.AppearanceCell.Options.UseTextOptions = true;
            this.colArs.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colArs.Caption = "Araç Sayısı";
            this.colArs.ColumnEdit = this.repositorySpin;
            this.colArs.FieldName = "AracSayisi";
            this.colArs.ImageOptions.Image = global::Windows.UI.Properties.Resources.driving_16x16;
            this.colArs.Name = "colArs";
            this.colArs.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colArs.StatusBarAciklama = "Araç Sayısı Giriniz.";
            this.colArs.StatusBarKisayol = null;
            this.colArs.StatusBarKisayolAciklama = null;
            this.colArs.Visible = true;
            this.colArs.VisibleIndex = 3;
            this.colArs.Width = 86;
            // 
            // repositorySpin
            // 
            this.repositorySpin.AutoHeight = false;
            this.repositorySpin.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositorySpin.DisplayFormat.FormatString = "n0";
            this.repositorySpin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositorySpin.EditFormat.FormatString = "n0";
            this.repositorySpin.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositorySpin.Mask.EditMask = "n0";
            this.repositorySpin.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.repositorySpin.Name = "repositorySpin";
            // 
            // colAracTipi
            // 
            this.colAracTipi.AppearanceCell.Options.UseTextOptions = true;
            this.colAracTipi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAracTipi.Caption = "Araç Tipi";
            this.colAracTipi.ColumnEdit = this.repositoryAracTipi;
            this.colAracTipi.FieldName = "AracTipi";
            this.colAracTipi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colAracTipi.ImageOptions.Image")));
            this.colAracTipi.Name = "colAracTipi";
            this.colAracTipi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAracTipi.StatusBarAciklama = "Araç Tipi Seçiniz.";
            this.colAracTipi.StatusBarKisayol = null;
            this.colAracTipi.StatusBarKisayolAciklama = null;
            this.colAracTipi.Visible = true;
            this.colAracTipi.VisibleIndex = 4;
            // 
            // repositoryAracTipi
            // 
            this.repositoryAracTipi.AutoHeight = false;
            this.repositoryAracTipi.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryAracTipi.Items.AddRange(new object[] {
            "Tanker",
            "Vidanjör"});
            this.repositoryAracTipi.Name = "repositoryAracTipi";
            // 
            // colSoforId
            // 
            this.colSoforId.Caption = "Soför Id";
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
            this.colSoforAdiSoyadi.StatusBarAciklama = "Şoför Seçiniz.";
            this.colSoforAdiSoyadi.StatusBarKisayol = "F4 :";
            this.colSoforAdiSoyadi.StatusBarKisayolAciklama = "Şoför Seç.";
            this.colSoforAdiSoyadi.Visible = true;
            this.colSoforAdiSoyadi.VisibleIndex = 5;
            this.colSoforAdiSoyadi.Width = 138;
            // 
            // repositorySofor
            // 
            this.repositorySofor.AutoHeight = false;
            this.repositorySofor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositorySofor.Name = "repositorySofor";
            this.repositorySofor.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colAracId
            // 
            this.colAracId.Caption = "Araç Id";
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
            this.colAracPlaka.StatusBarAciklama = "Araç Seçiniz.";
            this.colAracPlaka.StatusBarKisayol = "F4 :";
            this.colAracPlaka.StatusBarKisayolAciklama = "Araç Seç.";
            this.colAracPlaka.Visible = true;
            this.colAracPlaka.VisibleIndex = 6;
            this.colAracPlaka.Width = 120;
            // 
            // repositoryArac
            // 
            this.repositoryArac.AutoHeight = false;
            this.repositoryArac.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryArac.Name = "repositoryArac";
            this.repositoryArac.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repsitoryDecimal
            // 
            this.repsitoryDecimal.AutoHeight = false;
            this.repsitoryDecimal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repsitoryDecimal.DisplayFormat.FormatString = "n2";
            this.repsitoryDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repsitoryDecimal.EditFormat.FormatString = "n2";
            this.repsitoryDecimal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repsitoryDecimal.Mask.EditMask = "n2";
            this.repsitoryDecimal.Name = "repsitoryDecimal";
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
            this.colAciklama.VisibleIndex = 7;
            this.colAciklama.Width = 300;
            // 
            // IsletmeSevkiyatTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "IsletmeSevkiyatTable";
            this.Size = new System.Drawing.Size(1705, 414);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorySpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryAracTipi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorySofor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryArac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repsitoryDecimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyGridControl grid;
        private Grid.MyGridView tablo;
        private Grid.MyGridColumn colIsletmeAdi;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repsitoryDecimal;
        private Grid.MyGridColumn colIsletmeNo;
        private Grid.MyGridColumn colArs;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositorySpin;
        private Grid.MyGridColumn colJsb;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryCombo;
        private Grid.MyGridColumn colAciklama;
        private Grid.MyGridColumn colSoforAdiSoyadi;
        private Grid.MyGridColumn colAracPlaka;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositorySofor;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryArac;
        private Grid.MyGridColumn colSoforId;
        private Grid.MyGridColumn colAracId;
        private Grid.MyGridColumn colAracTipi;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryAracTipi;
    }
}
