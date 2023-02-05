using Businesss.Concrete;
using Model.Enums;
using Model.Show;
using Windows.UI.Abstract.BaseForms;

namespace Windows.UI.Concrete.Forms.IlceForms
{
    public partial class IlceListForm : BaseListForm
    {
        private readonly long _ilId;
        private readonly string _ilAdi;

        public IlceListForm(params object[] prm)
        {
            InitializeComponent();

            Bll = new IlceManager();

            _ilId = (long)prm[0];
            _ilAdi = prm[1].ToString();

        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Ilce;
            Navigator = longNavigator.controlNavigator1;
            Text = Text + $" - ({_ilAdi})";
        }
        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((IlceManager)Bll).list(x => x.Durum == AktifKartlariGoster && x.IlId == _ilId);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForm<IlceEditForm>.ShowDialogEditForm(KartTuru.Ilce, id, _ilId, _ilAdi);

            ShowEditFormDefault(result);
        }
    }
}