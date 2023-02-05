using Entities.Abstract.Interfaces;
using Model.Enums;

namespace Entitiess.Concrete
{
    public class DokumParametreleri : IBaseEntity
    {
        public string RaporBaslik { get; set; }

        public EvetHayir BaslikEkle { get; set; }

        public RaporKagidaSigdir RaporKagidaSigdir { get; set; }

        public YazdirmaYonu YazdirmaYonu { get; set; }

        public EvetHayir YatayCizgileriGoster { get; set; }

        public EvetHayir DikeyCizgileriGoster { get; set; }

        public EvetHayir SutunBasliklariGoster { get; set; }

        public string YaziciAdi { get; set; }

        public int YazdirilacakAdet { get; set; }

        public DokumSekli DokumSekli { get; set; }
    }
}
