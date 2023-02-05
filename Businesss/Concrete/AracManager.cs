using Businesss.Abstract.Base;
using Businesss.Abstract.Interfaces;
using Entitiess.Concrete;
using Model.Enums;
using System.Windows.Forms;

namespace Businesss.Concrete
{
    public class AracManager : BaseGenelBll<Arac>, IBaseGenelBll, IBaseCommonBll
    {
        public AracManager() : base(KartTuru.Arac) { }

        public AracManager(Control ctrl) : base(ctrl, KartTuru.Arac) { }
    }
}
