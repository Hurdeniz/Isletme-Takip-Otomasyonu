using Business.Abstract.Interfaces;
using Businesss.Concrete;
using DevExpress.DataAccess.ObjectBinding;

namespace Windows.UI.Concrete.Forms.RaporlarForms.ReportForms
{
    public partial class UrunSevkiyatDegerleriReportForm : DevExpress.XtraReports.UI.XtraReport
    {
        protected IBaseBll Bll;
        protected bool AktifKartlariGoster;

        public UrunSevkiyatDegerleriReportForm(params object[] prm)
        {
            InitializeComponent();

            AktifKartlariGoster = (bool)prm[0];

            Bll = new KmTonajManager();

            ObjectDataSource data = new ObjectDataSource { DataSource = ((KmTonajManager)Bll).list(x => x.Durum == AktifKartlariGoster && x.KayitTipi == false) };
            this.DataSource = data;

            if (AktifKartlariGoster == false)
                xrLabel1.Text = "ÜRÜN SEVKİYAT DEĞERLERİ (PASİF)";
            else
                xrLabel1.Text = "ÜRÜN SEVKİYAT DEĞERLERİ";
        }

    }
}
