using Business.Abstract.Interfaces;
using Businesss.Concrete;
using DevExpress.DataAccess.ObjectBinding;


namespace Windows.UI.Concrete.Forms.RaporlarForms.ReportForms
{
    public partial class UrunSevkiyatReportForm : DevExpress.XtraReports.UI.XtraReport
    {

        protected IBaseBll Bll;
        protected bool AktifKartlariGoster;

        public UrunSevkiyatReportForm(params object[] prm)
        {
            InitializeComponent();

            AktifKartlariGoster = (bool)prm[0];

            Bll = new UrunSevkiyatHareketManager();

            ObjectDataSource data = new ObjectDataSource { DataSource = (((UrunSevkiyatHareketManager)Bll).List(x => x.UrunSevkiyat.Durum == AktifKartlariGoster)) };
            this.DataSource = data;

            if (AktifKartlariGoster == false)
                lblbaslik.Text = "ÜRÜN SEVKİYAT KARTLARI (PASİF)";
            else
                lblbaslik.Text = "ÜRÜN SEVKİYAT KARTLARI";
        }

    }
}
