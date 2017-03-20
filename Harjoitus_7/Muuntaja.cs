using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_7
{
    class Muuntaja
    {
        List<Muunnos> _muunnokset;

        public Muuntaja()
        {
            this._muunnokset = new List<Muunnos>();
        }

        public void LisaaMuunnos(Muunnos muunnos)
        {
            this._muunnokset.Add(muunnos);
        }

        public string Muunna(string muunna)
        {
            foreach (var item in this._muunnokset)
            {
                muunna = item.Muunna(muunna);
            }
            return (muunna);
        }
    }
}
