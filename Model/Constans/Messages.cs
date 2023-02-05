using DevExpress.XtraEditors;
using System.Windows.Forms;


namespace Windows.UI
{
    public class Messages
    {
        public static void HataMesaji(string hataMesaji)
        {
            XtraMessageBox.Show(hataMesaji, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void UyarıMesaji(string UyarıMesaji)
        {
            XtraMessageBox.Show(UyarıMesaji, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult EvetSeciliEvetHayir(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult HayirSeciliEvetHayir(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }
        public static DialogResult EvetSeciliEvetHayirIptal(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult SilMesaj(string kartAdi)
        {
            return HayirSeciliEvetHayir($"Seçtiğiniz {kartAdi} Silinecektir. Onaylıyor Musunuz?", "Silme Onayı");
        }
        public static DialogResult KapanisMesaj()
        {
            return EvetSeciliEvetHayirIptal("Yapılan Değişiklikler Kayıt Edilsin Mi ?", "Çıkış Onay");
        }
        public static DialogResult KayitMesaj()
        {
            return EvetSeciliEvetHayir("Yapılan Değişiklikler Kayıt Edilsin Mi ?", "Kayıt Onay");
        }
        public static void KartSecmemeUyariMesaji()
        {
            UyarıMesaji("Lütfen Bir Kart Seçiniz.");
        }
        public static void MukerrerKayitHataMesaji(string alanAdi)
        {
            HataMesaji($"Girmiş Olduğunuz {alanAdi} Daha Önce Kullanılmıştır. ");
        }
        public static void HataliVeriMesai(string alanAdi)
        {
            HataMesaji($"{alanAdi} Alanına Geçerli Bir Değer Girmelisiniz.");
        }
        public static DialogResult TabloExportMesaj(string dosyaFormati)
        {
            return EvetSeciliEvetHayir($"İlgili Tablo,{dosyaFormati} Olarak Dışarı Aktarılacaktır.Onaylıyor musunuz?", "Aktarım Onay");
        }

        public static void KartBulunumadiMesaj(string kartTuru)
        {
            UyarıMesaji($"İşlem Yapılabilecek {kartTuru} Bulunamadı.");
        }
    }
}
