using Entities.Abstract.Base;
using Model.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitiess.Concrete
{
    public class Urun :BaseEntityDurum
    {

        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(100), ZorunluAlan("Ürün Adı", "txtUrunAdi")]
        public string UrunAdi { get; set; }

        [Column(TypeName = "date")]
        public DateTime UrunKayitTarihi { get; set; } = DateTime.Now.Date;

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
