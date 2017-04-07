using System;
using System.Globalization;

namespace Harjoitus_10
{
    class OsakeHuoneisto : MyyntiKohde
    {
        public int Kerros { get; set; }
        public double YhtioVastike { get; set; }

        public string KohdeId
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

        public Osoite Osoite { get { return (this._osoite); } set { this._osoite = value; } }
        public int RakennusVuosi { get { return (this._rakennusVuosi); } set { this._rakennusVuosi = value; } }
        public double Hinta { get { return (this._arvo); } set { this._arvo = value; } }

        public OsakeHuoneisto(Osoite osoite)
            : base(osoite)
        {
            this.KohdeId = "";
        }

        public override void TulostaTiedot()
        {
            Console.WriteLine("Osakehuoneisto\nkohde: {0}\nosoite: {1}\nrakennusvuosi: {2}\nhinta: {3}\nkerros: {4}\nyhtiövastike: {5}",
                this.KohdeId, this.Osoite.ToString(), this.RakennusVuosi, this.Hinta.ToString("#.00", CultureInfo.CurrentCulture),
                this.Kerros, this.YhtioVastike.ToString("#.00", CultureInfo.CurrentCulture) + " / kk");
        }
    }
}
