using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_9
{
    class Viiva : PiirtoElementti
    {
        public Piste LoppuPiste { get; set; }

        public Viiva(Piste alkupiste, Piste loppupiste)
            : base(alkupiste)
        {
            this.LoppuPiste = loppupiste;
        }

        public override string ToString()
        {
            return ($"alkupiste: ({Sijainti.X}, {Sijainti.Y}), loppupiste: ({LoppuPiste.X}, {LoppuPiste.Y})");
        }

        public override void Piirra()
        {
            Console.WriteLine("Piirretään Viiva ...");
        }
    }
}
