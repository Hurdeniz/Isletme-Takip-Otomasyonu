using Businesss.Abstract.Base;
using Businesss.Abstract.Interfaces;
using Entities.Abstract.Base;
using Entitiess.Concrete;
using Entitiess.Dto;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Businesss.Concrete
{
    public class KmTonajManager : BaseGenelBll<KmTonaj>, IBaseGenelBll, IBaseCommonBll
    {
        public KmTonajManager() : base(KartTuru.IsletmeKmTonaj) { }

        public KmTonajManager(Control ctrl) : base(ctrl, KartTuru.IsletmeKmTonaj) { }

        public override BaseEntity Single(Expression<Func<KmTonaj, bool>> filter)
        {
            return BaseSingle(filter, x => new KmTonajS
            {
                Id = x.Id,
                Kod = x.Kod,
                IsletmeNo = x.IsletmeNo,
                IsletmeAdi = x.IsletmeAdi,
                IsletmeSevkiyatNo = x.IsletmeSevkiyatNo,
                IsletmeSevkiyatTarihi = x.IsletmeSevkiyatTarihi,
                IsletmeSevkiyatId = x.IsletmeSevkiyatId,
                IsletmeId = x.IsletmeId,
                UrunSevkiyatNo = x.UrunSevkiyatNo,
                UrunSevkiyatTarihi = x.UrunSevkiyatTarihi,
                UrunSevkiyatHareketId = x.UrunSevkiyatHareketId,
                UrunId = x.UrunId,
                UrunAdi = x.UrunAdi,
                UrunNo = x.UrunNo,
                UrunIsletmeId = x.UrunIsletmeId,
                UrunIsletmeAdi = x.UrunIsletme.UrunIsletmeAdi,
                KmTonajTarih = x.KmTonajTarih,
                GirisSaat = x.GirisSaat,
                CikisSaat = x.CikisSaat,
                PhDegeri = x.PhDegeri,
                Nem = x.Nem,
                KmOrani = x.KmOrani,
                TonajMiktari = x.TonajMiktari,
                Aciklama = x.Aciklama,
                KayitTipi = x.KayitTipi,
                Durum = x.Durum

            });
        }

        public override IEnumerable<BaseEntity> list(Expression<Func<KmTonaj, bool>> filter)
        {
            return BaseList(filter, x => new KmTonajL
            {
                Id = x.Id,
                Kod = x.Kod,
                IsletmeNo = x.IsletmeNo,
                IsletmeAdi = x.IsletmeAdi,
                IsletmeSevkiyatNo = x.IsletmeSevkiyatNo,
                IsletmeSevkiyatTarih = x.IsletmeSevkiyatTarihi,
                UrunSevkiyatNo = x.UrunSevkiyatNo,
                UrunSevkiyatTarih = x.UrunSevkiyatTarihi,
                UrunNo = x.UrunNo,
                UrunAdi = x.UrunAdi,              
                UrunIsletmeAdi = x.UrunIsletme.UrunIsletmeAdi,
                KayitTarihi = x.KmTonajTarih,
                GirisSaat = x.GirisSaat,
                CikisSaat = x.CikisSaat,
                PhDegeri = x.PhDegeri,
                Nem = x.Nem,
                KmOrani = x.KmOrani,
                TonajMiktari = x.TonajMiktari,
                Aciklama = x.Aciklama
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
