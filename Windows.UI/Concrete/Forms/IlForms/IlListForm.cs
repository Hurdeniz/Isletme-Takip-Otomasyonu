using Businesss.Concrete;
using DevExpress.XtraBars;
using Entities.Concrete;
using Model.Enums;
using Model.Show;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;
using Windows.UI.Abstract.Show;
using Windows.UI.Concrete.Forms.IlceForms;

namespace Windows.UI.Concrete.Forms.IlForms
{
    public partial class IlListForm :BaseListForm
    {
        public IlListForm()
        {
            InitializeComponent();

            Bll = new IlManager();
            btnBagliKartlar.Caption = "İlçe Kartları";
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Il;
            FormShow = new ShowEditForm<IlEditForm>();
            Navigator = longNavigator.controlNavigator1;

            if (IsMdiChild)
                ShowItems = new BarItem[] { btnBagliKartlar };
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IlManager)Bll).list(FilterFunctions.filter<Il>(AktifKartlariGoster));
        }
        protected override void BagliKartAc()
        {
            var entity = tablo.GetRow<Il>();
            if (entity == null) return;
            ShowListForm<IlceListForm>.ShowListForms(KartTuru.Ilce, entity.Id, entity.IlAdi);
        }
    }
}