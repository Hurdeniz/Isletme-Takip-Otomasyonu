using DevExpress.XtraEditors;
using System;
using DevExpress.XtraEditors.Controls;
using System.Drawing;
using Windows.UI.Abstract.Interfaces;
using System.ComponentModel;

namespace Windows.UI.Concrete.UseControls.Controls
{
    [ToolboxItem(true)]
    public class MyButtonEdit:ButtonEdit ,IStatusBarKisaYol
    {
        public MyButtonEdit()
        {
            //Button editin text kısmına yazı yazılmaz
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            //Focuslanınca arka plan değişirtirme
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
        }

        //Entere basınca index sırasına göre bir sonraki indexteki controle focuslanma
        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get; set; }

        public string StatusBarKisayol { get; set; } = "F4 :";

        public string StatusBarKisayolAciklama { get; set; }

        #region Event
        private long? _id;

        [Browsable(false)] //properties de gösterilmesin 
        public long? Id
        {
            // => return değeri görür
            get { return _id; }
            set
            {
                var oldValue = _id;
                var newValue = value;

                if (newValue.HasValue && oldValue.HasValue && newValue == oldValue) return;
                _id = value;
                IdChanged(this, new IdChangedEventArgs(oldValue, newValue));
                EnableChange(this, EventArgs.Empty);
            } 
          

        }

        //= delegate { } null a düşemez
        public event EventHandler<IdChangedEventArgs> IdChanged = delegate { };
        public event EventHandler EnableChange = delegate { };

        #endregion

    }

    public class IdChangedEventArgs : EventArgs
    {
        public IdChangedEventArgs(long? oldValue, long? newValue)
        {
            oldValue = oldValue; // önceki değer
            newValue = newValue;
        }

        public long? OldValue { get; }

        public long? NewValue { get; }
    }
}
