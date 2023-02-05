using Businesss.Concrete;
using Model.Enums;
using Model.Show;
using System;
using Windows.UI.Abstract.BaseForms;


namespace Windows.UI.Concrete.Forms.IsletmeKmTonajForms
{
    public partial class IsletmeKmTonajListForm : BaseListForm
    {
        private readonly long _sevkiyatId;
        private readonly string _sevkiyatNo;
        private readonly DateTime _sevkiyatTarih;
        private readonly long _isletmeId;
        private readonly string _isletmeNo;
        private readonly string _isletmeAdi;
   

        public IsletmeKmTonajListForm(params object[] prm)
        {
            InitializeComponent();

            Bll = new KmTonajManager();

            _sevkiyatId = (long)prm[0];
            _sevkiyatNo = prm[1].ToString();
            _sevkiyatTarih = (DateTime)prm[2];
            _isletmeId = (long)prm[3];
            _isletmeNo = prm[4].ToString();
            _isletmeAdi = prm[5].ToString();
       
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.IsletmeKmTonaj;
            Navigator = longNavigator.controlNavigator1;
            Text = Text + $" - ({_isletmeAdi} - {_sevkiyatNo})";
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((KmTonajManager)Bll).list(x => x.Durum == AktifKartlariGoster && x.IsletmeSevkiyatId==_sevkiyatId && x.IsletmeId==_isletmeId);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForm<IsletmeKmTonajEditForm>.ShowDialogEditForm(KartTuru.IsletmeKmTonaj, id, _sevkiyatId, _sevkiyatNo, _sevkiyatTarih, _isletmeId,_isletmeNo, _isletmeAdi);

            ShowEditFormDefault(result);
        }
    }
}