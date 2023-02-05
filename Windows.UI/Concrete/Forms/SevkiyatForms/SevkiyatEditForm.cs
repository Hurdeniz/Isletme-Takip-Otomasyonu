using Businesss.Concrete;
using Entitiess.Concrete;
using Model.Enums;
using System;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;

namespace Windows.UI.Concrete.Forms.SevkiyatForms
{
    public partial class SevkiyatEditForm : BaseEditForm
    {

        public SevkiyatEditForm()
        {
            InitializeComponent();     

            DataLayoutControl = myDataLayoutControl;
            Bll = new SevkiyatManager(myDataLayoutControl);
            BaseKartTuru = KartTuru.Sevkiyat;
            Eventsload();
        }
        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Sevkiyat() : ((SevkiyatManager)Bll).Single(FilterFunctions.filter<Sevkiyat>(Id));
            NesneyiKontrollereBagla();
            TabloYukle();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((SevkiyatManager)Bll).YeniKodVer();
            txtSaat.EditValue = DateTime.Now.ToShortTimeString();
            txtAciklama.Focus();

        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Sevkiyat)OldEntity;

            txtKod.Text = entity.Kod;
            dateTarih.DateTime = entity.SevkiyatTarih;
            txtSaat.EditValue = entity.Saat;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
         

            CurrentEntity = new Sevkiyat
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
            GeneralFunctions.ButtonEnabledDurum(btnYeni, btnKaydet, btnGeriAl, btnSil, OldEntity, CurrentEntity, isletmeTablo.TableValueChanged);
        }

        protected override bool EntityInsert()
        {
            if (isletmeTablo.HataliGiris()) return false;
            return ((SevkiyatManager)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod) && isletmeTablo.Kaydet();
        }
        protected override bool EntityUpdate()
        {
            if (isletmeTablo.HataliGiris()) return false;
            return ((SevkiyatManager)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod) && isletmeTablo.Kaydet();
        }

        protected override void TabloYukle()
        {
            isletmeTablo.OwnerForm = this;
            isletmeTablo.Yukle();
        }

   
    }
}