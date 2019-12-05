using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp
{
    abstract class Locuinta
    {
        public int Numar { get; set; }
        public int Etaj { get; set; }
        public int NrBalcoane { get; set; }
        public int Suprafata { get; set; }
        public bool AC { get; set; }
        public bool Priveliste { get; set; }
        public bool Gaz { get; set; }
        public bool UtilitatiSmart { get; set; }
        public int TotalCost { get; set; }
    }
}
