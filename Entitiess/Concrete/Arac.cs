using Entities.Abstract.Base;
using Model.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitiess.Concrete
{
    public class Arac : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(12), ZorunluAlan("Araç Plaka", "txtAracPlaka")]
        public string AracPlaka { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
