using Entities.Abstract.Base;
using Model.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitiess.Concrete
{
    public class IsletmeKullaniciKisi : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)] // aynı kod dan iki kez girilmeyecek
        public override string Kod { get; set; }

        [Required, StringLength(60), ZorunluAlan("Adı Soyadı", "txtAdiSoyadi")]
        public string KullaniciKisiAdiSoyadi { get; set; }

        [StringLength(17)]
        public string KullaniciKisiTelefon { get; set; }

        [Column(TypeName = "date")]
        public DateTime BaslamaTarihi { get; set; } = DateTime.Now.Date;

        [Column(TypeName = "date")]
        public DateTime BitisTarihi { get; set; } = DateTime.Now.Date;

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
