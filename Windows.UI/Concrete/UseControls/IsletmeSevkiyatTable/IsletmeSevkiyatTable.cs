using Business.Constans;
using Businesss.Concrete;
using DevExpress.XtraGrid.Views.Base;
using Entitiess.Dto;
using Model.Enums;
using System.Linq;
using Windows.UI.Abstract.Functions;
using Windows.UI.Abstract.Show;
using Windows.UI.Concrete.Forms.IsletmeForms;
using Windows.UI.Concrete.UseControls.Base;

namespace Windows.UI.Concrete.UseControls.IsletmeSevkiyatTable
{
    public partial class IsletmeSevkiyatTable : BaseTablo
    {
        public IsletmeSevkiyatTable()
        {
            InitializeComponent();

            Bll = new IsletmeSevkiyatManager();
            Tablo = tablo;
            EventLoad();
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((IsletmeSevkiyatManager)Bll).List(x => x.SevkiyatId == OwnerForm.Id).ToBindingList<IsletmeSevkiyatL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<IsletmeSevkiyatL>().Where(x => !x.Delete).Select(x => x.IsletmeId).ToList();//acılacak isletme listesinde id lerini alıp açtığımız formda eklenmişleri göstermiyor yada silindiyse onu gösteriyor 

            var entities = ShowListForm<IsletmeListForm>.ShowDialogListForm(KartTuru.Isletme, ListeDisiTutulacakKayitlar, true,true).EntityListConvert<IsletmeL>();
            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new IsletmeSevkiyatL
                {
                    SevkiyatId=OwnerForm.Id,
                    IsletmeId=entity.Id,
                    IsletmeAdi=entity.IsletmeAdi,
                    IsletmeNo=entity.Kod,
                    IsletmeKullaniciKisi=entity.IsletmeKullaniciKisiAdiSoyadi,
                    SoforAdiSoyadi="",
                    AracPlaka="",
                    AracTipi="",
                    AracSayisi =0,
                    Jsb="",                  
                    Insert=true,        
                };

                //var sofor = (Sofor)ShowListForm<SoforListForm>.ShowDialogListForm(KartTuru.Sofor, -1);
                //if (sofor == null) return;
                //row.SoforId = sofor.Id;
                //row.SoforAdiSoyadi = sofor.SoforAdiSoyadi;

                //var arac = (Arac)ShowListForm<AracListForm>.ShowDialogListForm(KartTuru.Arac, -1);
                //if (arac == null) return;
                //row.AracId = arac.Id;
                //row.AracPlaka = arac.AracPlaka;

               source.Add(row);
            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colAracTipi;

            ButonEnabledDurum(true);
        }
        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colSoforAdiSoyadi)
                e.FocusedColumn.Sec(tablo, insUpNavigator.controlNavigator1, repositorySofor, colSoforId);
            else if (e.FocusedColumn == colAracPlaka)
                e.FocusedColumn.Sec(tablo, insUpNavigator.controlNavigator1, repositoryArac, colAracId);

        }

    }
}
