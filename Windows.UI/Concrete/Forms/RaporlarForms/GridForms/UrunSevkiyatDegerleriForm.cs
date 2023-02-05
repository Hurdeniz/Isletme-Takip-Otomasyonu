using Businesss.Concrete;
using DevExpress.XtraReports.UI;
using Model.Enums;
using Model.Show;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Concrete.Forms.RaporlarForms.ReportForms;
using Windows.UI.Concrete.GenelForms;

namespace Windows.UI.Concrete.Forms.RaporlarForms.GridForms
{
    public partial class UrunSevkiyatDegerleriForm : BaseRaporForm
    {
        XtraReport rapor = new XtraReport();

        public UrunSevkiyatDegerleriForm()
        {
            InitializeComponent();

            Bll = new KmTonajManager();
            Yukle();
            tablo.ExpandAllGroups();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.UrunDegerleriRapor;
            Navigator = longNavigator.controlNavigator1;

        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((KmTonajManager)Bll).list(x => x.Durum == AktifKartlariGoster && x.KayitTipi == false);
            tablo.ExpandAllGroups();
        }

        protected override void Yazdir()
        {
            rapor = new UrunSevkiyatDegerleriReportForm(AktifKartlariGoster);
            ShowEditForm<RaporFiltreForm>.ShowDialogEditForm(Tablo.GridControl, rapor);
        }
    }
}