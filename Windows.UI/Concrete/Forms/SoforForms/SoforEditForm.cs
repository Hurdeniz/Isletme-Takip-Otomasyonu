using Businesss.Concrete;
using Entitiess.Concrete;
using Model.Enums;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;

namespace Windows.UI.Concrete.Forms.SoforForms
{
    public partial class SoforEditForm : BaseEditForm
    {
        public SoforEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new SoforManager(myDataLayoutControl);
            BaseKartTuru = KartTuru.Sofor;
            Eventsload();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Sofor() : ((SoforManager)Bll).Single(FilterFunctions.filter<Sofor>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((SoforManager)Bll).YeniKodVer();
            txtAdiSoyadi.Focus();

        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Sofor)OldEntity;

            txtKod.Text = entity.Kod;
            txtAdiSoyadi.Text = entity.SoforAdiSoyadi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Sofor
            {
                Id = Id,
                Kod = txtKod.Text,
                SoforAdiSoyadi = txtAdiSoyadi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn

            };

            ButonEnabledDurum();
        }
    }
}