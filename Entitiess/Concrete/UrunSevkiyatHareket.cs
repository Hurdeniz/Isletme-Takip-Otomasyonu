using Entitiess.Abstract.Base;
using System.ComponentModel.DataAnnotations;

namespace Entitiess.Concrete
{
    public class UrunSevkiyatHareket : BaseHareketEntity
    {
        public long UrunSevkiyatId { get; set; }

        public long UrunId { get; set; }

        public long? SoforId { get; set; }

        public long? AracId { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }


        public UrunSevkiyat UrunSevkiyat { get; set; }

        public Urun Urun { get; set; }

        public Sofor Sofor { get; set; }

        public Arac Arac { get; set; }
    }
}
