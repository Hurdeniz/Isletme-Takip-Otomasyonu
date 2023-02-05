using DevExpress.Utils;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;
using Windows.UI.Abstract.Interfaces;

namespace Windows.UI.Concrete.UseControls.Controls
{
    public class MyToogleSwitch: ToggleSwitch, ISatusBarAciklama
    {
        [ToolboxItem(true)]
        public MyToogleSwitch()
        {

            Name = "tglDurum";
            //kapalıyken yazması gereken
            Properties.OffText = "Pasif";
            // acıkken yazması gereken
            Properties.OnText = "Aktif";
            //yükseklik özelliği otomatık olarak ayarlanmasın
            Properties.AutoHeight = false;
            // genişlik özelliği acık 
            Properties.AutoWidth = true;
            // textin toggle switc sağ mı solda mı gözükmesi
            Properties.GlyphAlignment = HorzAlignment.Far; //solda gözüksün
            //texte renk verme
            Properties.Appearance.ForeColor = Color.Maroon;
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get; set; } = "Kartın Kullanım Durumunu Seçiniz.";
    }
}
