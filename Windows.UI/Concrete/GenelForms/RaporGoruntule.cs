using DevExpress.XtraReports.UI;

namespace Windows.UI.Concrete.GenelForms
{
    public partial class RaporGoruntule : DevExpress.XtraEditors.XtraForm
    {
        public RaporGoruntule(XtraReport rapor)
        {
            InitializeComponent();

            documentViewer1.DocumentSource = rapor;
        }
    }
}