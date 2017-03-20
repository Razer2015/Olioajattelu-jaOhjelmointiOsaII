using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class Viikko
    {
        public int Numero { get; set; }
        public int Vuosi { get; set; }
        public Paivays[] Paivat { get; set; }

        public Viikko(int nro, int vuosi)
        {
            this.Numero = nro;
            this.Vuosi = vuosi;
            this.Paivat = new Paivays[7];
        }

        public static Viikko[] TeeViikot(int nro, int vuosi, int lkm)
        {
            Viikko[] viikot = new Viikko[lkm];
            Array.Copy(Paivays.VuodenViikot(vuosi), nro - 1, viikot, 0, lkm);
            return (viikot);
        }
    }
}
