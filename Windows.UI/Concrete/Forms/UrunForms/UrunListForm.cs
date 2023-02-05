using Businesss.Concrete;
using Entitiess.Concrete;
using Model.Enums;
using Model.Show;
using System;
using System.Linq;
using System.Linq.Expressions;
using Windows.UI.Abstract.BaseForms;

namespace Windows.UI.Concrete.Forms.UrunForms
{
    public partial class UrunListForm : BaseListForm
    {
        private readonly Expression<Func<Urun, bool>> _filter;
        bool durum;

        public UrunListForm()
        {
            InitializeComponent();

            Bll = new UrunManager();
        }
        public UrunListForm(params object[] prm) : this()
        {
            durum = (bool)prm[0];
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id);
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Urun;
            FormShow = new ShowEditForm<UrunEditForm>();
            Navigator = longNavigator.controlNavigator1;
        }

        protected override void Listele()
        {
           // Tablo.GridControl.DataSource = ((UrunManager)Bll).list(FilterFunctions.filter<Urun>(AktifKartlariGoster));

        
            var list = ((UrunManager)Bll).list(_filter);

            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;

            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunumadiMesaj("Kart");
        }
    }
}