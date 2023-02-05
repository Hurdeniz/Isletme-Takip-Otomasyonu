using Businesss.Concrete;
using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using Model.Enums;
using Model.Show;
using Windows.UI.Abstract.BaseForms;

namespace Windows.UI.Concrete.Forms.FiltreForms
{
    public partial class FiltreListForm : BaseListForm
    {
   
        private readonly KartTuru _filtreKartTuru;
        private readonly GridControl _filtreGrid;

        public FiltreListForm(params object[] prm)
        {
            InitializeComponent();

            Bll = new FiltreManager();

            _filtreKartTuru = (KartTuru)prm[0];
            _filtreGrid = (GridControl)prm[1];

            HideItems = new BarItem[] { btnFiltrele, btnKolonlar, btnYazdir, btnGonder, barF8, barFiltre, barCtrlO, barKolonlar, barCtrlP, barYazdir, barF12, barGonder };//gizlenecek olanlar
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Filtre;
            Navigator = longNavigator.controlNavigator1;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((FiltreManager)Bll).list(x => x.KartTuru == _filtreKartTuru);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForm<FiltreEditForm>.ShowDialogEditForm(KartTuru.Filtre, id, _filtreKartTuru, _filtreGrid);

            ShowEditFormDefault(result);
        }
    }
}