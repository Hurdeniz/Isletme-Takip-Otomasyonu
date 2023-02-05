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
    public class UrunIsletmeManager : BaseGenelBll<UrunIsletme>, IBaseGenelBll, IBaseCommonBll
    {
        public UrunIsletmeManager() : base(KartTuru.UrunIsletme) { }

        public UrunIsletmeManager(Control ctrl) : base(ctrl, KartTuru.UrunIsletme) { }

        public override BaseEntity Single(Expression<Func<UrunIsletme, bool>> filter)
        {
            return BaseSingle(filter, x => new UrunIsletmeS
            {
                Id = x.Id,
                Kod = x.Kod,
                UrunIsletmeAdi = x.UrunIsletmeAdi,
                UrunIsletmeTelefon = x.UrunIsletmeTelefon,
                KayitTarihi = x.KayitTarihi,
                IlId = x.IlId,
                IlAdi = x.Il.IlAdi,
                IlceId = x.IlceId,
                IlceAdi = x.Ilce.IlceAdi,
                Adres = x.Adres,
                Aciklama = x.Aciklama,
                Durum = x.Durum

            });
        }

        public override IEnumerable<BaseEntity> list(Expression<Func<UrunIsletme, bool>> filter)
        {
            return BaseList(filter, x => new UrunIsletmeL
            {
                Id = x.Id,
                Kod = x.Kod,
                UrunIsletmeAdi = x.UrunIsletmeAdi,
                UrunIsletmeTelefon = x.UrunIsletmeTelefon,
                KayitTarihi = x.KayitTarihi,
                IlAdi = x.Il.IlAdi,
                IlceAdi = x.Ilce.IlceAdi,
                Adres = x.Adres,
                Aciklama = x.Aciklama
            }).OrderBy(x => x.Kod).ToList();
        }

    }
}
