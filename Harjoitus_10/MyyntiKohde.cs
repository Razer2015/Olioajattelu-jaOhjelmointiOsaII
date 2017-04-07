using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_10
{
    abstract class MyyntiKohde
    {
        protected string _kohdeId;
        protected Osoite _osoite;
        protected int _rakennusVuosi;
        protected double _arvo;

        public MyyntiKohde(Osoite osoite)
        {
            this._osoite = osoite;
        }

        public abstract void TulostaTiedot();
    }
}
