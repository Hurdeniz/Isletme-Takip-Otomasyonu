using Entities.Abstract.Base;
using Model.Attributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class Il :BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("İl Adı", "txtIlAdi")]
        public string IlAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }


    }
}
