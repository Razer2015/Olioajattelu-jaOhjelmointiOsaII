using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class Kalenteri
    {
        public string Nimi { get; set; }
        public Viikko[] Viikot { get; set; }

        public Kalenteri(string n)
        {
            this.Nimi = n;
        }

        public Kalenteri(string n, int alkunro, int alkuvuosi, int lkm) : this(n)
        {
            this.Viikot = Viikko.TeeViikot(alkunro, alkuvuosi, lkm);
        }
    }
}
