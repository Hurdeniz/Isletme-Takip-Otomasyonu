using Businesss.Concrete;
using Entitiess.Concrete;
using Model.Enums;
using Model.Show;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;

namespace Windows.UI.Concrete.Forms.UrunIsletmeForms
{
    public partial class UrunIsletmeListForm : BaseListForm
    {
        public UrunIsletmeListForm()
        {
            InitializeComponent();

            Bll = new UrunIsletmeManager();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.UrunIsletme;
            FormShow = new ShowEditForm<UrunIsletmeEditForm>();
            Navigator = longNavigator.controlNavigator1;

        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((UrunIsletmeManager)Bll).list(FilterFunctions.filter<UrunIsletme>(AktifKartlariGoster));
        }


    }
}