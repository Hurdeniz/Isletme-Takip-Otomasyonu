using Businesss.Concrete;
using Entities.Concrete;
using Model.Enums;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;

namespace Windows.UI.Concrete.Forms.PompaForms
{
    public partial class PompaEditForm : BaseEditForm
    {
        public PompaEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new PompaManager(myDataLayoutControl);
            BaseKartTuru = KartTuru.Pompa;
            Eventsload();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Pompa() : ((PompaManager)Bll).Single(FilterFunctions.filter<Pompa>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((PompaManager)Bll).YeniKodVer();
            txtPompaAdi.Focus();

        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Pompa)OldEntity;

            txtKod.Text = entity.Kod;
            txtPompaAdi.Text = entity.PompaAdi;
            txtPompaCesiti.Text = entity.PompaCesiti;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
            
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Pompa
            {
                Id = Id,
                Kod = txtKod.Text,
                PompaAdi = txtPompaAdi.Text,
                PompaCesiti = txtPompaCesiti.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurum();
        }
    }
}