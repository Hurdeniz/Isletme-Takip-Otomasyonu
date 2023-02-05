using Business.Concrete;
using DevExpress.XtraReports.UI;
using Entities.Concrete;
using Model.Enums;
using Model.Show;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;
using Windows.UI.Concrete.Forms.RaporlarForms.ReportForms;
using Windows.UI.Concrete.GenelForms;

namespace Windows.UI.Concrete.Forms.RaporlarForms
{
    public partial class IsletmeRaporForm : BaseRaporForm
    {
        XtraReport rapor = new XtraReport();

        public IsletmeRaporForm()
        {
            InitializeComponent();

            Bll = new IsletmeManager();

            Yukle();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.IsletmeRapor;
            Navigator = longNavigator.controlNavigator1;

        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IsletmeManager)Bll).list(FilterFunctions.filter<Isletme>(AktifKartlariGoster));
        }

        protected override void Yazdir()
        {

            
            rapor = new IsletmeReportForm(AktifKartlariGoster);
            ShowEditForm<RaporFiltreForm>.ShowDialogEditForm(Tablo.GridControl,rapor);
        }

    }
}