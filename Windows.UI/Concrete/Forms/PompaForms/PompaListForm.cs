using Businesss.Concrete;
using Entities.Concrete;
using Model.Enums;
using Model.Show;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;

namespace Windows.UI.Concrete.Forms.PompaForms
{
    public partial class PompaListForm : BaseListForm
    {
        public PompaListForm()
        {
            InitializeComponent();

            Bll = new PompaManager();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Pompa;
            FormShow = new ShowEditForm<PompaEditForm>();
            Navigator = longNavigator.controlNavigator1;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((PompaManager)Bll).list(FilterFunctions.filter<Pompa>(AktifKartlariGoster));
        }
    }
}