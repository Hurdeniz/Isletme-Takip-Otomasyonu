using Business.Abstract.Interfaces;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Entitiess.Concrete;
using Model.Enums;
using Model.Show;
using System;
using System.Windows.Forms;
using Windows.UI.Abstract.Functions;
using Windows.UI.Abstract.Show;
using Windows.UI.Concrete.Forms.FiltreForms;

namespace Windows.UI.Abstract.BaseForms
{
    public partial class BaseRaporForm : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        private long _filtreId;
        private bool _formSablonKayitEdilecek;
        private bool _tabloSablonKayitEdilecek;
        protected KartTuru BaseKartTuru;
        protected internal GridView Tablo;
        protected bool AktifKartlariGoster = true;
        protected internal bool AktifPasifButonGoster = false;
        protected internal bool MultiSelect;
        protected IBaseBll Bll;
        protected ControlNavigator Navigator;
        //protected internal long? SeciliGelecekId;
      //  protected internal IList<long> ListeDisiTutulacakKayitlar;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;

        #endregion

        public BaseRaporForm()
        {
            InitializeComponent();
        }

        private void ButonGizleGoster()
        {
            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
        }

        private void EventsLoad()
        {
            //Button Events
            foreach (BarItem button in ribbonControl.Items)
                button.ItemClick += Button_ItemClick;

            //Table Events         
            Tablo.MouseUp += Tablo_MouseUp;
            Tablo.ColumnWidthChanged += Tablo_ColumnWidthChanged; //tablodaki kolon genişliği oldugunda
            Tablo.ColumnPositionChanged += Tablo_ColumnPositionChanged; //tablodaki kolon yer değiştirmesi durumu
            Tablo.EndSorting += Tablo_EndSorting; //tablo sıralaması 
            Tablo.FilterEditorCreated += Tablo_FilterEditorCreated;
            Tablo.ColumnFilterChanged += Tablo_ColumnFilterChanged;
            Tablo.CustomDrawFooterCell += Tablo_CustomDrawFooterCell; //Gridlerin Footerlarına Müdale Edilebilecek
            //Tablo.


            //    //Form Events
            Shown += BaseListForm_Shown;
            Load += BaseListForm_Load;
            FormClosing += BaseListForm_FormClosing;
            LocationChanged += BaseListForm_LocationChanged;
            SizeChanged += BaseListForm_SizeChanged;
        }

        private void FiltreSec()
        {
            var entity = (Filtre)ShowListForm<FiltreListForm>.ShowDialogListForm(KartTuru.Filtre, _filtreId, BaseKartTuru, Tablo.GridControl);
            if (entity == null) return;

            _filtreId = entity.Id;
            Tablo.ActiveFilterString = entity.FiltreMetni;
        }

        private void FormCaptionAyarlar()
        {
            if (btnAktifPasifKartlar == null)
            {
                Listele();
                return;
            }

            if (AktifKartlariGoster)
            {
                btnAktifPasifKartlar.Caption = "Pasif Kartlar";
                Tablo.ViewCaption = Text;
            }
            else
            {
                btnAktifPasifKartlar.Caption = "Aktif Kartlar";
                Tablo.ViewCaption = Text + " - Pasif Kartlar";
            }
            Listele();
        }

        private void SablonKaydet()
        {
            if (_formSablonKayitEdilecek)
                Name.FormSablonKaydet(Left, Top, Width, Height, WindowState);

            if (_tabloSablonKayitEdilecek)
                Tablo.TabloSablonKaydet(IsMdiChild ? Name + " Tablosu" : Name + " TablosuMDI");
        }

        private void SablonYukle()
        {
            if (IsMdiChild)
                Tablo.TabloSablonYukle(Name + " Tablosu");
            else
            {
                Name.FormSablonYukle(this);
                Tablo.TabloSablonYukle(Name + " TablosuMDI");
            }

        }

        protected virtual void DegiskenleriDoldur() { }

        protected virtual void Listele() { }

        protected virtual void Yazdir() { }

        protected virtual void SevkiyatDegerleri() { }

        protected internal void Yukle()
        {
            DegiskenleriDoldur();
            EventsLoad();

            Tablo.OptionsSelection.MultiSelect = MultiSelect;
            Navigator.NavigatableControl = Tablo.GridControl;
            

            ButonGizleGoster();
            Tablo.ExpandAllGroups();
            Cursor.Current = Cursors.WaitCursor;
            Listele();
            Cursor.Current = DefaultCursor;

        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //cursor bekle durumuna geç

            //gönder buton menüsünün 0.indexine focuslama
            if (e.Item == btnGonder)
            {
                var link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }
            else if (e.Item == btnStandartExcelDosyasi)
                Tablo.TabloDisariAktar(DosyaTuru.ExcelStandart, e.Item.Caption, Text);
            else if (e.Item == btnFormatliExcelDosyasi)
                Tablo.TabloDisariAktar(DosyaTuru.ExcelFormatli, e.Item.Caption, Text);
            else if (e.Item == btnFormatsizExcelDosyasi)
                Tablo.TabloDisariAktar(DosyaTuru.ExcelFormatsiz, e.Item.Caption);
            else if (e.Item == btnWordDosyasi)
                Tablo.TabloDisariAktar(DosyaTuru.WordDosyasi, e.Item.Caption);
            else if (e.Item == btnPdfDosyasi)
                Tablo.TabloDisariAktar(DosyaTuru.PdfDosyasi, e.Item.Caption);
            else if (e.Item == btnTxtDosyasi)
                Tablo.TabloDisariAktar(DosyaTuru.TxtDosyasi, e.Item.Caption);
            else if (e.Item == btnYenile)
                Listele();

            else if (e.Item == btnFiltrele)
                FiltreSec();

            else if (e.Item == btnKolonlar)
            {
                if (Tablo.CustomizationForm == null)
                    Tablo.ShowCustomization();
                else
                    Tablo.HideCustomization();
            }

            else if (e.Item == btnYazdir)
                Yazdir();
            else if (e.Item == btnSevkiyatDegerleri)
                SevkiyatDegerleri();

            else if (e.Item == btnCikis)
                Close();

            else if (e.Item == btnAktifPasifKartlar)
            {
                AktifKartlariGoster = !AktifKartlariGoster;
                FormCaptionAyarlar();
            }
            else if (e.Item == btnGruplamaPanel)
            {
                Tablo.OptionsView.ShowGroupPanel = !Tablo.OptionsView.ShowGroupPanel;
            }
            else if (e.Item == btnTumGruplariGenislet)
            {
                Tablo.ExpandAllGroups();
            }
            else if (e.Item == btnTumGruplariDaralt)
            {
                Tablo.CollapseAllGroups();
            }

            Cursor.Current = DefaultCursor;
        }

        private void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            e.SagMenuGoster(sagMenu);
        }

        private void Tablo_ColumnWidthChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
        }

        private void Tablo_ColumnPositionChanged(object sender, EventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
        }

        private void Tablo_EndSorting(object sender, EventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
        }

        private void Tablo_FilterEditorCreated(object sender, DevExpress.XtraGrid.Views.Base.FilterControlEventArgs e)
        {
            e.ShowFilterEditor = false;
            ShowEditForm<FiltreEditForm>.ShowDialogEditForm(KartTuru.Filtre, _filtreId, BaseKartTuru, Tablo.GridControl);

        }

        private void Tablo_ColumnFilterChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Tablo.ActiveFilterString))
                _filtreId = 0;
        }

        private void Tablo_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            if (!Tablo.OptionsView.ShowFooter) return;
            if (e.Column.Summary.Count > 0)
                e.Appearance.TextOptions.HAlignment = e.Column.ColumnEdit.Appearance.HAlignment;//Kolondaki ayarlarla showfooter ayarlarını eşitler
        }

        private void BaseListForm_Shown(object sender, EventArgs e)
        {
            Tablo.Focus();
            ButonGizleGoster();
        }

        private void BaseListForm_Load(object sender, EventArgs e)
        {
            SablonYukle();
        }

        private void BaseListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();
        }

        private void BaseListForm_LocationChanged(object sender, EventArgs e)
        {
            if (!IsMdiChild)
                _formSablonKayitEdilecek = true;
        }

        private void BaseListForm_SizeChanged(object sender, EventArgs e)
        {
            if (!IsMdiChild)
                _formSablonKayitEdilecek = true;
        }

    }
}