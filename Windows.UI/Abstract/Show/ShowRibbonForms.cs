﻿using DevExpress.XtraBars.Ribbon;
using System;

namespace Windows.UI.Abstract.Show
{
    public class ShowRibbonForms<TForm> where TForm : RibbonForm
    {
        public static void ShowForm(bool dialog, params object[] prm)
        {
            var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm);
            if (dialog)
                using (frm)
                    frm.ShowDialog();
            else
                frm.Show();
        }
    }
}
