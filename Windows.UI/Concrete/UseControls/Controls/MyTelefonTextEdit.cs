using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using System.ComponentModel;

namespace Windows.UI.Concrete.UseControls.Controls
{
    [ToolboxItem(true)]
    public class MyTelefonTextEdit:MyTextEdit
    {
        public MyTelefonTextEdit()
        {
            //texlerin ortada yazılması
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            //maske oluşturma
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"(\d?\d?\d?) \d?\d?\d? \d?\d? \d?\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;
            StatusBarAciklama = "Lütfen Telefon Numarası Giriniz.";
        }
    }
}
