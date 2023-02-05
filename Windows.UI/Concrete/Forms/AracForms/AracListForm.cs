using Businesss.Concrete;
using Entitiess.Concrete;
using Model.Enums;
using Model.Show;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;

namespace Windows.UI.Concrete.Forms.AracForms
{
    public partial class AracListForm : BaseListForm
    {
        public AracListForm()
        {
            InitializeComponent();

            Bll = new AracManager();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Arac;
            FormShow = new ShowEditForm<AracEditForm>();
            Navigator = longNavigator.controlNavigator1;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((AracManager)Bll).list(FilterFunctions.filter<Arac>(AktifKartlariGoster));
        }
    }
}