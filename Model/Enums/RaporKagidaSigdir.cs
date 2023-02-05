using System.ComponentModel;

namespace Model.Enums
{
    public enum RaporKagidaSigdir : byte
    {
        [Description("Sütünları Daraltarak Sığdır")]
        SutunlariDaraltarakSigdir = 1,
        [Description("Yazı Boyutunu Küçülterek Sığdır")]
        YaziBoyutunuKuculterekSigdir = 2,
        [Description("İşlem Yapma")]
        IslemYapma = 3
    }
}
