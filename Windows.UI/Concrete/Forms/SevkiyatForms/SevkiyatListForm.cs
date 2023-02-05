using Businesss.Concrete;
using DevExpress.XtraBars;
using Entitiess.Dto;
using Windows.UI.Abstract.Functions;
using Model.Enums;
using Model.Show;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Concrete.GenelForms;
using Windows.UI.Concrete.Forms.RaporlarForms.ReportForms;
using Entitiess.Concrete;

namespace Windows.UI.Concrete.Forms.SevkiyatForms
{
    public partial class SevkiyatListForm : BaseListForm
    {
        public SevkiyatListForm()
        {
            InitializeComponent();

            Bll = new SevkiyatManager();

            ShowItems = new BarItem[] { btnSevkiyatYazdir };

        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Sevkiyat;
            FormShow = new ShowEditForm<SevkiyatEditForm>();
            Navigator = longNavigator.controlNavigator1;
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((SevkiyatManager)Bll).list(x => x.Durum == AktifKartlariGoster );
        }

        protected override void SevkiyatYazdir()
        {
            var entity = tablo.GetRow<Sevkiyat>();
            if (entity == null) return;
            RaporGoruntule rpr = new RaporGoruntule(new SevkiyatYazdirReportForm(entity.Id));
            rpr.Show();
        }
    }
}