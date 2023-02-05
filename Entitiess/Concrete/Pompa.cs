using Entities.Abstract.Base;
using Model.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class Pompa :BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(60),ZorunluAlan("Pompa Adı" ,"txtPompaAdi")]
        public string PompaAdi { get; set; }

        [StringLength(30)]
        public string PompaCesiti { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }



    }
}
