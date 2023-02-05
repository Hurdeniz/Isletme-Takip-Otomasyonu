using Businesss.Abstract.Base;
using Businesss.Abstract.Interfaces;
using Entities.Concrete;
using Model.Enums;
using System.Windows.Forms;

namespace Businesss.Concrete
{
    public class PompaManager : BaseGenelBll<Pompa>, IBaseGenelBll, IBaseCommonBll
    {
        public PompaManager() : base(KartTuru.Pompa) { }
       
        public PompaManager(Control ctrl ) : base(ctrl, KartTuru.Pompa) { }


    }
}
