using Businesss.Concrete;
using DevExpress.XtraBars;
using Entitiess.Dto;
using Model.Enums;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;
using Windows.UI.Abstract.Show;
using Windows.UI.Concrete.Forms.IsletmeKmTonajForms;

namespace Windows.UI.Concrete.Forms.SevkiyatListesiForms
{
    public partial class IsletmeSevkiyatListesiForm : BaseRaporForm
    {
        public IsletmeSevkiyatListesiForm()
        {
            InitializeComponent();

            Bll = new IsletmeSevkiyatManager();
            Yukle();
            tablo.ExpandAllGroups();

        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.IsletmeSevkiyatRapor;
            Navigator = longNavigator.controlNavigator1;

            ShowItems = new BarItem[] { btnSevkiyatDegerleri };

        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((IsletmeSevkiyatManager)Bll).List(x => x.Sevkiyat.Durum == AktifKartlariGoster).ToBindingList<IsletmeSevkiyatL>();
        }

        protected override void SevkiyatDegerleri()
        {
            var entity = tablo.GetRow<IsletmeSevkiyatL>();
            if (entity == null) return;
           ShowListForm<IsletmeKmTonajListForm>.ShowListForms(KartTuru.IsletmeKmTonaj, entity.SevkiyatId,entity.SevkiyatNo,entity.SevkiyatTarih, entity.IsletmeId,entity.IsletmeNo, entity.IsletmeAdi);
        }
    }
}