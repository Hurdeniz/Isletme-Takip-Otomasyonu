using Businesss.Concrete;
using Model.Enums;
using Model.Show;
using Windows.UI.Abstract.BaseForms;

namespace Windows.UI.Concrete.Forms.UrunSevkiyatForms
{
    public partial class UrunSevkiyatListForm : BaseListForm
    {
        public UrunSevkiyatListForm()
        {
            InitializeComponent();

            Bll = new UrunSevkiyatManager();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.UrunSevkiyat;
            FormShow = new ShowEditForm<UrunSevkiyatEditFrom>();
            Navigator = longNavigator.controlNavigator1;
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((UrunSevkiyatManager)Bll).list(x => x.Durum == AktifKartlariGoster);
        }
       
    }
}