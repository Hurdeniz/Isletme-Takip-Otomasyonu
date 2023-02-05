using DevExpress.Utils;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;
using Windows.UI.Abstract.Interfaces;

namespace Windows.UI.Concrete.UseControls.Controls
{
    [ToolboxItem(true)]
    public class MySpinEdit : SpinEdit, ISatusBarAciklama
    {
        public MySpinEdit()
        {
            //Focuslanınca arka plan değişirtirme
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            //alanın boş geçilmememsi-null değer olmaması
            Properties.AllowNullInput = DefaultBoolean.False;
            //değerin basamaklanmamamsı 
            Properties.EditMask = "d";
            //texlerin ortada yazılması
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
        }
        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get; set; }
    }
}
