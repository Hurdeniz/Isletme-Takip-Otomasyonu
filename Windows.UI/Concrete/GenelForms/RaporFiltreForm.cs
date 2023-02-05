using Businesss.Concrete;
using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using Model.Enums;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Concrete.Forms.RaporlarForms.ReportForms;
using DevExpress.XtraReports.UI;

namespace Windows.UI.Concrete.GenelForms
{
    public partial class RaporFiltreForm : BaseEditForm
    {
    
        private readonly GridControl _filtreGrid;
        private readonly XtraReport _rapor;
        

        public RaporFiltreForm(params object[] prm)
        {
            InitializeComponent();


           
            _filtreGrid = (GridControl)prm[0];
            _rapor = (XtraReport)prm[1];
           

            HideItems = new BarItem[] { btnYeni, btnGeriAl, btnFarkliKaydet, btnUygula,btnBaskiOnizleme,btnKaydet,btnSil,btnYazdir };
            ShowItems = new BarItem[] { btnGoruntule };

            Eventsload();

        }

        protected internal override void Yukle()
        {
            txtFiltreMetni.SourceControl = _filtreGrid;         
        }

        protected override void Goruntule()
        {
           
            _rapor.FilterString = txtFiltreMetni.FilterString;
            RaporGoruntule rpr = new RaporGoruntule(_rapor);
            rpr.Show();
            this.Close();
        }

    }
}