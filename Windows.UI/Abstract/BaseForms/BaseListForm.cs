using Business.Abstract.Interfaces;
using Businesss.Concrete;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Entities.Abstract.Base;
using Model.Enums;
using System;
using System.Collections.Generic;
using DevExpress.XtraPrinting.Native;
using System.Windows.Forms;
using Windows.UI.Abstract.Functions;
using Windows.UI.Abstract.Interfaces;
using DevExpress.Utils.Extensions;
using Windows.UI.Abstract.Show;
using Windows.UI.Concrete.Forms.FiltreForms;
using Entitiess.Concrete;
using Model.Show;

namespace Windows.UI.Abstract.BaseForms
{
    public partial class BaseListForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Variables
        private long _filtreId;
        private bool _formSablonKayitEdilecek;
        private bool _tabloSablonKayitEdilecek;
        protected IBaseFormShow FormShow;
        protected KartTuru BaseKartTuru;
        protected internal GridView Tablo;
        protected bool AktifKartlariGoster = true;
        protected internal bool AktifPasifButonGoster = false;
        protected internal bool MultiSelect;
        protected internal BaseEntity SelectedEntity;
        protected internal IList<BaseEntity> SelectedEntities;
        protected IBaseBll Bll;
        protected ControlNavigator Navigator;
        protected internal long? SeciliGelecekId;
        protected internal IList<long> ListeDisiTutulacakKayitlar;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
        protected internal SelectRowFunctions RowSelect;
        protected internal bool EklenebilecekEntityVar = false;
        #endregion
        public BaseListForm()
        {
            InitializeComponent();
        }
        private void EventsLoad()
        {
            //Button Events
            foreach (BarItem button in ribbonControl.Items)
                button.ItemClick += Button_ItemClick;

            //Table Events
            Tablo.DoubleClick += Tablo_DoubleClick;
            Tablo.KeyDown += Tablo_KeyDown;
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

        private void ButonGizleGoster()
        {
            btnSec.Visibility = AktifPasifButonGoster ? BarItemVisibility.Never : IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            barEnter.Visibility = IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            barSec.Visibility = IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            btnAktifPasifKartlar.Visibility = AktifPasifButonGoster ? BarItemVisibility.Always : !IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;

            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
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

        protected virtual void SelectEntity()
        {
            if (MultiSelect)
            {
                SelectedEntities = new List<BaseEntity>();

                if (RowSelect.SelectedRowCount == 0)
                {
                    Messages.KartSecmemeUyariMesaji();
                    return;
                }

                SelectedEntities = RowSelect.GetSelectedRows();
            }
            else
                SelectedEntity = Tablo.GetRow<BaseEntity>();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void IslemTuruSec()
        {
            if (!IsMdiChild)
            {
                SelectEntity();
            }
            else
                btnDuzelt.PerformClick();
        }

        protected void ShowEditFormDefault(long id)
        {
            if (id <= 0) return;
            AktifKartlariGoster = true;
            FormCaptionAyarlar();
            Tablo.RowFocus("Id", id);
        }

        protected virtual void DegiskenleriDoldur() { }

        protected virtual void ShowEditForm(long id)
        {
            var result = FormShow.ShowDialogEditForm(BaseKartTuru, id);
            ShowEditFormDefault(result);
        }

        protected virtual void EntityDelete()
        {
            var entity = Tablo.GetRow<BaseEntity>();
            if (entity == null) return;
            if (!((IBaseCommonBll)Bll).Delete(entity)) return;

            Tablo.DeleteSelectedRows();
            Tablo.RowFocus(Tablo.FocusedRowHandle);
        }

        protected virtual void Listele() { }

        protected virtual void Yazdir()
        {
            TablePrintingFunctions.Yazdir(Tablo, Tablo.ViewCaption);
        }

        protected virtual void BagliKartAc() { }

        protected virtual void SevkiyatYazdir() { }

        protected internal void Yukle()
        {
            DegiskenleriDoldur();
            EventsLoad();

            Tablo.OptionsSelection.MultiSelect = MultiSelect;
            Navigator.NavigatableControl = Tablo.GridControl;

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
            else if (e.Item == btnYeni)
            {
                //yetki kontrolü
                ShowEditForm(-1);
            }
            else if (e.Item == btnDuzelt)
                ShowEditForm(Tablo.GetRowId());

            else if (e.Item == btnSil)
            {
                //yetki kontrolü
                EntityDelete();
            }

            else if (e.Item == btnSec)
                SelectEntity();

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
            else if (e.Item == btnBagliKartlar)
                BagliKartAc();

            else if (e.Item == btnYazdir)
                Yazdir();
            else if (e.Item == btnSevkiyatYazdir)
                SevkiyatYazdir();

            else if (e.Item == btnCikis)
                Close();

            else if (e.Item == btnAktifPasifKartlar)
            {
                AktifKartlariGoster = !AktifKartlariGoster;
                FormCaptionAyarlar();
            }

            Cursor.Current = DefaultCursor;
        }

        //tablo eventsleri
        private void Tablo_DoubleClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            IslemTuruSec();
            Cursor.Current = DefaultCursor;
        }

        private void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    IslemTuruSec();
                    break;

                case Keys.Escape:
                    Close();
                    break;
            }
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

            if (IsMdiChild || SeciliGelecekId == null) return;
            Tablo.RowFocus("Id", SeciliGelecekId);
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

        private void btnDuzelt_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void BaseListForm_Load_1(object sender, EventArgs e)
        {

        }

        private void btnYeni_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}