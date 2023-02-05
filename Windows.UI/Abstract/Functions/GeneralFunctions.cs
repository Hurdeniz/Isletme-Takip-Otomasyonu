using DevExpress.XtraBars;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Entities.Abstract.Base;
using Entitiess.Abstract.Base;
using Entitiess.Abstract.Interfaces;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using Windows.UI.Concrete.UseControls.Controls;


namespace Windows.UI.Abstract.Functions
{
    public static class GeneralFunctions
    {
        public static long GetRowId(this GridView tablo)
        {
            if (tablo.FocusedRowHandle > -1) return (long)tablo.GetFocusedRowCellValue("Id");
            Messages.KartSecmemeUyariMesaji();
            return -1;
        }

        public static long GetRowCellId(this GridView tablo,GridColumn idColumn)
        {
            var value = tablo.GetRowCellValue(tablo.FocusedRowHandle, idColumn);
            return (long?)value ?? -1;//eğer null ise -1 gönder
        }

        public static T GetRow<T>(this GridView tablo, bool mesajVer = true)
        {
            if (tablo.FocusedRowHandle > -1) return (T)tablo.GetRow(tablo.FocusedRowHandle);

            if (mesajVer)
                Messages.KartSecmemeUyariMesaji();

            return default(T);
        }

  

        public static T GetRow<T>(this GridView tablo, int rowHandle)
        {
            if (tablo.FocusedRowHandle > -1) return (T)tablo.GetRow(rowHandle);
            Messages.KartSecmemeUyariMesaji();

            return default(T);
        }

        private static VeriDegisimYeri VeriDegisimYeriGetir<T>(T oldEntity, T currentEntity)
        {
            foreach (var prop in currentEntity.GetType().GetProperties())
            {
                if (prop.PropertyType.Namespace == "System.Collections.Generic") continue;
                var oldValue = prop.GetValue(oldEntity) ?? string.Empty;
                var currentValue = prop.GetValue(currentEntity) ?? string.Empty;

                if (prop.PropertyType == typeof(byte[]))
                {
                    if (string.IsNullOrEmpty(oldValue.ToString()))
                        oldValue = new byte[] { 0 };
                    if (string.IsNullOrEmpty(currentValue.ToString()))
                        currentValue = new byte[] { 0 };

                    if (((byte[])oldValue).Length != ((byte[])currentValue).Length)
                        return VeriDegisimYeri.Alan;
                }
                else if (!currentValue.Equals(oldValue))
                    return VeriDegisimYeri.Alan;
            }
            return VeriDegisimYeri.VeriDegisimYok;
        }

        public static void ButtonEnabledDurum<T>(BarButtonItem btnYeni, BarButtonItem btnKaydet, BarButtonItem btnGeriAl, BarButtonItem btnSil, T oldEntity, T currentEntity)
        {
            var veriDegisimYeri = VeriDegisimYeriGetir(oldEntity, currentEntity);
            var buttonEnableDurum = veriDegisimYeri == VeriDegisimYeri.Alan;

            btnKaydet.Enabled = buttonEnableDurum;//veri değişmişse kaydet butonu aktif
            btnGeriAl.Enabled = buttonEnableDurum;
            btnYeni.Enabled = !buttonEnableDurum;
            btnSil.Enabled = !buttonEnableDurum;

        }

        public static void ButtonEnabledDurum<T>(BarButtonItem btnYeni, BarButtonItem btnKaydet, BarButtonItem btnGeriAl, BarButtonItem btnSil, T oldEntity, T currentEntity, bool tableValueCahnged)
        {
            var veriDegisimYeri = tableValueCahnged ? VeriDegisimYeri.Tablo : VeriDegisimYeriGetir(oldEntity, currentEntity);
            var buttonEnableDurum = veriDegisimYeri == VeriDegisimYeri.Alan || veriDegisimYeri == VeriDegisimYeri.Tablo;

            btnKaydet.Enabled = buttonEnableDurum;//veri değişmişse kaydet butonu aktif
            btnGeriAl.Enabled = buttonEnableDurum;
            btnYeni.Enabled = !buttonEnableDurum;
            btnSil.Enabled = !buttonEnableDurum;

        }
        public static void ButtonEnabledDurum<T>(BarButtonItem btnKaydet, BarButtonItem btnFarkliKaydet, BarButtonItem btnSil, IslemTuru islemTuru, T oldEntity, T currentEntity)
        {
            var veriDegisimYeri = VeriDegisimYeriGetir(oldEntity, currentEntity);
            var buttonEnableDurum = veriDegisimYeri == VeriDegisimYeri.Alan;

            btnKaydet.Enabled = buttonEnableDurum;
            btnFarkliKaydet.Enabled = islemTuru != IslemTuru.EntityInsert;
            btnSil.Enabled = !buttonEnableDurum;

        }

        public static long IdOlustur(this IslemTuru islemTuru, BaseEntity selectedEntity)
        {
            string SifirEkle(string deger)
            {
                if (deger.Length == 1)
                    return "0" + deger;
                return deger;

            }
            string UcBasamakYap(string deger)
            {
                switch (deger.Length)
                {
                    case 1:
                        return "00" + deger;
                    case 2:
                        return "0" + deger;
                }
                return deger;
            }
            string Id()
            {
                var yil = DateTime.Now.Date.Year.ToString();
                var ay = SifirEkle(DateTime.Now.Date.Month.ToString());//05
                var gun = SifirEkle(DateTime.Now.Date.Day.ToString());
                var saat = SifirEkle(DateTime.Now.Hour.ToString());
                var dakika = SifirEkle(DateTime.Now.Minute.ToString());
                var saniye = SifirEkle(DateTime.Now.Second.ToString());
                var milisaniye = UcBasamakYap(DateTime.Now.Millisecond.ToString());
                var random = SifirEkle(new Random().Next(0, 99).ToString());

                return yil + ay + gun + saat + dakika + saniye + milisaniye + random;

            }
            var id = Id();

            return islemTuru == IslemTuru.EntityUpdate ? selectedEntity.Id : long.Parse(Id());
        }

        public static void ControlEnabledChange(this MyButtonEdit baseEdit, Control prmEdit)
        {
            switch (prmEdit)
            {
                case MyButtonEdit edt:
                    edt.Enabled = baseEdit.Id.HasValue && baseEdit.Id > 0;
                    edt.Id = null;
                    edt.EditValue = null;
                    break;
            }

        }
        public static void RowFocus(this GridView tablo, string aranacakKolon, object aranacakDeger)
        {
            var rowHandle = 0;

            for (int i = 0; i < tablo.RowCount; i++)
            {
                var bulunanDeger = tablo.GetRowCellValue(i, aranacakKolon);
                if (aranacakDeger.Equals(bulunanDeger))
                    rowHandle = i;
            }
            tablo.FocusedRowHandle = rowHandle;
        }

        public static void RowFocus(this GridView tablo, int rowhandle)
        {
            if (rowhandle <= 0) return;
            if (rowhandle == tablo.RowCount - 1)
                tablo.FocusedRowHandle = rowhandle;
            else
                tablo.FocusedRowHandle = rowhandle - 1;
        }
        public static void SagMenuGoster(this MouseEventArgs e, PopupMenu sagMenu)
        {
            if (e.Button != MouseButtons.Right) return;
            sagMenu.ShowPopup(Control.MousePosition);
        }
        public static List<string> YazicilariListele()
        {
            return PrinterSettings.InstalledPrinters.Cast<string>().ToList();//bilgisayarda olan yazıcıları gösterecek
        }

        public static string DefaultYazici()
        {
            var settings = new PrinterSettings();
            return settings.PrinterName;
        }

        public static void RefreshDataSource(this GridView tablo)
        {
            var source = tablo.DataController.ListSource.Cast<IBaseHareketEntity>().ToList();
            if (!source.Any(x => x.Delete)) return;
            var rowHandle = tablo.FocusedRowHandle;

            tablo.CustomRowFilter += Tablo_CustomRowFilter;
            tablo.RefreshData();
            tablo.CustomRowFilter -= Tablo_CustomRowFilter;
            tablo.RowFocus(rowHandle);

            void Tablo_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
            {
                var entity = source[e.ListSourceRow];
                if (entity == null) return;

                if (!entity.Delete) return;
                e.Visible = false;
                e.Handled = true;
            }

        }

        public static BindingList<T> ToBindingList<T>(this IEnumerable<BaseHareketEntity> list)
        {
            return new BindingList<T>((IList<T>)list);
        }

    }
}
