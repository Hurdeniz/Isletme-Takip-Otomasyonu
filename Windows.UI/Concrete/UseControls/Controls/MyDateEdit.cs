using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using System.ComponentModel;
using System.Drawing;
using Windows.UI.Abstract.Interfaces;

namespace Windows.UI.Concrete.UseControls.Controls
{
    [ToolboxItem(true)]
    public class MyDateEdit : DateEdit, IStatusBarKisaYol
    {
        public MyDateEdit()
        {
            //Focuslanınca arka plan değişirtirme
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            //null değer olmaması
            Properties.AllowNullInput = DefaultBoolean.False;
            //texlerin ortada yazılması
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            //tarih kısmında gun ay yıl seklinde sıralama gecişleri
            Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
        }
        //Entere basınca index sırasına göre bir sonraki indexteki controle focuslanma
        public override bool EnterMoveNextControl { get; set; } = true;

        //butonu olan kontroller için hem acıklama hem kısayol olacak
        public string StatusBarKisayol { get; set; } = "F4 :";

        public string StatusBarKisayolAciklama { get; set; } = "Tarih Seçiniz";

        public string StatusBarAciklama { get; set; }
    }
}
