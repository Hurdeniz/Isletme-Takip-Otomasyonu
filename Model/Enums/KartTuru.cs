using System.ComponentModel;

namespace Model.Enums
{
    public enum KartTuru : byte
    {
        [Description("İşletme Kartı")]
        Isletme = 1,
        [Description("Sevkiyat Kartı")]
        Sevkiyat = 2,
        [Description("İl Kartı")]
        Il = 3,
        [Description("İlçe Kartı")]
        Ilce = 4,
        [Description("Filtre Kartı")]
        Filtre = 5,
        [Description("Grup Kartı")]
        Grup = 6,
        [Description("Pompa Kartı")]
        Pompa = 7,
        [Description("Soför Kartı")]
        Sofor = 8,
        [Description("Araç Kartı")]
        Arac = 9,
        [Description("KmTonaj Kartı")]
        IsletmeKmTonaj = 10,
        [Description("İşletme Rapor Kartı")]
        IsletmeRapor = 11,
        [Description("İşletme Sevkiyat Rapor Kartı")]
        IsletmeSevkiyatRapor = 12,
        [Description("Sevkiyat Rapor Kartı")]
        SevkiyatRapor = 13,
        [Description("İşletme Sahibi Kartı")]
        IsletmeSahibi = 14,
        [Description("Kullanıcı Kişi Kartı")]
        KullaniciKisi = 15,
        [Description("Ürün Kartı")]
        Urun = 16,
        [Description("Ürün İşletme Kartı")]
        UrunIsletme = 17,
        [Description("Ürün Sevkiyat Kartı")]
        UrunSevkiyat = 18,
        [Description("İşletme Sevkiyat Listesi Kartı")]
        IsletmeSevkiyatListesi = 19,
        [Description("Ürün Sevkiyat Listesi Kartı")]
        UrunSevkiyatListesi = 20,
        [Description("Ürün KmTonaj Kartı")]
        UrunKmTonaj = 21,
        [Description("Ürün Sevkiyat Rapor Kartı")]
        UrunSevkiyatRapor = 22,
        [Description("İşletme Değerleri Rapor Kartı")]
        IsletmeDegerleriRapor = 23,
        [Description("Ürün Değerleri Rapor Kartı")]
        UrunDegerleriRapor = 24,
    }
}
