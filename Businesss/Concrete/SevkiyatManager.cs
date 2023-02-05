using Businesss.Abstract.Base;
using Businesss.Abstract.Interfaces;
using Entitiess.Concrete;
using Model.Enums;
using System.Windows.Forms;

namespace Businesss.Concrete
{
    public class SevkiyatManager : BaseGenelBll<Sevkiyat>, IBaseGenelBll, IBaseCommonBll
    {
        public SevkiyatManager() : base(KartTuru.Sevkiyat) { }

        public SevkiyatManager(Control ctrl) : base(ctrl, KartTuru.Sevkiyat) { }
      
    }

}
