using Business.Concrete;
using DevExpress.XtraEditors;
using Entities.Concrete;
using Entitiess.Dto;
using Model.Enums;
using System;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;

namespace Windows.UI.Concrete.Forms.IsletmeForms
{
    public partial class IsletmeEditForm : BaseEditForm
    {
        public IsletmeEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new IsletmeManager(myDataLayoutControl);
            BaseKartTuru = KartTuru.Isletme;
            Eventsload();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new IsletmeS() : ((IsletmeManager)Bll).Single(FilterFunctions.filter<Isletme>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IsletmeManager)Bll).YeniKodVer();
            txtIsletmeAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (IsletmeS)OldEntity;

            txtKod.Text = entity.Kod;
            txtIsletmeAdi.Text = entity.IsletmeAdi;
            btnEditIsletmeSahibi.Id = entity.IsletmeSahibiId;
            btnEditIsletmeSahibi.Text = entity.IsletmeSahibiAdi;
            btnEditIsletmeKullanici.Id = entity.IsletmeKullaniciKisiId;
            btnEditIsletmeKullanici.Text = entity.IsletmeKullaniciKisiAdiSoyadi;
            txtTarih.DateTime = entity.KayitTarihi;
            btnGrupKod.Id = entity.GrupKodId;
            btnGrupKod.Text = entity.GrupKodAdi;
            txtKapasite.Text = entity.Kapasite;
            txtHayvanSayisi.Text = entity.HayvanSayisi;
            btnEditPompaDurum.Id = entity.PompaId;
            btnEditPompaDurum.Text = entity.PompaAdi;
            btnEditIl.Id = entity.IlId;
            btnEditIl.Text = entity.IlAdi;
            btnEditIlce.Id = entity.IlceId;
            btnEditIlce.Text = entity.IlceAdi;
            txtAdres.Text = entity.Adres;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Isletme
            {
                Id = Id,
                Kod = txtKod.Text,
                IsletmeAdi = txtIsletmeAdi.Text,
                IsletmeSahibiId = Convert.ToInt64(btnEditIsletmeSahibi.Id),
                IsletmeKullaniciKisiId = btnEditIsletmeKullanici.Id,
                KayitTarihi = txtTarih.DateTime.Date,
                GrupKodId = btnGrupKod.Id,
                Kapasite = txtKapasite.Text,
                HayvanSayisi = txtHayvanSayisi.Text,
                IlId = Convert.ToInt64(btnEditIl.Id),
                IlceId = Convert.ToInt64(btnEditIlce.Id),
                PompaId = Convert.ToInt64(btnEditPompaDurum.Id),
                Adres = txtAdres.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurum();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == btnGrupKod)
                    sec.Sec(btnGrupKod, KartTuru.Isletme);
                else if (sender == btnEditIsletmeSahibi)
                    sec.Sec(btnEditIsletmeSahibi);
                else if (sender == btnEditIsletmeKullanici)
                    sec.Sec(btnEditIsletmeKullanici);
                else if (sender == btnEditPompaDurum)
                    sec.Sec(btnEditPompaDurum);
                else if (sender == btnEditIl)
                    sec.Sec(btnEditIl);
                else if (sender == btnEditIlce)
                    sec.Sec(btnEditIlce, btnEditIl);

            }
        }

        protected override void Control_EnableChange(object sender, EventArgs e)
        {
            if (sender != btnEditIl) return;
            {
                btnEditIl.ControlEnabledChange(btnEditIlce);
            }
        }

    }
}