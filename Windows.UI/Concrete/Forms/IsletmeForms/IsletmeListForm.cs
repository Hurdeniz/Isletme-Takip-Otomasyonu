using Business.Concrete;
using Entities.Concrete;
using Entitiess.Dto;
using Model.Enums;
using Model.Show;
using System;
using System.Linq;
using System.Linq.Expressions;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;
using Windows.UI.Abstract.Show;


namespace Windows.UI.Concrete.Forms.IsletmeForms
{
    public partial class IsletmeListForm : BaseListForm
    {
        private readonly Expression<Func<Isletme, bool>> _filter;
        bool durum;

        public IsletmeListForm()
        {
            InitializeComponent();
            Bll = new IsletmeManager();
            _filter = x => x.Durum == AktifKartlariGoster;
        }
        public IsletmeListForm(params object[] prm) : this()
        {
            durum = (bool)prm[0];
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id);
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Isletme;
            FormShow = new ShowEditForm<IsletmeEditForm>();
            Navigator = longNavigator.controlNavigator1;
       
        }

        protected override void Listele()
        {
            //var list = ((IsletmeManager)Bll).list(FilterFunctions.filter<Isletme>(AktifKartlariGoster));
            var list = ((IsletmeManager)Bll).list(_filter);

            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;

            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunumadiMesaj("Kart");
        }

     

    }
}