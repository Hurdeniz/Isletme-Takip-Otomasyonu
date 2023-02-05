using Businesss.Concrete;
using Model.Enums;
using Model.Show;
using System;
using Windows.UI.Abstract.BaseForms;

namespace Windows.UI.Concrete.Forms.UrunKmTonajForms
{
    public partial class UrunKmTonajListForm : BaseListForm
    {
        private readonly long _urunSevkiyatId;
        private readonly string _urunSevkiyatNo;
        private readonly DateTime _sevkiyatTarih;
        private readonly long _urunId;
        private readonly string _urunNo;
        private readonly string _urunAdi;

        public UrunKmTonajListForm(params object[] prm)
        {
            InitializeComponent();


            Bll = new KmTonajManager();

            _urunSevkiyatId = (long)prm[0];
            _urunSevkiyatNo = prm[1].ToString();
            _sevkiyatTarih = (DateTime)prm[2];
            _urunId = (long)prm[3];
            _urunNo = prm[4].ToString();
            _urunAdi = prm[5].ToString();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.UrunKmTonaj;
            Navigator = longNavigator.controlNavigator1;
            Text = Text + $" - ({_urunSevkiyatNo} - {_urunAdi})";
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((KmTonajManager)Bll).list(x => x.Durum == AktifKartlariGoster && x.UrunSevkiyatHareketId == _urunSevkiyatId && x.UrunId == _urunId);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForm<UrunKmTonajEditForm>.ShowDialogEditForm(KartTuru.UrunKmTonaj, id, _urunSevkiyatId, _urunSevkiyatNo, _sevkiyatTarih, _urunId, _urunNo, _urunAdi);

            ShowEditFormDefault(result);
        }
    }
}