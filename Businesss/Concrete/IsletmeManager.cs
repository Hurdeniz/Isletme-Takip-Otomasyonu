using Businesss.Abstract.Base;
using Businesss.Abstract.Interfaces;
using Businesss.Concrete;
using Entities.Abstract.Base;
using Entities.Concrete;
using Entitiess.Dto;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Business.Concrete
{
    public class IsletmeManager : BaseGenelBll<Isletme>, IBaseGenelBll, IBaseCommonBll
    {
        public IsletmeManager() : base(KartTuru.Isletme) { }

        public IsletmeManager(Control ctrl) : base(ctrl, KartTuru.Isletme) { }

        public override BaseEntity Single(Expression<Func<Isletme, bool>> filter)
        {
            return BaseSingle(filter, x => new IsletmeS
            {
                Id = x.Id,
                Kod = x.Kod,
                IsletmeAdi = x.IsletmeAdi,
                IsletmeSahibiId = x.IsletmeSahibiId,
                IsletmeSahibiAdi = x.IsletmeSahibi.AdiSoyadi,
                IsletmeKullaniciKisiId = x.IsletmeKullaniciKisiId,
                IsletmeKullaniciKisiAdiSoyadi = x.IsletmeKullaniciKisi.KullaniciKisiAdiSoyadi,
                GrupKodId = x.GrupKodId,
                GrupKodAdi = x.GrupKod.GrupKodAdi,
                KayitTarihi = x.KayitTarihi,
                Kapasite = x.Kapasite,
                HayvanSayisi = x.HayvanSayisi,
                PompaId = x.PompaId,
                PompaAdi = x.Pompa.PompaAdi,
                IlId = x.IlId,
                IlAdi = x.Il.IlAdi,
                IlceId = x.IlceId,
                IlceAdi = x.Ilce.IlceAdi,
                Adres = x.Adres,
                Aciklama = x.Aciklama,
                Durum = x.Durum

            });
        }

        public override IEnumerable<BaseEntity> list(Expression<Func<Isletme, bool>> filter)
        {
            return BaseList(filter, x => new IsletmeL
            {
                Id = x.Id,
                Kod = x.Kod,
                IsletmeAdi = x.IsletmeAdi,
                IsletmeSahibiAdi = x.IsletmeSahibi.AdiSoyadi,
                IsletmeSahibiTelefon = x.IsletmeSahibi.Telefon,
                IsletmeKullaniciKisiAdiSoyadi = x.IsletmeKullaniciKisi.KullaniciKisiAdiSoyadi,
                IsletmeKullaniciKisiTelefon = x.IsletmeKullaniciKisi.KullaniciKisiTelefon,
                KayitTarihi = x.KayitTarihi,
                GrupKodAdi = x.GrupKod.GrupKodAdi,
                Kapasite = x.Kapasite,
                HayvanSayisi = x.HayvanSayisi,
                PompaAdi = x.Pompa.PompaAdi,
                PompaCesiti = x.Pompa.PompaCesiti,
                IlAdi = x.Il.IlAdi,
                IlceAdi = x.Ilce.IlceAdi,
                Adres = x.Adres,
                Aciklama = x.Aciklama
            }).OrderBy(x => x.Kod).ToList();
        }

    }
}
