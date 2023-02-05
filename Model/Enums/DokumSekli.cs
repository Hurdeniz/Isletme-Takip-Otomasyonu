using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Enums
{
    public enum DokumSekli:byte
    {
        TabloBaslikOnizleme = 1,
        RaporBaslikOnizleme = 2,
        TabloYazdir = 3,
        RaporYazdir = 4
    }
}
