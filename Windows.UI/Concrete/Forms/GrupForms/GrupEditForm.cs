using Businesss.Concrete;
using Entitiess.Concrete;
using Model.Enums;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;

namespace Windows.UI.Concrete.Forms.GrupForms
{
    public partial class GrupEditForm : BaseEditForm
    {
        private readonly GrupKodTuru _grupKodTuru;
        private readonly KartTuru _grupKodKartTuru;

        public GrupEditForm(params object[] prm)
        {
            InitializeComponent();

            _grupKodTuru = (GrupKodTuru)prm[0];
            _grupKodKartTuru = (KartTuru)prm[1];

            DataLayoutControl = myDataLayoutControl;
            Bll = new GrupKodManager(myDataLayoutControl);
            BaseKartTuru = KartTuru.Grup;
            Eventsload();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new GrupKod() : ((GrupKodManager)Bll).Single(FilterFunctions.filter<GrupKod>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((GrupKodManager)Bll).YeniKodVer(x => x.KodTuru == _grupKodTuru && x.KartTuru == _grupKodKartTuru);
            txtGrupKodAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (GrupKod)OldEntity;

            txtKod.Text = entity.Kod;
            txtGrupKodAdi.Text = entity.GrupKodAdi;
            txtAciklama.Text = entity.Aciklama;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new GrupKod
            {
                Id = Id,
                Kod = txtKod.Text,
                GrupKodAdi = txtGrupKodAdi.Text,
                KodTuru = _grupKodTuru,
                KartTuru = _grupKodKartTuru,
                Aciklama = txtAciklama.Text,
            };

            ButonEnabledDurum();
        }
        protected override bool EntityInsert()
        {
            return ((GrupKodManager)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.KodTuru == _grupKodTuru && x.KartTuru == _grupKodKartTuru);
        }
        protected override bool EntityUpdate()
        {
            return ((GrupKodManager)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.KodTuru == _grupKodTuru && x.KartTuru == _grupKodKartTuru);
        }
    }
}