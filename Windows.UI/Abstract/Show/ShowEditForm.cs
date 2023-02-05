using Entities.Abstract.Interfaces;
using Model.Enums;
using System;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Interfaces;


namespace Model.Show
{
    public class ShowEditForm <TForm> : IBaseFormShow where TForm : BaseEditForm
    {
        public long ShowDialogEditForm(KartTuru kartTuru, long id)//,params object[] prm)
        {
            //yetki kontrolü
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))
            {
                //ıd degeri 0 dan küçükse yeni kayıt gir
                frm.BaseIslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
                frm.Id = id;
                frm.Yukle();
                frm.ShowDialog();
                return frm.RefreshYapilacak ? frm.Id : 0;

            }
        }

        public static long ShowDialogEditForm(KartTuru kartTuru, long id, params object[] prm)
        {
            //yetki kontrolü
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                //ıd degeri 0 dan küçükse yeni kayıt gir
                frm.BaseIslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
                frm.Id = id;
                frm.Yukle();
                frm.ShowDialog();
                return frm.RefreshYapilacak ? frm.Id : 0;

            }
        }

        public static long ShowDialogEditForm(params object[] prm)
        {

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {

                frm.Yukle();
                frm.ShowDialog();
                return frm.RefreshYapilacak ? frm.Id : 0;

            }
        }

        public static T ShowDialogEditForm<T>(params object[] prm) where T : IBaseEntity
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.Yukle();
                frm.ShowDialog();
                return (T)frm.ReturnValue();
            }
        }

     
    }
}
