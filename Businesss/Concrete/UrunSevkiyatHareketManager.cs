using Businesss.Abstract.Base;
using Businesss.Abstract.Interfaces;
using DataAccess.Concrete.Contexts;
using Entitiess.Abstract.Base;
using Entitiess.Concrete;
using Entitiess.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Businesss.Concrete
{
    public class UrunSevkiyatHareketManager : BaseHareketBll<UrunSevkiyatHareket, IsletmeTakipContext>, IBaseHareketSelectBll<UrunSevkiyatHareket>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<UrunSevkiyatHareket, bool>> filter)
        {
            return List(filter, x => new UrunSevkiyatHareketL
            {
                Id = x.Id,
                UrunSevkiyatId = x.UrunSevkiyatId,
                UrunSevkiyatNo = x.UrunSevkiyat.Kod,
                UrunSevkiyatTarih = x.UrunSevkiyat.SevkiyatTarih,
                UrunSevkiyatSaat = x.UrunSevkiyat.Saat,
                UrunId = x.UrunId,
                UrunNo=x.Urun.Kod,
                UrunAdi = x.Urun.UrunAdi,
                SoforId = x.SoforId,
                SoforAdiSoyadi = x.Sofor.SoforAdiSoyadi,
                AracId = x.AracId,
                AracPlaka = x.Arac.AracPlaka,
                Aciklama = x.Aciklama,

            }).ToList();
        }
    }
}
