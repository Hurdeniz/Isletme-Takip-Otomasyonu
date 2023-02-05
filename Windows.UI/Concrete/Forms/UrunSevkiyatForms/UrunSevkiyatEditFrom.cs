using Businesss.Concrete;
using Entitiess.Concrete;
using Model.Enums;
using System;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;

namespace Windows.UI.Concrete.Forms.UrunSevkiyatForms
{
    public partial class UrunSevkiyatEditFrom : BaseEditForm
    {
        public UrunSevkiyatEditFrom()
        {
            InitializeComponent();

            txtSaat.EditValue = DateTime.Now.ToLongTimeString();

            DataLayoutControl = myDataLayoutControl;
            Bll = new UrunSevkiyatManager(myDataLayoutControl);
            BaseKartTuru = KartTuru.UrunSevkiyat;
            Eventsload();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new UrunSevkiyat() : ((UrunSevkiyatManager)Bll).Single(FilterFunctions.filter<UrunSevkiyat>(Id));
            NesneyiKontrollereBagla();
            TabloYukle();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((UrunSevkiyatManager)Bll).YeniKodVer();
            txtSaat.EditValue = DateTime.Now.ToShortTimeString();
            txtAciklama.Focus();

        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (UrunSevkiyat)OldEntity;

            txtKod.Text = entity.Kod;
            dateTarih.DateTime = entity.SevkiyatTarih;
            txtSaat.EditValue = entity.Saat;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new UrunSevkiyat
            {
                Id = Id,
                Kod = txtKod.Text,
                SevkiyatTarih = dateTarih.DateTime.Date,
                Saat = txtSaat.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurum();

        }

        protected internal override void ButonEnabledDurum()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledDurum(btnYeni, btnKaydet, btnGeriAl, btnSil, OldEntity, CurrentEntity, urunTablo.TableValueChanged);
        }

        protected override bool EntityInsert()
        {
            if (urunTablo.HataliGiris()) return false;
            return ((UrunSevkiyatManager)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod) && urunTablo.Kaydet();
        }
        protected override bool EntityUpdate()
        {
            if (urunTablo.HataliGiris()) return false;
            return ((UrunSevkiyatManager)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod) && urunTablo.Kaydet();
        }

        protected override void TabloYukle()
        {
            urunTablo.OwnerForm = this;
            urunTablo.Yukle();
        }
    }
}