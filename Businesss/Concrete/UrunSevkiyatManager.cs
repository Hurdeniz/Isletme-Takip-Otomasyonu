using Businesss.Abstract.Base;
using Businesss.Abstract.Interfaces;
using Entitiess.Concrete;
using Model.Enums;
using System.Windows.Forms;

namespace Businesss.Concrete
{
    public class UrunSevkiyatManager : BaseGenelBll<UrunSevkiyat>, IBaseGenelBll, IBaseCommonBll
    {
        public UrunSevkiyatManager() : base(KartTuru.UrunSevkiyat) { }

        public UrunSevkiyatManager(Control ctrl) : base(ctrl, KartTuru.UrunSevkiyat) { }
    }
}
