using Model.Enums;
using System;
using Windows.UI.Abstract.Show;
using Windows.UI.Concrete.Forms.IsletmeForms;
using Windows.UI.Concrete.Forms.IsletmeKmTonajForms;
using Windows.UI.Concrete.Forms.RaporlarForms;
using Windows.UI.Concrete.Forms.RaporlarForms.GridForms;
using Windows.UI.Concrete.Forms.SevkiyatForms;
using Windows.UI.Concrete.Forms.SevkiyatListesiForms;
using Windows.UI.Concrete.Forms.UrunForms;
using Windows.UI.Concrete.Forms.UrunIsletmeForms;
using Windows.UI.Concrete.Forms.UrunSevkiyatForms;

namespace Windows.UI.Concrete.GenelForms
{
    public partial class AnaForm : DevExpress.XtraEditors.XtraForm
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btnIsletmeKartlari_Click(object sender, EventArgs e)
        {

            ShowListForm<IsletmeListForm>.ShowListForms(KartTuru.Isletme);
            

        }

        private void btnDepoKartlari_Click(object sender, EventArgs e)
        {
        
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            ShowListForm<SevkiyatListForm>.ShowListForms(KartTuru.Sevkiyat);
        }

        private void btnKmTonaj_Click(object sender, EventArgs e)
        {
 
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {

        }
     
        IsletmeRaporForm IsletmeRapor;
        private void btnIsletmeler_Click(object sender, EventArgs e)
        {
            if (IsletmeRapor == null || IsletmeRapor.IsDisposed)
            {
                IsletmeRapor = new IsletmeRaporForm();
                IsletmeRapor.MdiParent = this;
                IsletmeRapor.Show();
            }
        }
        IsletmeSevkiyatRaporForm SevkiyatRapor;
        private void btnSevkiyatlar_Click(object sender, EventArgs e)
        {

            if (SevkiyatRapor == null || SevkiyatRapor.IsDisposed)
            {
                SevkiyatRapor = new IsletmeSevkiyatRaporForm();
                SevkiyatRapor.MdiParent = this;
                SevkiyatRapor.Show();
            }
        }

        private void btnUrunKartları_Click(object sender, EventArgs e)
        {
               ShowListForm<UrunListForm>.ShowListForms(KartTuru.Urun);

        }

        private void btnUrunSevkiyat_Click(object sender, EventArgs e)
        {
            ShowListForm<UrunSevkiyatListForm>.ShowListForms(KartTuru.UrunSevkiyat);
        }

        IsletmeSevkiyatListesiForm SevkiyatListesi;
        private void btnIsletmeKmTonaj_Click(object sender, EventArgs e)
        {

            if (SevkiyatListesi == null || SevkiyatListesi.IsDisposed)
            {
                SevkiyatListesi = new IsletmeSevkiyatListesiForm();
                SevkiyatListesi.MdiParent = this;
                SevkiyatListesi.Show();
            }
        }

        UrunSevkiyatListesiForm UrunSevkiyatListesi;
        private void btnUrunKmTonaj_Click(object sender, EventArgs e)
        {
            if (UrunSevkiyatListesi == null || UrunSevkiyatListesi.IsDisposed)
            {
                UrunSevkiyatListesi = new UrunSevkiyatListesiForm();
                UrunSevkiyatListesi.MdiParent = this;
                UrunSevkiyatListesi.Show();
            }
        }

        UrunSevkiyatRaporForm UrunSevkiyatRapor;
        private void btnUrunSevkiyatRaporu_Click(object sender, EventArgs e)
        {

            if (UrunSevkiyatRapor == null || UrunSevkiyatRapor.IsDisposed)
            {
                UrunSevkiyatRapor = new UrunSevkiyatRaporForm();
                UrunSevkiyatRapor.MdiParent = this;
                UrunSevkiyatRapor.Show();
            }
        }

        IsletmeSevkiyatDegerleriForm IsletmeSevkiyatDegerleri;
        private void btnIsletmeSevkiyatDegerleri_Click(object sender, EventArgs e)
        {

            if (IsletmeSevkiyatDegerleri == null || IsletmeSevkiyatDegerleri.IsDisposed)
            {
                IsletmeSevkiyatDegerleri = new IsletmeSevkiyatDegerleriForm();
                IsletmeSevkiyatDegerleri.MdiParent = this;
                IsletmeSevkiyatDegerleri.Show();
            }
        }

        UrunSevkiyatDegerleriForm UrunSevkiyatDegerleri;
        private void btnUrunSevkiyatDegerleriRaporu_Click(object sender, EventArgs e)
        {
            if (UrunSevkiyatDegerleri == null || UrunSevkiyatDegerleri.IsDisposed)
            {
                UrunSevkiyatDegerleri = new UrunSevkiyatDegerleriForm();
                UrunSevkiyatDegerleri.MdiParent = this;
                UrunSevkiyatDegerleri.Show();
            }
        }
    }
}