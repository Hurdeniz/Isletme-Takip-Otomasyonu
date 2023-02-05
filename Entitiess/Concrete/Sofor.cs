using Entities.Abstract.Base;
using Model.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitiess.Concrete
{
    public class Sofor : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(60), ZorunluAlan("Adı Soyadı", "txtAdiSoyadi")]
        public string SoforAdiSoyadi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
