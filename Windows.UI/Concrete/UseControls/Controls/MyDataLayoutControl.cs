using DevExpress.XtraDataLayout;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Windows.UI.Concrete.UseControls.Controls
{
    public class MyDataLayoutControl: DataLayoutControl
    {
        [ToolboxItem(true)]
        public MyDataLayoutControl()
        {
            //belirlemiş oldugumuz index düzeninde hareket etmesi
            OptionsFocus.EnableAutoTabOrder = false;
        }

        protected override LayoutControlImplementor CreateILayoutControlImplementorCore()
        {
            return new MyLayoutControlImplementor(this);
        }
    }

    internal class MyLayoutControlImplementor : LayoutControlImplementor
    {
        public MyLayoutControlImplementor(ILayoutControlOwner controlOwner) : base(controlOwner)
        {
        }

        public override BaseLayoutItem CreateLayoutItem(LayoutGroup parent)
        {
            var item = base.CreateLayoutItem(parent);
            //sürükleyim bıraktıgımız caption renklerini değiştirme
            item.AppearanceItemCaption.ForeColor = Color.Maroon;
            return item;
        }

        public override LayoutGroup CreateLayoutGroup(LayoutGroup parent)
        {
            var grp = base.CreateLayoutGroup(parent);
            grp.LayoutMode = LayoutMode.Table;
            //sutun genişlik ayarlama
            grp.OptionsTableLayoutGroup.ColumnDefinitions[0].SizeType = SizeType.Absolute;
            grp.OptionsTableLayoutGroup.ColumnDefinitions[0].Width = 200;

            grp.OptionsTableLayoutGroup.ColumnDefinitions[1].SizeType = SizeType.Percent;
            grp.OptionsTableLayoutGroup.ColumnDefinitions[1].Width = 100;
            //yeni sutun ekleme
            grp.OptionsTableLayoutGroup.ColumnDefinitions.Add(new ColumnDefinition { SizeType = SizeType.Absolute, Width = 99 });

            // otomatik oluşturulan rowları silme
            grp.OptionsTableLayoutGroup.RowDefinitions.Clear();
            // yeni row oluşturma
            for (int i = 0; i < 9; i++)
            {
                grp.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition
                {
                    SizeType = SizeType.Absolute,
                    Height = 24
                });

                if (i + 1 != 9) continue;
                grp.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition
                {
                    SizeType = SizeType.Percent,
                    Height = 100

                });

            }

            return grp;
        }
    }
}
