using Businesss.Concrete;
using Entitiess.Concrete;
using Model.Enums;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;

namespace Windows.UI.Concrete.Forms.IsletmeSahibiForms
{
    public partial class IsletmeSahibiEditForm : BaseEditForm
    {
        public IsletmeSahibiEditForm()
        {
            InitializeComponent();


            DataLayoutControl = myDataLayoutControl;
            Bll = new IsletmeSahibiManager(myDataLayoutControl);
            BaseKartTuru = KartTuru.IsletmeSahibi;
            Eventsload();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new IsletmeSahibi() : ((IsletmeSahibiManager)Bll).Single(FilterFunctions.filter<IsletmeSahibi>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IsletmeSahibiManager)Bll).YeniKodVer();
            txtAdiSoyadi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (IsletmeSahibi)OldEntity;

            txtKod.Text = entity.Kod;
            txtAdiSoyadi.Text = entity.AdiSoyadi;
            txtTelefon.Text = entity.Telefon;
            dateKayitTarihi.DateTime = entity.KayitTarihi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;

        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new IsletmeSahibi
            {
                Id = Id,
                Kod = txtKod.Text,
                AdiSoyadi = txtAdiSoyadi.Text,
                Telefon = txtTelefon.Text,
                KayitTarihi = dateKayitTarihi.DateTime.Date,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurum();
        }
    }
}