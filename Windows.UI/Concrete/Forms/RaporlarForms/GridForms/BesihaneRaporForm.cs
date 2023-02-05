using Businesss.Concrete;
using DevExpress.XtraReports.UI;
using Entities.Concrete;
using Model.Enums;
using Model.Show;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;
using Windows.UI.Concrete.Forms.RaporlarForms.ReportForms;
using Windows.UI.Concrete.GenelForms;

namespace Windows.UI.Concrete.Forms.RaporlarForms.GridForms
{
    public partial class BesihaneRaporForm : BaseRaporForm
    {
        XtraReport rapor = new XtraReport();

        public BesihaneRaporForm()
        {
            InitializeComponent();

         //   Bll = new DepoManager();

            Yukle();
            tablo.ExpandAllGroups();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.BesihaneRapor;
            Navigator = longNavigator1.controlNavigator1;

        }

        protected override void Listele()
        {
         //   Tablo.GridControl.DataSource = ((DepoManager)Bll).list(FilterFunctions.filter<Depo>(AktifKartlariGoster));
        }

        protected override void Yazdir()
        {
            rapor = new BesihaneReportForm(AktifKartlariGoster);
            ShowEditForm<RaporFiltreForm>.ShowDialogEditForm(Tablo.GridControl, rapor);
        }
    }
}