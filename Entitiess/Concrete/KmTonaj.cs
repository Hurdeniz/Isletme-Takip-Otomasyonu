using Entities.Abstract.Base;
using Entities.Concrete;
using Model.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitiess.Concrete
{
    public class KmTonaj : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        public bool KayitTipi { get; set; }

        public long? IsletmeId { get; set; }

        [StringLength(30)]
        public string IsletmeNo { get; set; }

        [StringLength(75)]
        public string IsletmeAdi { get; set; }

        public long? IsletmeSevkiyatId { get; set; }

        [StringLength(30)]
        public string IsletmeSevkiyatNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime IsletmeSevkiyatTarihi { get; set; }

        public long? UrunSevkiyatHareketId { get; set; }

        [StringLength(30)]
        public string UrunSevkiyatNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime UrunSevkiyatTarihi { get; set; }

        public long? UrunId { get; set; }

        [StringLength(30)]
        public string UrunNo { get; set; }

        [StringLength(100)]
        public string UrunAdi { get; set; }

        public long? UrunIsletmeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime KmTonajTarih { get; set; } = DateTime.Now.Date;

        [StringLength(5)]
        public string GirisSaat { get; set; }

        [StringLength(5)]
        public string CikisSaat { get; set; }

        [Column(TypeName = "decimal")]
        public decimal PhDegeri { get; set; }

        [Column(TypeName = "decimal")]
        public decimal Nem { get; set; }

        [Column(TypeName = "decimal")]
        public decimal KmOrani { get; set; }

        public int TonajMiktari { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }



        public IsletmeSevkiyat IsletmeSevkiyat { get; set; }

        public Isletme Isletme { get; set; }

        public Urun Urun { get; set; }

        public UrunSevkiyatHareket UrunSevkiyatHareket { get; set; }

        public UrunIsletme UrunIsletme { get; set; }

    }
}
