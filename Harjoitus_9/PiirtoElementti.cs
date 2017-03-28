using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_9
{
    class PiirtoElementti
    {
        public Piste Sijainti { get; set; }

        public PiirtoElementti(Piste sijainti)
        {
            this.Sijainti = sijainti;
        }

        public override string ToString()
        {
            return ($"sijainti: ({Sijainti.X}, {Sijainti.Y})");
        }

        public virtual void Piirra()
        {
            Console.WriteLine("Piirretään PiirtoElementti ...");
        }
    }
}
