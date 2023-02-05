using Businesss.Abstract.Base;
using Businesss.Abstract.Interfaces;
using Entitiess.Concrete;
using Model.Enums;
using System.Windows.Forms;

namespace Businesss.Concrete
{
    public class IsletmeSahibiManager : BaseGenelBll<IsletmeSahibi>, IBaseGenelBll, IBaseCommonBll
    {
        public IsletmeSahibiManager() : base(KartTuru.IsletmeSahibi) { }

        public IsletmeSahibiManager(Control ctrl) : base(ctrl, KartTuru.IsletmeSahibi) { }
    }
}
