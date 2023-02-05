using Businesss.Concrete;
using DevExpress.XtraReports.UI;
using Entitiess.Dto;
using Model.Enums;
using Model.Show;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;
using Windows.UI.Concrete.Forms.RaporlarForms.ReportForms;
using Windows.UI.Concrete.GenelForms;

namespace Windows.UI.Concrete.Forms.RaporlarForms.GridForms
{
    public partial class IsletmeSevkiyatRaporForm : BaseRaporForm
    {
        XtraReport rapor = new XtraReport();

        public IsletmeSevkiyatRaporForm()
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

        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((IsletmeSevkiyatManager)Bll).List(x => x.Sevkiyat.Durum==AktifKartlariGoster).ToBindingList<IsletmeSevkiyatL>();
            tablo.ExpandAllGroups();
        }

        protected override void Yazdir()
        {
            rapor = new SevkiyatReportForm(AktifKartlariGoster);
            ShowEditForm<RaporFiltreForm>.ShowDialogEditForm(Tablo.GridControl, rapor);
        }
    }
}