using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml;


namespace Windows.UI.Abstract.Functions
{
    public static class FileFunctions
    {
        public static void FormSablonKaydet(this string sablonAdi, int left, int top, int width, int height, FormWindowState windowsState)
        {
            try
            {  // Şablon Kalsörü Yoksa Onu Oluştur
                if (!Directory.Exists(Application.StartupPath + @"\Şablon Dosyaları"))
                    Directory.CreateDirectory(Application.StartupPath + @"\Şablon Dosyaları");

                var settings = new XmlWriterSettings { Indent = true }; //Girinti oluşturmasına izin ver
                var writer = XmlWriter.Create(Application.StartupPath + $@"\Şablon Dosyaları\{sablonAdi}_location.xml", settings); //Xml dosyası oluşturma.
                writer.WriteStartDocument();
                writer.WriteComment("Hürdeniz Yener Tarafından Oluşturuldu.");
                writer.WriteStartElement("Tablo");
                writer.WriteStartElement("Location");
                writer.WriteAttributeString("Left", left.ToString());//sol mesafesi 0 index
                writer.WriteAttributeString("Top", top.ToString());//üst mesafesi 1 index
                writer.WriteEndElement();//bundan önceki elemti kapat.

                writer.WriteStartElement("FormSize");
                if (windowsState == FormWindowState.Maximized)
                {
                    //Eğer From Tam Ekransa Boyutları Kaydetme (-1 se tam ekran olarak aç)
                    writer.WriteAttributeString("Width", "-1");
                    writer.WriteAttributeString("Height", "-1");
                }
                else
                {
                    writer.WriteAttributeString("Width", width.ToString());
                    writer.WriteAttributeString("Height", height.ToString());

                }

                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();

            }
            catch (Exception ex)
            {
                Messages.HataMesaji(ex.Message);
            }
        }

        public static void FormSablonYukle(this string sablonAdi, XtraForm frm)
        {
            var list = new List<string>();

            try
            {
                //Xml Dosyası Varsa (kontrol)
                if (File.Exists(Application.StartupPath + $@"\Şablon Dosyaları\{sablonAdi}_location.xml"))
                {
                    var reader = XmlReader.Create(Application.StartupPath + $@"\Şablon Dosyaları\{sablonAdi}_location.xml");
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Location")
                        {
                            list.Add(reader.GetAttribute(0));// locationun left ve top ekle
                            list.Add(reader.GetAttribute(1));
                        }
                        else if (reader.NodeType == XmlNodeType.Element && reader.Name == "FormSize")
                        {
                            list.Add(reader.GetAttribute(0));// Fromsize left ve top ekle
                            list.Add(reader.GetAttribute(1));
                        }


                    }
                    reader.Close();
                    reader.Dispose();
                }
            }
            catch (Exception ex)
            {

                Messages.HataMesaji(ex.Message);
            }
            if (list.Count <= 0) return;

            frm.Location = new System.Drawing.Point(int.Parse(list[0]), int.Parse(list[1]));//konum (left top)

            // eğer her ikiside -1 se formu tam ekran aç // değilse yeni bir boyut ver 
            if (list[2] == "-1" && list[3] == "-1")
                frm.WindowState = FormWindowState.Maximized;
            else
                frm.Size = new System.Drawing.Size(int.Parse(list[2]), int.Parse(list[3]));//size (width heigth)
        }

        public static void TabloSablonKaydet(this GridView tablo, string sablonAdi)
        {
            try
            {
                tablo.ClearColumnsFilter();//Filtre varsa temizler
                if (!Directory.Exists(Application.StartupPath + @"\Şablon Dosyaları"))
                    Directory.CreateDirectory(Application.StartupPath + @"\Şablon Dosyaları");

                tablo.SaveLayoutToXml(Application.StartupPath + $@"\Şablon Dosyaları\{sablonAdi}.xml");

            }
            catch (Exception ex)
            {

                Messages.HataMesaji(ex.Message);
            }

        }

        public static void TabloSablonYukle(this GridView tablo, string sablonAdi)
        {
            try
            {
                if (File.Exists(Application.StartupPath + $@"\Şablon Dosyaları\{sablonAdi}.xml"))
                    tablo.RestoreLayoutFromXml(Application.StartupPath + $@"\Şablon Dosyaları\{sablonAdi}.xml");

            }
            catch (Exception ex)
            {

                Messages.HataMesaji(ex.Message);
            }

        }

        public static void TabloDisariAktar(this GridView tablo, DosyaTuru dosyaTuru, string dosyaFormati, string excelSayfaAdi = null)
        {
            if (Messages.TabloExportMesaj(dosyaFormati) != DialogResult.Yes) return; // gönder tıklandıgında mesaj veriyoruz.

            if (!Directory.Exists(Application.StartupPath + @"\Temp"))// kontrol
                Directory.CreateDirectory(Application.StartupPath + @"\Temp");//eğer temp adında dosya varsa oraya kaydet yoksa oluştur

            var dosyaAdi = Guid.NewGuid().ToString();//yeni bir dosya adı
            var filePath = $@"{Application.StartupPath}\Temp\{dosyaAdi}";// Dosya Yolu

            switch (dosyaTuru)
            {
                case DosyaTuru.ExcelStandart:
                    {
                        var opt = new XlsxExportOptionsEx
                        {
                            ExportType = DevExpress.Export.ExportType.Default,
                            SheetName = excelSayfaAdi,
                            TextExportMode = TextExportMode.Text
                        };

                        filePath = filePath + ".Xlsx";
                        tablo.ExportToXlsx(filePath, opt);
                    }
                    break;
                case DosyaTuru.ExcelFormatli:
                    {
                        var opt = new XlsxExportOptionsEx
                        {
                            ExportType = DevExpress.Export.ExportType.WYSIWYG,
                            SheetName = excelSayfaAdi,
                            TextExportMode = TextExportMode.Text
                        };

                        filePath = filePath + ".Xlsx";
                        tablo.ExportToXlsx(filePath, opt);
                    }
                    break;
                case DosyaTuru.ExcelFormatsiz:
                    {
                        var opt = new CsvExportOptionsEx
                        {
                            ExportType = DevExpress.Export.ExportType.Default,
                            TextExportMode = TextExportMode.Text
                        };

                        filePath = filePath + ".Csv";
                        tablo.ExportToCsv(filePath, opt);
                    }
                    break;
                case DosyaTuru.WordDosyasi:
                    {
                        filePath = filePath + ".Rtf";
                        tablo.ExportToRtf(filePath);
                    }
                    break;
                case DosyaTuru.PdfDosyasi:
                    {
                        filePath = filePath + ".Pdf";
                        tablo.ExportToPdf(filePath);
                    }
                    break;
                case DosyaTuru.TxtDosyasi:
                    {
                        var opt = new TextExportOptions
                        {
                            TextExportMode = TextExportMode.Text
                        };

                        filePath = filePath + ".Txt";
                        tablo.ExportToText(filePath, opt);
                    }
                    break;

            }

            if (!File.Exists(filePath))
            {
                Messages.HataMesaji("Tablo Verileri Dosyaya Aktarılamadı.");
                return;
            }
            Process.Start(filePath);//oluşan dosyayı aç


        }
    }
}
