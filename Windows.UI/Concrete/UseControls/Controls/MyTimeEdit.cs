using DevExpress.Utils;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;
using Windows.UI.Abstract.Interfaces;

namespace Windows.UI.Concrete.UseControls.Controls
{
    [ToolboxItem(true)]
    public class MyTimeEdit : TimeEdit, IStatusBarKisaYol
    {
        public MyTimeEdit()
        {
            //Focuslanınca arka plan değişirtirme
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            //null değer olmaması
            Properties.AllowNullInput = DefaultBoolean.False;
            //texlerin ortada yazılması
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
    
        }

        public string StatusBarKisayol { get; set; } = "F4 :";
        public string StatusBarKisayolAciklama { get; set; } = "Saat Seçiniz";
        public string StatusBarAciklama { get; set; } 

    }
}
