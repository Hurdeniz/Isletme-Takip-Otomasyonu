using Businesss.Concrete;
using Model.Constans;
using Model.Enums;
using Model.Show;
using Windows.UI.Abstract.BaseForms;

namespace Windows.UI.Concrete.Forms.GrupForms
{
    public partial class GrupListForm : BaseListForm
    {
        private readonly GrupKodTuru _grupKodTuru;
        private readonly KartTuru _grupKodKartTuru;

        public GrupListForm(params object[] prm)
        {
            InitializeComponent();

            Bll = new GrupKodManager();

            _grupKodTuru = (GrupKodTuru)prm[0];
            _grupKodKartTuru = (KartTuru)prm[1];
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Grup;
            Navigator = longNavigator.controlNavigator1;
            Text = $"{Text} - ({_grupKodTuru.ToName()})";
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((GrupKodManager)Bll).list(x => x.KodTuru == _grupKodTuru && x.KartTuru == _grupKodKartTuru);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForm<GrupEditForm>.ShowDialogEditForm(KartTuru.Grup, id, _grupKodTuru, _grupKodKartTuru);

            ShowEditFormDefault(result);
        }
    }
}