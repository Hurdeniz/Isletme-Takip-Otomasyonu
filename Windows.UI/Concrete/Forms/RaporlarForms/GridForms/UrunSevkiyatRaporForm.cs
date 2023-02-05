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
    public partial class UrunSevkiyatRaporForm : BaseRaporForm
    {
        XtraReport rapor = new XtraReport();

        public UrunSevkiyatRaporForm()
        {
            InitializeComponent();


            Bll = new UrunSevkiyatHareketManager();
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
            tablo.GridControl.DataSource = ((UrunSevkiyatHareketManager)Bll).List(x => x.UrunSevkiyat.Durum == AktifKartlariGoster).ToBindingList<UrunSevkiyatHareketL>();
        }

        protected override void Yazdir()
        {
            rapor = new UrunSevkiyatReportForm(AktifKartlariGoster);
            ShowEditForm<RaporFiltreForm>.ShowDialogEditForm(Tablo.GridControl, rapor);
        }

    }
}