using Entities.Abstract.Base;
using Entities.Abstract.Interfaces;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Windows.UI.Abstract.BaseForms;

namespace Windows.UI.Abstract.Show
{
    public class ShowListForm<TForm> where TForm : BaseListForm
    {
        public static void ShowListForms(KartTuru kartTuru)
        {
            //yetki kontrolu

            var frm = (TForm)Activator.CreateInstance(typeof(TForm));
            frm.MdiParent = Form.ActiveForm;

            frm.Yukle();
            frm.Show();
        }

        public static void ShowListForms(KartTuru kartTuru, params object[] prm)
        {
            //yetki kontrolu

            var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm);
            frm.MdiParent = Form.ActiveForm;

            frm.Yukle();
            frm.Show();
        }

        public static BaseEntity ShowDialogListForm(KartTuru kartTuru, long? seciliGelecekId, params object[] prm)
        {
            // yetki kontrolü

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.SeciliGelecekId = seciliGelecekId;
                frm.Yukle();
                frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntity : null;
            }
        }

        public static IEnumerable<IBaseEntity> ShowDialogListForm(KartTuru kartTuru, IList<long> ListeDisiTutulacakKayitlar, bool multiSelect, params object[] prm)
        {
            //Yetki Kontrolü

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.ListeDisiTutulacakKayitlar = ListeDisiTutulacakKayitlar;
                frm.MultiSelect = multiSelect;
                frm.Yukle();
                frm.RowSelect = new Functions.SelectRowFunctions(frm.Tablo);
                if (frm.EklenebilecekEntityVar)
                    frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntities : null;
            }

        }
    }
}
