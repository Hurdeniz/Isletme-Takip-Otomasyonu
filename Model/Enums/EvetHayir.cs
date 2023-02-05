using System.ComponentModel;

namespace Model.Enums
{
    public enum EvetHayir :byte
    {
        [Description("Evet")]
        Evet = 1,
        [Description("Hayır")]
        Hayir = 2
    }
}
