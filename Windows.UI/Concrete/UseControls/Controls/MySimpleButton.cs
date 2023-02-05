using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;
using Windows.UI.Abstract.Interfaces;

namespace Windows.UI.Concrete.UseControls.Controls
{
    [ToolboxItem(true)]
    public class MySimpleButton: SimpleButton, ISatusBarAciklama
    {
        public MySimpleButton()
        {

            //Yazı Tipi Rengi
            Appearance.ForeColor = Color.Maroon;
        }
        public string StatusBarAciklama { get; set; }
    }
}
