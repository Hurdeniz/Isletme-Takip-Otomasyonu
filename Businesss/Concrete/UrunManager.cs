using Businesss.Abstract.Base;
using Businesss.Abstract.Interfaces;
using Entitiess.Concrete;
using Model.Enums;
using System.Windows.Forms;

namespace Businesss.Concrete
{
    public class UrunManager : BaseGenelBll<Urun>, IBaseGenelBll, IBaseCommonBll
    {
        public UrunManager() : base(KartTuru.Urun) { }

        public UrunManager(Control ctrl) : base(ctrl, KartTuru.Urun) { }
    }
}
