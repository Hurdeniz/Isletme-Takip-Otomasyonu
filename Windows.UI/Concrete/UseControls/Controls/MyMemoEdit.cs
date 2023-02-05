using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;
using Windows.UI.Abstract.Interfaces;

namespace Windows.UI.Concrete.UseControls.Controls
{
    [ToolboxItem(true)]
    public class MyMemoEdit: MemoEdit, ISatusBarAciklama
    {
        public MyMemoEdit()
        {
            //Focuslanınca arka plan değişirtirme
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            //sınırlandırma
            Properties.MaxLength = 500;
        }
        //Entere basınca index sırasına göre bir sonraki indexteki controle focuslanma
        public override bool EnterMoveNextControl { get; set; } = true;

        //butonu olmayan kontroller için açıklama olacak sadece
        public string StatusBarAciklama { get; set; } = "Açıklama Giriniz.";
    }
}
