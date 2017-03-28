using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_9
{
    class Nelio : PiirtoElementti
    {
        public int Sarma { get; set; }

        public Nelio(Piste sijainti, int sarma)
            : base(sijainti)
        {
            this.Sarma = sarma;
        }

        public override string ToString()
        {
            return ($"{base.ToString()}, sivun pituus: {Sarma}");
        }

        public override void Piirra()
        {
            Console.WriteLine("Piirretään Neliö ...");
        }
    }
}
