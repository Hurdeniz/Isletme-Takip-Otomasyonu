using Businesss.Concrete;
using Entitiess.Concrete;
using Model.Enums;
using Model.Show;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;

namespace Windows.UI.Concrete.Forms.IsletmeKullanici
{
    public partial class IsletmeKullaniciListForm : BaseListForm
    {
        public IsletmeKullaniciListForm()
        {
            InitializeComponent();

            Bll = new KullaniciKisiManager();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.KullaniciKisi;
            FormShow = new ShowEditForm<IsletmeKullaniciEditForm>();
            Navigator = longNavigator.controlNavigator1;

        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KullaniciKisiManager)Bll).list(FilterFunctions.filter<IsletmeKullaniciKisi>(AktifKartlariGoster));
        }

        private void grid_Click(object sender, System.EventArgs e)
        {

        }
    }
}