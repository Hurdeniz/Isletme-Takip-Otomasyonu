using DevExpress.Utils;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;
using Windows.UI.Abstract.Interfaces;

namespace Windows.UI.Concrete.UseControls.Controls
{
    public class MyCalcEdit : CalcEdit, IStatusBarKisaYol
    {
        [ToolboxItem(true)]
        public MyCalcEdit()
        {
            //Focuslanınca arka plan değişirtirme
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            // Null İçermeyecek
            Properties.AllowNullInput = DefaultBoolean.False;
            //
            Properties.DisplayFormat.FormatType = FormatType.Numeric;
            Properties.DisplayFormat.FormatString = "n2";
            // Rakam Maskeleme (145.123.00)  (n2 yazarken sonuna 2 kurus aralarına nokta koyacak)
            Properties.EditMask = "n2";
        }
        //Entere basınca index sırasına göre bir sonraki indexteki controle focuslanma
        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarKisayol { get; set; } = "F4 :";
        public string StatusBarKisayolAciklama { get; set; } = "Hesap Makinesi";
        public string StatusBarAciklama { get; set; }
    }
}
