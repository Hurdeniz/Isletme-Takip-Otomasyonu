using Business.Constans;
using Businesss.Concrete;
using Entitiess.Concrete;
using Entitiess.Dto;
using Model.Enums;
using System.Linq;
using Windows.UI.Abstract.Functions;
using Windows.UI.Abstract.Show;
using Windows.UI.Concrete.Forms.UrunForms;
using Windows.UI.Concrete.UseControls.Base;
using DevExpress.XtraGrid.Views.Base;

namespace Windows.UI.Concrete.UseControls.UrunSevkiyatTable
{
    public partial class UrunSevkiyatHareketTable :BaseTablo
    {
        public UrunSevkiyatHareketTable()
        {
            InitializeComponent();

            Bll = new UrunSevkiyatHareketManager();
            Tablo = tablo;
            EventLoad();
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((UrunSevkiyatHareketManager)Bll).List(x => x.UrunSevkiyatId == OwnerForm.Id).ToBindingList<UrunSevkiyatHareketL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<UrunSevkiyatHareketL>().Where(x => !x.Delete).Select(x => x.UrunId).ToList();//acılacak isletme listesinde id lerini alıp açtığımız formda eklenmişleri göstermiyor yada silindiyse onu gösteriyor 

            var entities = ShowListForm<UrunListForm>.ShowDialogListForm(KartTuru.Urun, ListeDisiTutulacakKayitlar, true, true).EntityListConvert<Urun>();
            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new UrunSevkiyatHareketL
                {
                    UrunSevkiyatId = OwnerForm.Id,
                    UrunId = entity.Id,
                    UrunAdi = entity.UrunAdi,
                    UrunNo= entity.Kod,
                    SoforAdiSoyadi = "",
                    AracPlaka = "",
                    Insert = true,
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
            tablo.FocusedColumn = colSoforAdiSoyadi;

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
