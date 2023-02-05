using Businesss.Concrete;
using Entitiess.Concrete;
using Model.Enums;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;

namespace Windows.UI.Concrete.Forms.AracForms
{
    public partial class AracEditForm : BaseEditForm
    {
        public AracEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new AracManager(myDataLayoutControl);
            BaseKartTuru = KartTuru.Arac;
            Eventsload();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Arac() : ((AracManager)Bll).Single(FilterFunctions.filter<Arac>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((AracManager)Bll).YeniKodVer();
            txtAracPlaka.Focus();

        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Arac)OldEntity;

            txtKod.Text = entity.Kod;
            txtAracPlaka.Text = entity.AracPlaka;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Arac
            {
                Id = Id,
                Kod = txtKod.Text,
                AracPlaka = txtAracPlaka.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn

            };

            ButonEnabledDurum();
        }
    }
}