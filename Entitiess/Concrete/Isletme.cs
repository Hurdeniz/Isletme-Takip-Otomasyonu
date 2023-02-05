using Entities.Abstract.Base;
using Entitiess.Concrete;
using Model.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class Isletme :BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)] // aynı kod dan iki kez girilmeyecek
        public override string Kod { get; set; }

        [Required, StringLength(75), ZorunluAlan("İşletme Adı", "txtIsletmeAdi")]
        public string IsletmeAdi { get; set; }

        [ZorunluAlan("İşletme Sahibi Adı Soyadı", "btnEditIsletmeSahibi")]
        public long IsletmeSahibiId { get; set; }

        public long? IsletmeKullaniciKisiId { get; set; }

        [StringLength(5)]
        public string Kapasite { get; set; }

        [StringLength(5)]
        public string HayvanSayisi { get; set; }

        [ZorunluAlan("Pompa Adı", "btnEditPompaDurum")]
        public long PompaId { get; set; }

        [ZorunluAlan("İl Adı", "btnEditIl")]
        public long IlId { get; set; }

        [ZorunluAlan("İlçe Adı", "btnEditIlce")]
        public long IlceId { get; set; }

        [StringLength(500)]
        public string Adres { get; set; }

        [Column(TypeName = "date")]
        public DateTime KayitTarihi { get; set; } = DateTime.Now.Date;

        public long? GrupKodId { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }


        public GrupKod GrupKod { get; set; }

        public Il Il { get; set; }

        public Ilce Ilce { get; set; }

        public Pompa Pompa { get; set; }

        public IsletmeSahibi IsletmeSahibi { get; set; }

        public IsletmeKullaniciKisi IsletmeKullaniciKisi { get; set; }

        

    }
}
