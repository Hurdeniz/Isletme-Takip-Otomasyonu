using Entities.Abstract.Base;
using Model.Attributes;
using Model.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitiess.Concrete
{
    public class GrupKod :BaseEntity
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Grup Adı", "txtGrupKodAdi")]
        public string GrupKodAdi { get; set; }

        [Required]
        public GrupKodTuru KodTuru { get; set; }

        [Required]
        public KartTuru KartTuru { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
