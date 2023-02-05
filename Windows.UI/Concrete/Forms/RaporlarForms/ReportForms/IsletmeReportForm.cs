using Business.Abstract.Interfaces;
using Business.Concrete;
using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using Entities.Concrete;
using Windows.UI.Abstract.Functions;


namespace Windows.UI.Concrete.Forms.RaporlarForms.ReportForms
{
    public partial class IsletmeReportForm : XtraReport
    {
        protected IBaseBll Bll;
        protected bool AktifKartlariGoster;

        public IsletmeReportForm(params object[] prm)
        {
            InitializeComponent();
            AktifKartlariGoster = (bool)prm[0];

            Bll = new IsletmeManager();

            ObjectDataSource data = new ObjectDataSource { DataSource = ((IsletmeManager)Bll).list(FilterFunctions.filter<Isletme>(AktifKartlariGoster)) };
            this.DataSource = data;
            lblIsletmeNo.DataBindings.Add("Text", this.DataSource, "Kod");
            lblIsletmeAdi.DataBindings.Add("Text", this.DataSource, "IsletmeAdi");
            lblIsletmeSahibi.DataBindings.Add("Text", this.DataSource, "IsletmeSahibiAdi");
            lblTelefon.DataBindings.Add("Text", this.DataSource, "IsletmeSahibiTelefon");
            lblKapasite.DataBindings.Add("Text", this.DataSource, "Kapasite");
            lblHayvanSayisi.DataBindings.Add("Text", this.DataSource, "HayvanSayisi");
            lblPompaAdi.DataBindings.Add("Text", this.DataSource, "PompaAdi");
            lblPompaCesiti.DataBindings.Add("Text", this.DataSource, "PompaCesiti");
            lblIl.DataBindings.Add("Text", this.DataSource, "IlAdi");
            lblIlce.DataBindings.Add("Text", this.DataSource, "IlceAdi");
            lblAdres.DataBindings.Add("Text", this.DataSource, "Adres");
            if (AktifKartlariGoster == false)
                xrLabel1.Text = "İŞLETME KARTLARI (PASİF)";
            else
                xrLabel1.Text = "İŞLETME KARTLARI";



        }

    }
}
