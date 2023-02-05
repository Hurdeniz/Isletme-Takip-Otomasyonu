using Businesss.Concrete;
using Entitiess.Concrete;
using Model.Enums;
using Model.Show;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;

namespace Windows.UI.Concrete.Forms.IsletmeSahibiForms
{
    public partial class IsletmeSahibiListForm : BaseListForm
    {
        public IsletmeSahibiListForm()
        {
            InitializeComponent();

            Bll = new IsletmeSahibiManager();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.IsletmeSahibi;
            FormShow = new ShowEditForm<IsletmeSahibiEditForm>();
            Navigator = longNavigator.controlNavigator1;

        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IsletmeSahibiManager)Bll).list(FilterFunctions.filter<IsletmeSahibi>(AktifKartlariGoster));
        }
    }
}