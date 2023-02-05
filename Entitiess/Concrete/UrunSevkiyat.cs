using Entities.Abstract.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitiess.Concrete
{
    public class UrunSevkiyat : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Column(TypeName = "date")]
        public DateTime SevkiyatTarih { get; set; } = DateTime.Now.Date;

        [StringLength(5)]
        public string Saat { get; set; } 

        [StringLength(500)]
        public string Aciklama { get; set; }


        [InverseProperty("UrunSevkiyat")]
        public ICollection<UrunSevkiyatHareket> UrunSevkiyatHareket { get; set; }
    }
}
