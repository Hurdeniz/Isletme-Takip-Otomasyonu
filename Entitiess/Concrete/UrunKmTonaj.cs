using Entities.Abstract.Base;
using Model.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiess.Concrete
{
    public class UrunKmTonaj : BaseEntityDurum
    {
        [Required, StringLength(100), ZorunluAlan("Fiş No", "txtFisNo")]
        public string FisNo { get; set; }

        public long UrunSevkiyatHareketId { get; set; }

        public long UrunId  { get; set; }

        public long UrunIsletmeId  { get; set; }


       
    }
}
