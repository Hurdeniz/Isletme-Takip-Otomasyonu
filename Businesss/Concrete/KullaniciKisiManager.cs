using Businesss.Abstract.Base;
using Businesss.Abstract.Interfaces;
using Entitiess.Concrete;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Businesss.Concrete
{
    public class KullaniciKisiManager : BaseGenelBll<IsletmeKullaniciKisi>, IBaseGenelBll, IBaseCommonBll
    {
        public KullaniciKisiManager() : base(KartTuru.KullaniciKisi) { }

        public KullaniciKisiManager(Control ctrl) : base(ctrl, KartTuru.KullaniciKisi) { }
    }
}
