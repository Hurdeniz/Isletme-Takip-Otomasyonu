using Entities.Abstract.Base;
using Entitiess.Abstract.Interfaces;
using Entitiess.Concrete;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitiess.Dto
{
    [NotMapped]
    public class IsletmeSevkiyatL : IsletmeSevkiyat, IBaseHareketEntity
    {
        public string IsletmeNo { get; set; }

        public string SevkiyatNo { get; set; }

        public DateTime SevkiyatTarih { get; set; }

        public string SevkiyatSaat { get; set; }

        public string IsletmeAdi { get; set; }

        public string IsletmeSahibiAdi { get; set; }

        public string Kapasite { get; set; }

        public string HayvanSayisi { get; set; }

        public string PompaAdi { get; set; }

        public string PompaCesiti { get; set; }

        public string IlAdi { get; set; }

        public string IlceAdi { get; set; }

        public string Adres { get; set; }

        public string SoforAdiSoyadi { get; set; }

        public string AracPlaka { get; set; }

        public bool Insert { get; set; }

        public bool Update { get; set; }

        public bool Delete { get; set; }
    }

}
