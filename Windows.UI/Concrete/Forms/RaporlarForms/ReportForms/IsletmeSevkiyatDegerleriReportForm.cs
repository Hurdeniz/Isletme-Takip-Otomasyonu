using Business.Abstract.Interfaces;
using Businesss.Concrete;
using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using Entitiess.Concrete;
using Windows.UI.Abstract.Functions;

namespace Windows.UI.Concrete.Forms.RaporlarForms.ReportForms
{
    public partial class IsletmeSevkiyatDegerleriReportForm :XtraReport
    {
        protected IBaseBll Bll;
        protected bool AktifKartlariGoster;

        public IsletmeSevkiyatDegerleriReportForm(params object[] prm)
        {
          
            InitializeComponent();
            AktifKartlariGoster = (bool)prm[0];

            Bll = new KmTonajManager();

            ObjectDataSource data = new ObjectDataSource { DataSource = ((KmTonajManager)Bll).list(x => x.Durum == AktifKartlariGoster && x.KayitTipi == true)};
            this.DataSource = data;

            if (AktifKartlariGoster == false)
                xrLabel1.Text = "İŞLETME SEVKİYAT DEĞERLERİ (PASİF)";
            else
                xrLabel1.Text = "İŞLETME SEVKİYAT DEĞERLERİ";


        }

    }
}
