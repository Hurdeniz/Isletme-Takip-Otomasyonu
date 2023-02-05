using Businesss.Abstract.Base;
using Businesss.Abstract.Interfaces;
using Entities.Concrete;
using Model.Enums;
using System.Windows.Forms;

namespace Businesss.Concrete
{
    public class IlManager : BaseGenelBll<Il>, IBaseGenelBll, IBaseCommonBll
    {
        public IlManager( ) : base(KartTuru.Il) { }
    
        public IlManager(Control ctrl) : base(ctrl, KartTuru.Il) { } 


    }
}
