using Businesss.Abstract.Base;
using Businesss.Abstract.Interfaces;
using DataAccess.Concrete.Contexts;
using Entities.Abstract.Base;
using Entitiess.Abstract.Base;
using Entitiess.Concrete;
using Entitiess.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Businesss.Concrete
{
    public class IsletmeSevkiyatManager : BaseHareketBll<IsletmeSevkiyat, IsletmeTakipContext>, IBaseHareketSelectBll<IsletmeSevkiyat>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<IsletmeSevkiyat, bool>> filter)
        {        
            return List(filter, x => new IsletmeSevkiyatL
            {
                Id = x.Id,
                SevkiyatId = x.SevkiyatId,
                SevkiyatNo = x.Sevkiyat.Kod,
                SevkiyatTarih = x.Sevkiyat.SevkiyatTarih,
                SevkiyatSaat=x.Sevkiyat.Saat,
                IsletmeId = x.IsletmeId,
                IsletmeNo = x.Isletme.Kod,
                IsletmeAdi = x.Isletme.IsletmeAdi,
                IsletmeSahibiAdi=x.Isletme.IsletmeSahibi.AdiSoyadi,
                IsletmeKullaniciKisi = x.IsletmeKullaniciKisi,
                Kapasite=x.Isletme.Kapasite,
                HayvanSayisi=x.Isletme.HayvanSayisi,
                PompaAdi=x.Isletme.Pompa.PompaAdi,
                PompaCesiti=x.Isletme.Pompa.PompaCesiti,
                IlAdi=x.Isletme.Il.IlAdi,
                IlceAdi=x.Isletme.Ilce.IlceAdi,
                Adres=x.Isletme.Adres,
                SoforId = x.SoforId,
                SoforAdiSoyadi = x.Sofor.SoforAdiSoyadi,
                AracId = x.AracId,
                AracPlaka = x.Arac.AracPlaka,
                AracSayisi = x.AracSayisi,               
                AracTipi = x.AracTipi,
                Jsb = x.Jsb,            
                Aciklama = x.Aciklama,

            }).ToList();
        }

        
    }
}
