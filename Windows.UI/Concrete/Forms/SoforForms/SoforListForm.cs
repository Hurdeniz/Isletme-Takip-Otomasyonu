using Businesss.Concrete;
using Entitiess.Concrete;
using Model.Enums;
using Model.Show;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;

namespace Windows.UI.Concrete.Forms.SoforForms
{
    public partial class SoforListForm : BaseListForm
    {
        public SoforListForm()
        {
            InitializeComponent();

            Bll = new SoforManager();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Sofor;
            FormShow = new ShowEditForm<SoforEditForm>();
            Navigator = longNavigator.controlNavigator1;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((SoforManager)Bll).list(FilterFunctions.filter<Sofor>(AktifKartlariGoster));
        }
    }
}