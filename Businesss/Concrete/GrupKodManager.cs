using Businesss.Abstract.Base;
using Entitiess.Concrete;
using Model.Enums;
using System.Windows.Forms;

namespace Businesss.Concrete
{
    public class GrupKodManager : BaseGenelBll<GrupKod>, IBaseCommonBll
    {
        public GrupKodManager() : base(KartTuru.Grup) { }

        public GrupKodManager(Control ctrl) : base(ctrl, KartTuru.Grup) { }
    }
}
