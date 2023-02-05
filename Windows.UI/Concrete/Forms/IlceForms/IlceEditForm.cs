using Businesss.Concrete;
using Entities.Concrete;
using Model.Enums;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;

namespace Windows.UI.Concrete.Forms.IlceForms
{
    public partial class IlceEditForm : BaseEditForm
    {
        private readonly long _ilId;
        private readonly string _ilAdi;

        public IlceEditForm(params object[] prm)
        {
            InitializeComponent();

            _ilId = (long)prm[0];
            _ilAdi = prm[1].ToString();

            DataLayoutControl = myDataLayoutControl;
            Bll = new IlceManager(myDataLayoutControl);
            BaseKartTuru = KartTuru.Ilce;
            Eventsload();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Ilce() : ((IlceManager)Bll).Single(FilterFunctions.filter<Ilce>(Id));
            NesneyiKontrollereBagla();
            Text = Text + $" - ({_ilAdi})";

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IlceManager)Bll).YeniKodVer(x => x.IlId == _ilId); // il ıd ye bağlı olan ilçeleri +1 yap
            txtIlceAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Ilce)OldEntity;

            txtKod.Text = entity.Kod;
            txtIlceAdi.Text = entity.IlceAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Ilce
            {
                Id = Id,
                Kod = txtKod.Text,
                IlceAdi = txtIlceAdi.Text,
                IlId = _ilId,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurum();
        }
        protected override bool EntityInsert()
        {
            return ((IlceManager)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.IlId == _ilId);
        }
        protected override bool EntityUpdate()
        {
            return ((IlceManager)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.IlId == _ilId);
        }
    }
}