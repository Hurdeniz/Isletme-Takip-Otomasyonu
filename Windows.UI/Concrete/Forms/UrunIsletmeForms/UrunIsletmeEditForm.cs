using Businesss.Concrete;
using DevExpress.XtraEditors;
using Entitiess.Concrete;
using Entitiess.Dto;
using Model.Enums;
using System;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;

namespace Windows.UI.Concrete.Forms.UrunIsletmeForms
{
    public partial class UrunIsletmeEditForm : BaseEditForm
    {
        public UrunIsletmeEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new UrunIsletmeManager(myDataLayoutControl);
            BaseKartTuru = KartTuru.UrunIsletme;
            Eventsload();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new UrunIsletmeS() : ((UrunIsletmeManager)Bll).Single(FilterFunctions.filter<UrunIsletme>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((UrunIsletmeManager)Bll).YeniKodVer();
            txtUrunIsletmeAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (UrunIsletmeS)OldEntity;

            txtKod.Text = entity.Kod;
            txtUrunIsletmeAdi.Text = entity.UrunIsletmeAdi;
            txtUrunIsletmeTelefon.Text = entity.UrunIsletmeTelefon;
            dateTarih.DateTime = entity.KayitTarihi;
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
            CurrentEntity = new UrunIsletme
            {
                Id = Id,
                Kod = txtKod.Text,
                UrunIsletmeAdi = txtUrunIsletmeAdi.Text,
                UrunIsletmeTelefon = txtUrunIsletmeTelefon.Text,
                KayitTarihi = dateTarih.DateTime.Date,
                IlId = Convert.ToInt64(btnEditIl.Id),
                IlceId = Convert.ToInt64(btnEditIlce.Id),
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
                if (sender == btnEditIl)
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