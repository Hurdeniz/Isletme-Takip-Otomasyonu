using Business.Abstract.Interfaces;
using Businesss.Concrete;
using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Windows.UI.Concrete.Forms.RaporlarForms.ReportForms
{
    public partial class SevkiyatYazdirReportForm : DevExpress.XtraReports.UI.XtraReport
    {
        protected IBaseBll Bll;
        private readonly long _sevkiyatId;

        public SevkiyatYazdirReportForm(params object[] prm)
        {
            InitializeComponent();

            Bll = new IsletmeSevkiyatManager();

            _sevkiyatId = (long)prm[0];

            ObjectDataSource data = new ObjectDataSource { DataSource = (((IsletmeSevkiyatManager)Bll).List(x => x.SevkiyatId==_sevkiyatId)) };
            this.DataSource = data;
            lblIsletmeNo.DataBindings.Add("Text", this.DataSource, "IsletmeNo");
            lblIsletmeAdi.DataBindings.Add("Text", this.DataSource, "IsletmeAdi");
            lblAracSayisi.DataBindings.Add("Text", this.DataSource, "AracSayisi");
            lblJsb.DataBindings.Add("Text", this.DataSource, "Jsb");
            lblSoforAdi.DataBindings.Add("Text", this.DataSource, "SoforAdiSoyadi");
            lblAracPlaka.DataBindings.Add("Text", this.DataSource, "AracPlaka");
            lblAracTipi.DataBindings.Add("Text", this.DataSource, "AracTipi");
            lblSevkiyatNo.DataBindings.Add("Text", this.DataSource, "SevkiyatNo");
            lblTarih.DataBindings.Add("Text", this.DataSource, "SevkiyatTarih");
            lblAciklama.DataBindings.Add("Text", this.DataSource, "Aciklama");

  
        }

    }
}
