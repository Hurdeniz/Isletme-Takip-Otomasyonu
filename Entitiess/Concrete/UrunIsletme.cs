using Entities.Abstract.Base;
using Entities.Concrete;
using Model.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitiess.Concrete
{
    public class UrunIsletme :BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(75), ZorunluAlan("Ürün İşletme Adı", "txtUrunIsletmeAdi")]
        public string UrunIsletmeAdi { get; set; }

        [StringLength(17)]
        public string UrunIsletmeTelefon { get; set; }

        [ZorunluAlan("İl Adı", "btnEditIl")]
        public long IlId { get; set; }

        [ZorunluAlan("İlçe Adı", "btnEditIlce")]
        public long IlceId { get; set; }

        [StringLength(500)]
        public string Adres { get; set; }

        [Column(TypeName = "date")]
        public DateTime KayitTarihi { get; set; } = DateTime.Now.Date;

        [StringLength(500)]
        public string Aciklama { get; set; }


        public Il Il { get; set; }

        public Ilce Ilce { get; set; }
    }

}
