using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;
using Windows.UI.Abstract.Interfaces;

namespace Windows.UI.Concrete.UseControls.Controls
{
    [ToolboxItem(true)]
    public class MyTextEdit :TextEdit , ISatusBarAciklama
    {
        public MyTextEdit()
        {

            //Focuslanınca arka plan değişirtirme
            Properties.AppearanceFocused.BackColor = Color.LightCyan;

            // Karakter sayısı sınırlandırma
            Properties.MaxLength = 50;
        }
        //Entere basınca index sırasına göre bir sonraki indexteki controle geçiş
        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get; set; }
    }
}
