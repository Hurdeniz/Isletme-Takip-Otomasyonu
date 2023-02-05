using Businesss.Concrete;
using DevExpress.XtraEditors;
using Entitiess.Concrete;
using Entitiess.Dto;
using Model.Enums;
using System;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;

namespace Windows.UI.Concrete.Forms.UrunKmTonajForms
{
    public partial class UrunKmTonajEditForm : BaseEditForm
    {
        private readonly long _urunSevkiyatId;
        private readonly string _urunSevkiyatNo;
        private readonly DateTime _sevkiyatTarih;
        private readonly long _urunId;
        private readonly string _urunNo;
        private readonly string _urunAdi;

        public UrunKmTonajEditForm(params object[] prm)
        {
            InitializeComponent();

            _urunSevkiyatId = (long)prm[0];
            _urunSevkiyatNo = prm[1].ToString();
            _sevkiyatTarih = (DateTime)prm[2];
            _urunId = (long)prm[3];
            _urunNo = prm[4].ToString();
            _urunAdi = prm[5].ToString();

            DataLayoutControl = myDataLayoutControl;
            Bll = new KmTonajManager(myDataLayoutControl);
            BaseKartTuru = KartTuru.UrunKmTonaj;
            Eventsload();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new KmTonajS() : ((KmTonajManager)Bll).Single(FilterFunctions.filter<KmTonaj>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtGirisSaati.EditValue = DateTime.Now.ToShortTimeString();
            txtCikisSaati.EditValue = DateTime.Now.ToShortTimeString();
            txtFisNo.Focus();

        }

        protected override void NesneyiKontrollereBagla()
        {

            var entity = (KmTonajS)OldEntity;
            txtFisNo.Text = entity.Kod;
            btnEditGeldigiYer.Id = entity.UrunIsletmeId;
            btnEditGeldigiYer.Text = entity.UrunIsletmeAdi;
            dateTarih.DateTime = entity.KmTonajTarih;
            txtGirisSaati.EditValue = entity.GirisSaat;
            txtCikisSaati.EditValue = entity.CikisSaat;
            txtPhDegeri.Value = entity.PhDegeri;
            txtNem.Value = entity.Nem;
            txtKmOrani.Value = entity.KmOrani;
            txtTonajMiktari.Text = Convert.ToString(entity.TonajMiktari);
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;

        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new KmTonaj
            {
                Id = Id,
                KayitTipi=false,//URUN
                Kod = txtFisNo.Text,
                UrunSevkiyatHareketId = _urunSevkiyatId,
                UrunSevkiyatNo=_urunSevkiyatNo,
                UrunSevkiyatTarihi=_sevkiyatTarih,
                UrunId = _urunId,
                UrunNo=_urunNo,
                UrunAdi=_urunAdi,
                UrunIsletmeId = Convert.ToInt64(btnEditGeldigiYer.Id),
                KmTonajTarih = dateTarih.DateTime.Date,
                GirisSaat = txtGirisSaati.Text,
                CikisSaat = txtCikisSaati.Text,
                PhDegeri = txtPhDegeri.Value,
                Nem = txtNem.Value,
                KmOrani = txtKmOrani.Value,
                TonajMiktari = Convert.ToInt32(txtTonajMiktari.Text),
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,

            };

            ButonEnabledDurum();

        }

        protected override bool EntityInsert()
        {
            return ((KmTonajManager)Bll).Insert(CurrentEntity, x => x.Id == CurrentEntity.Id && x.UrunSevkiyatHareketId == _urunSevkiyatId && x.UrunId == _urunId);

        }
        protected override bool EntityUpdate()
        {
            return ((KmTonajManager)Bll).Update(OldEntity, CurrentEntity, x => x.Id == CurrentEntity.Id && x.UrunSevkiyatHareketId == _urunSevkiyatId && x.UrunId == _urunId);
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == btnEditGeldigiYer)
                    sec.Sec(btnEditGeldigiYer);
            }
        }

        private void txtTonajMiktari_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //Texte Sayı Dışında Giriş Yok
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}