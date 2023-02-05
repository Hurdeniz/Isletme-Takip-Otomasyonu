using Entities.Concrete;
using Entitiess.Abstract.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitiess.Concrete
{
    public class IsletmeSevkiyat : BaseHareketEntity
    {
        public long SevkiyatId { get; set; }

        public long IsletmeId { get; set; }

        public long? SoforId { get; set; }

        public long? AracId { get; set; }

        [StringLength(60)]
        public string IsletmeKullaniciKisi { get; set; }

        public byte AracSayisi { get; set; }

        [StringLength(15)]
        public string AracTipi { get; set; }

        [StringLength(10)]
        public string Jsb { get; set; }      

        [StringLength(500)]
        public string Aciklama { get; set; }


        public Sevkiyat Sevkiyat { get; set; }

        public Isletme Isletme { get; set; }

        public Sofor Sofor { get; set; }

        public Arac Arac { get; set; }
    }
}

