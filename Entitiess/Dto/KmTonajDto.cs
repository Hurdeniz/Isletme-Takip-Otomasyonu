using Entities.Abstract.Base;
using Entitiess.Concrete;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitiess.Dto
{
    [NotMapped]
    public class KmTonajS : KmTonaj
    {    
        public string UrunIsletmeAdi { get; set; }
    }

    public class KmTonajL : BaseEntity
    {

        public string IsletmeNo { get; set; }

        public string IsletmeAdi { get; set; }

        public string IsletmeSevkiyatNo { get; set; }

        public DateTime IsletmeSevkiyatTarih { get; set; }

        public string UrunNo { get; set; }

        public string UrunAdi { get; set; }

        public string UrunSevkiyatNo { get; set; }

        public DateTime UrunSevkiyatTarih { get; set; }

        public string UrunIsletmeAdi { get; set; }

        public DateTime KayitTarihi { get; set; }

        public string GirisSaat { get; set; }

        public string CikisSaat { get; set; }

        public decimal PhDegeri { get; set; }

        public decimal Nem { get; set; }

        public decimal KmOrani { get; set; }

        public int TonajMiktari { get; set; }

        public string Aciklama { get; set; }

    }

}
