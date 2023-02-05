using Entities.Abstract.Base;
using Entitiess.Concrete;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitiess.Dto
{
    [NotMapped]
    public class UrunIsletmeS :UrunIsletme
    {
        public string IlAdi { get; set; }

        public string IlceAdi { get; set; }
    }

    public class UrunIsletmeL : BaseEntity
    {

        public string UrunIsletmeAdi { get; set; }

        public string UrunIsletmeTelefon { get; set; }

        public string IlAdi { get; set; }

        public string IlceAdi { get; set; }

        public string Adres { get; set; }

        public DateTime KayitTarihi { get; set; } 
 
        public string Aciklama { get; set; }   

    }
}
