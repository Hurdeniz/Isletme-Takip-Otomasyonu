using Businesss.Concrete;
using Entitiess.Concrete;
using Model.Enums;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;

namespace Windows.UI.Concrete.Forms.UrunForms
{
    public partial class UrunEditForm : BaseEditForm
    {
        public UrunEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new UrunManager(myDataLayoutControl);
            BaseKartTuru = KartTuru.Urun;
            Eventsload();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Urun() : ((UrunManager)Bll).Single(FilterFunctions.filter<Urun>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((UrunManager)Bll).YeniKodVer();
            txtUrunAdi.Focus();

        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Urun)OldEntity;

            txtKod.Text = entity.Kod;
            txtUrunAdi.Text = entity.UrunAdi;
            dateTarih.DateTime = entity.UrunKayitTarihi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Urun
            {
                Id = Id,
                Kod = txtKod.Text,
                UrunAdi = txtUrunAdi.Text,
                UrunKayitTarihi = dateTarih.DateTime.Date,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn

            };

            ButonEnabledDurum();
        }
    }
}