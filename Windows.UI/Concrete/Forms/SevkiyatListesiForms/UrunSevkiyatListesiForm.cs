using Businesss.Concrete;
using DevExpress.XtraBars;
using Entitiess.Dto;
using Model.Enums;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;
using Windows.UI.Abstract.Show;
using Windows.UI.Concrete.Forms.UrunKmTonajForms;

namespace Windows.UI.Concrete.Forms.SevkiyatListesiForms
{
    public partial class UrunSevkiyatListesiForm : BaseRaporForm
    {
        public UrunSevkiyatListesiForm()
        {
            InitializeComponent();

            Bll = new UrunSevkiyatHareketManager();
            Yukle();
            tablo.ExpandAllGroups();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.UrunSevkiyatListesi;
            Navigator = longNavigator.controlNavigator1;

            ShowItems = new BarItem[] { btnSevkiyatDegerleri };

        }

        protected override void Listele()
        {
            tablo.ExpandAllGroups();
            tablo.GridControl.DataSource = ((UrunSevkiyatHareketManager)Bll).List(x => x.UrunSevkiyat.Durum == AktifKartlariGoster).ToBindingList<UrunSevkiyatHareketL>();
        }

        protected override void SevkiyatDegerleri()
        {
            var entity = tablo.GetRow<UrunSevkiyatHareketL>();
            if (entity == null) return;
            ShowListForm<UrunKmTonajListForm>.ShowListForms(KartTuru.UrunKmTonaj, entity.UrunSevkiyatId, entity.UrunSevkiyatNo,entity.UrunSevkiyatTarih, entity.UrunId,entity.UrunNo, entity.UrunAdi);
        }
    }
}