using Businesss.Abstract.Base;
using Businesss.Abstract.Interfaces;
using Entitiess.Concrete;
using Model.Enums;
using System.Windows.Forms;

namespace Businesss.Concrete
{
    public class SoforManager : BaseGenelBll<Sofor>, IBaseGenelBll, IBaseCommonBll
    {
        public SoforManager() : base(KartTuru.Sofor) { }

        public SoforManager(Control ctrl) : base(ctrl, KartTuru.Sofor) { }
    }
}
