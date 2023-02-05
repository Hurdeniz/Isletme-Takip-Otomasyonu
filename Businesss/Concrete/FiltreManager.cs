using Businesss.Abstract.Base;
using Entitiess.Concrete;
using Model.Enums;
using System.Windows.Forms;

namespace Businesss.Concrete
{
    public class FiltreManager : BaseGenelBll<Filtre>, IBaseCommonBll
    {
        public FiltreManager() : base(KartTuru.Filtre) { }

        public FiltreManager(Control ctrl) : base(ctrl, KartTuru.Filtre) { }
    }
}
