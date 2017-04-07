using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_10
{
    class OmaKotiTalo : MyyntiKohde
    {
        public bool OmaTontti { get; set; }
        public double TontinKoko { get; set; }

        public string KohdeId
        {
            get
            {
                if (string.IsNullOrEmpty(this._kohdeId))
                    return ("N/A");
                else
                    return (this._kohdeId);
            }
            set
            {
                this._kohdeId = value;
            }
        }

        public Osoite Osoite { get { return (this._osoite); } set { this._osoite = value; } }
        public int RakennusVuosi { get { return (this._rakennusVuosi); } set { this._rakennusVuosi = value; } }
        public double Hinta { get { return (this._arvo); } set { this._arvo = value; } }

        public OmaKotiTalo(Osoite osoite)
            : base(osoite)
        {
            this.KohdeId = "";
        }

        public override void TulostaTiedot()
        {
            Console.WriteLine("Omakotitalo\nkohde: {0}\nosoite: {1}\nrakennusvuosi: {2}\nhinta: {3}\noma tontti: {4}\ntontin koko: {5}", 
                this.KohdeId, this.Osoite.ToString(), this.RakennusVuosi, this.Hinta.ToString("0,##"), 
                ((this.OmaTontti) ? "kyllä" : "ei"), this.TontinKoko.ToString("0,##") + " m2");
        }
    }
}
