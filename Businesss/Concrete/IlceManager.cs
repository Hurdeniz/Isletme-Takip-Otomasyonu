using Businesss.Abstract.Base;
using Entities.Concrete;
using Model.Enums;
using System.Windows.Forms;

namespace Businesss.Concrete
{
    public class IlceManager : BaseGenelBll<Ilce>, IBaseCommonBll
    {
        public IlceManager() : base(KartTuru.Ilce) { }

        public IlceManager(Control ctrl) : base(ctrl, KartTuru.Ilce) { }
    }
}
