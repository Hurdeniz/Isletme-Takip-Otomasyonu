using Businesss.Concrete;
using Entitiess.Concrete;
using Model.Enums;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;

namespace Windows.UI.Concrete.Forms.IsletmeKullanici
{
    public partial class IsletmeKullaniciEditForm : BaseEditForm
    {
        public IsletmeKullaniciEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new KullaniciKisiManager(myDataLayoutControl);
            BaseKartTuru = KartTuru.KullaniciKisi;
            Eventsload();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new IsletmeKullaniciKisi() : ((KullaniciKisiManager)Bll).Single(FilterFunctions.filter<IsletmeKullaniciKisi>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((KullaniciKisiManager)Bll).YeniKodVer();
            txtKullaniciAdiSoyadi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (IsletmeKullaniciKisi)OldEntity;

            txtKod.Text = entity.Kod;
            txtKullaniciAdiSoyadi.Text = entity.KullaniciKisiAdiSoyadi;
            txtTelefon.Text = entity.KullaniciKisiTelefon;
            dateBaslamaTarihi.DateTime = entity.BaslamaTarihi;
            dateBitisTarihi.DateTime = entity.BitisTarihi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;

        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new IsletmeKullaniciKisi
            {
                Id = Id,
                Kod = txtKod.Text,
                KullaniciKisiAdiSoyadi = txtKullaniciAdiSoyadi.Text,
                KullaniciKisiTelefon = txtTelefon.Text,
                BaslamaTarihi = dateBaslamaTarihi.DateTime.Date,
                BitisTarihi=dateBitisTarihi.DateTime.Date,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurum();
        }

    }
}