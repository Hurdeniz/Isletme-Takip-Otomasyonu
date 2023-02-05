using Businesss.Concrete;
using DevExpress.XtraReports.UI;
using Model.Enums;
using Model.Show;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Concrete.Forms.RaporlarForms.ReportForms;
using Windows.UI.Concrete.GenelForms;

namespace Windows.UI.Concrete.Forms.RaporlarForms.GridForms
{
    public partial class IsletmeSevkiyatDegerleriForm : BaseRaporForm
    {
        XtraReport rapor = new XtraReport();

        public IsletmeSevkiyatDegerleriForm()
        {
            InitializeComponent();

            Bll = new KmTonajManager();
            Yukle();
            tablo.ExpandAllGroups();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.IsletmeDegerleriRapor;
            Navigator = longNavigator.controlNavigator1;

        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((KmTonajManager)Bll).list(x => x.Durum == AktifKartlariGoster && x.KayitTipi == true);
            tablo.ExpandAllGroups();
        }

        protected override void Yazdir()
        {
            rapor = new IsletmeSevkiyatDegerleriReportForm(AktifKartlariGoster);
            ShowEditForm<RaporFiltreForm>.ShowDialogEditForm(Tablo.GridControl, rapor);
        }
    }
}