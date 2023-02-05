using DevExpress.XtraEditors;
using System.ComponentModel;
using Windows.UI.Abstract.Interfaces;

namespace Windows.UI.Concrete.UseControls.Controls
{
    [ToolboxItem(true)]
    public class MyFilterControl: FilterControl, ISatusBarAciklama
    {
        public MyFilterControl()
        {
            //gruplama yaparken ıcon resmı acma
            ShowGroupCommandsIcon = true;
        }

        public string StatusBarAciklama { get; set; } = "Filtre Metni Giriniz.";
    }
}
