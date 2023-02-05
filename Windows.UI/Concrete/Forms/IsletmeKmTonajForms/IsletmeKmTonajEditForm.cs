using Businesss.Concrete;
using Entitiess.Concrete;
using Entitiess.Dto;
using Model.Enums;
using System;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;

namespace Windows.UI.Concrete.Forms.IsletmeKmTonajForms
{
    public partial class IsletmeKmTonajEditForm :BaseEditForm
    {
      
        private readonly long _sevkiyatId;
        private readonly string _sevkiyatNo;
        private readonly DateTime _sevkiyatTarih;
        private readonly long _isletmeId;
        private readonly string _isletmeNo;
        private readonly string _isletmeAdi;

        public IsletmeKmTonajEditForm(params object[] prm)
        {
            InitializeComponent();

            _sevkiyatId = (long)prm[0];
            _sevkiyatNo = prm[1].ToString();
            _sevkiyatTarih = (DateTime)prm[2];
            _isletmeId = (long)prm[3];
            _isletmeNo = prm[4].ToString();
            _isletmeAdi = prm[5].ToString();

            DataLayoutControl = myDataLayoutControl;
            Bll = new KmTonajManager(myDataLayoutControl);
            BaseKartTuru = KartTuru.IsletmeKmTonaj;
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
            dateTarih.DateTime = entity.KmTonajTarih;
            txtGirisSaati.EditValue = entity.GirisSaat;
            txtCikisSaati.EditValue = entity.CikisSaat;
            txtPhDegeri.Value = entity.PhDegeri;
            txtNem.Value = entity.Nem;
            txtKmOrani.Value = entity.KmOrani;
            txtTonajMiktari.Text =Convert.ToString(entity.TonajMiktari);  
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;

        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new KmTonaj
            {
                Id = Id,
                KayitTipi=true,// true işletme
                Kod = txtFisNo.Text,
                IsletmeSevkiyatId = _sevkiyatId,
                IsletmeSevkiyatNo=_sevkiyatNo,
                IsletmeSevkiyatTarihi=_sevkiyatTarih,
                IsletmeId = _isletmeId,
                IsletmeNo=_isletmeNo,
                IsletmeAdi=_isletmeAdi,
                KmTonajTarih=dateTarih.DateTime.Date,
                GirisSaat=txtGirisSaati.Text,
                CikisSaat=txtCikisSaati.Text,
                PhDegeri=txtPhDegeri.Value,
                Nem=txtNem.Value,
                KmOrani = txtKmOrani.Value,
                TonajMiktari = Convert.ToInt32(txtTonajMiktari.Text),
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,

            };

            ButonEnabledDurum();

        }

        protected override bool EntityInsert()
        {
            return ((KmTonajManager)Bll).Insert(CurrentEntity, x => x.Id == CurrentEntity.Id && x.IsletmeSevkiyatId==_sevkiyatId &&x.IsletmeId==_isletmeId);

        }
        protected override bool EntityUpdate()
        {
            return ((KmTonajManager)Bll).Update(OldEntity, CurrentEntity, x => x.Id == CurrentEntity.Id && x.IsletmeSevkiyatId == _sevkiyatId && x.IsletmeId == _isletmeId);
        }

        private void txtTonajMiktari_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //Texte Sadece Sayı Girme
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}