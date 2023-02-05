using Entities.Abstract.Base;
using Entities.Concrete;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitiess.Dto
{
    [NotMapped]
    public class IsletmeS : Isletme
    {
        public string GrupKodAdi { get; set; }

        public string IlAdi { get; set; }

        public string IlceAdi { get; set; }

        public string PompaAdi { get; set; }

        public string IsletmeSahibiAdi { get; set; }

        public string IsletmeKullaniciKisiAdiSoyadi { get; set; }
        
    }

    public class IsletmeL : BaseEntity
    {
     
        public string IsletmeAdi { get; set; }

        public string IsletmeSahibiAdi { get; set; }

        public string IsletmeSahibiTelefon { get; set; }

        public string IsletmeKullaniciKisiAdiSoyadi { get; set; }

        public string IsletmeKullaniciKisiTelefon { get; set; }

        public string GrupKodAdi { get; set; }

        public DateTime KayitTarihi { get; set; }

        public string Kapasite { get; set; }

        public string HayvanSayisi { get; set; }

        public string PompaAdi { get; set; }

        public string PompaCesiti { get; set; }

        public string IlAdi { get; set; }

        public string IlceAdi { get; set; }

        public string Adres { get; set; }

        public string Aciklama { get; set; }

    }
}
