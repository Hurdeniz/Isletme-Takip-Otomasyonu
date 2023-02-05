using Business.Abstract.Interfaces;
using Businesss.Concrete;
using DevExpress.DataAccess.ObjectBinding;

namespace Windows.UI.Concrete.Forms.RaporlarForms.ReportForms
{
    public partial class SevkiyatReportForm : DevExpress.XtraReports.UI.XtraReport
    {
        protected IBaseBll Bll;
        protected bool AktifKartlariGoster;

        public SevkiyatReportForm(params object[] prm)
        {
            InitializeComponent();

            AktifKartlariGoster = (bool)prm[0];

            Bll = new IsletmeSevkiyatManager();

            ObjectDataSource data = new ObjectDataSource { DataSource = (((IsletmeSevkiyatManager)Bll).List(x => x.Sevkiyat.Durum==AktifKartlariGoster)) };
            this.DataSource = data;
            lblIsletmeAdi.DataBindings.Add("Text", this.DataSource, "IsletmeAdi");
            lblSevkiyatNo.DataBindings.Add("Text", this.DataSource, "SevkiyatNo");
            lblSevkiyatTarihi.DataBindings.Add("Text", this.DataSource, "SevkiyatTarih");
            lblSevkiyatSaat.DataBindings.Add("Text", this.DataSource, "SevkiyatSaat");
            lblSofor.DataBindings.Add("Text", this.DataSource, "SoforAdiSoyadi");
            lblAracTipi.DataBindings.Add("Text", this.DataSource, "AracTipi");
            lblAracPlaka.DataBindings.Add("Text", this.DataSource, "AracPlaka");
            lblAracSayisi.DataBindings.Add("Text", this.DataSource, "AracSayisi");
            lblAciklama.DataBindings.Add("Text", this.DataSource, "Aciklama");

            if (AktifKartlariGoster == false)
                lblbaslik.Text = "İŞLETME SEVKİYAT KARTLARI (PASİF)";
            else
                lblbaslik.Text = "İŞLETME SEVKİYAT KARTLARI";
        }

    }
}
