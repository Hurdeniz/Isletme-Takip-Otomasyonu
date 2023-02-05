using Business.Abstract.Interfaces;
using Businesss.Concrete;
using DevExpress.DataAccess.ObjectBinding;
using Entities.Concrete;
using Windows.UI.Abstract.Functions;

namespace Windows.UI.Concrete.Forms.RaporlarForms.ReportForms
{
    public partial class BesihaneReportForm : DevExpress.XtraReports.UI.XtraReport
    {
        protected IBaseBll Bll;
        protected bool AktifKartlariGoster;

        public BesihaneReportForm(params object[] prm)
        {
            InitializeComponent();
            AktifKartlariGoster = (bool)prm[0];

            //Bll = new DepoManager();

            //ObjectDataSource data = new ObjectDataSource { DataSource = ((DepoManager)Bll).list(FilterFunctions.filter<Depo>(AktifKartlariGoster)) };
            //this.DataSource = data;
            //lblBesihaneNo.DataBindings.Add("Text", this.DataSource, "Kod");
            //lblDepoKapasitesi.DataBindings.Add("Text", this.DataSource, "Kapasite");
            //lblHayvanSayisi.DataBindings.Add("Text", this.DataSource, "HayvanSayisi");
            //lblKayitTarihi.DataBindings.Add("Text", this.DataSource, "KayitTarih");
            //lblPompaDurumu.DataBindings.Add("Text", this.DataSource, "PompaAdi");
            //lblPompaCesiti.DataBindings.Add("Text", this.DataSource, "PompaCesiti");
            //lblIl.DataBindings.Add("Text", this.DataSource, "IlAdi");
            //lblIlce.DataBindings.Add("Text", this.DataSource, "IlceAdi");
            //lblAdres.DataBindings.Add("Text", this.DataSource, "Adres");
            //lblIsletmeAdi.DataBindings.Add("Text", this.DataSource, "IsletmeAdi");
            //if (AktifKartlariGoster == false)
            //    xrLabel1.Text = "BESİHANE KARTLARI (PASİF)";
            //else
            //    xrLabel1.Text = "BESİHANE KARTLARI";
        }

    }
}
