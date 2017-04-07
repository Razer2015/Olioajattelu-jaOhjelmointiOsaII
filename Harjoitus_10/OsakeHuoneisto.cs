using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_10
{
    class OsakeHuoneisto : MyyntiKohde
    {
        public int Kerros { get; set; }
        public double YhtioVastike { get; set; }

        string KohdeId
        {
            get
            {
                if (string.IsNullOrEmpty(this._kohdeId))
                    return ("N/A");
                else
                    return (this._kohdeId);
            }
            set { this._kohdeId = value; }
        }

        Osoite Osoite { get { return (this._osoite); } set { this._osoite = value; } }
        int RakennusVuosi { get { return (this._rakennusVuosi); } set { this._rakennusVuosi = value; } }
        double Hinta { get { return (this._arvo); } set { this._arvo = value; } }

        public OsakeHuoneisto(Osoite osoite)
            : base(osoite)
        {
            this.KohdeId = "";
        }

        public override void TulostaTiedot()
        {
            Console.WriteLine("Osakehuoneisto\nkohde: {0}\nosoite: {1}\nrakennusvuosi: {2}\nhinta: {3}\nkerros: {4}\nyhtiövastike: {5}",
                this.KohdeId, this.Osoite.ToString(), this.RakennusVuosi, Math.Round(this.Hinta, 2),
                this.Kerros, this.YhtioVastike.ToString("0.##") + " / kk");
        }
    }
}
