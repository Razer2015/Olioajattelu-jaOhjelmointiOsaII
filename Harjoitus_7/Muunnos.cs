using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_7
{
    class Muunnos
    {
        char _muunnettava, _muunnettu;

        public Muunnos(char muunnettava, char muunnettu)
        {
            this._muunnettava = muunnettava;
            this._muunnettu = muunnettu;
        }

        public string Muunna(string muunnettava)
        {
            return (muunnettava.Replace(this._muunnettava, this._muunnettu));
        }
    }
}
