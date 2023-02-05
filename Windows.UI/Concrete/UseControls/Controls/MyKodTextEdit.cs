using DevExpress.Utils;
using System.ComponentModel;
using System.Drawing;

namespace Windows.UI.Concrete.UseControls.Controls
{
    [ToolboxItem(true)]
    public class MyKodTextEdit : MyTextEdit
    {
        public MyKodTextEdit()
        {
            //Focuslanınca arka plan değişirtirme
            Properties.Appearance.BackColor = Color.PaleGoldenrod;
            //textin ortada yazması
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            //sınırlandırma
            Properties.MaxLength = 20;
            StatusBarAciklama = "Lütfen Kod Giriniz.";
        }
    }
}
