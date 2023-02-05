using Entitiess.Abstract.Interfaces;
using Entitiess.Concrete;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitiess.Dto
{
    [NotMapped]
    public class UrunSevkiyatHareketL : UrunSevkiyatHareket, IBaseHareketEntity
    {

        public string UrunSevkiyatNo { get; set; }

        public DateTime UrunSevkiyatTarih { get; set; }

        public string UrunSevkiyatSaat { get; set; }

        public string UrunNo { get; set; }

        public string UrunAdi { get; set; }

        public string SoforAdiSoyadi { get; set; }

        public string AracPlaka { get; set; }

        public bool Insert { get; set; }

        public bool Update { get; set; }

        public bool Delete { get; set; }
    }
}
