using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_9
{
    class Pelikaani : Lintu
    {
        //Kentät 
        private int _nokanKoko;
        private int _ika;
        //Ominaisuudet 
        public override double AivojenKoko
        {
            get
            {
                return _aivojenKoko;
            }
            set
            {
                _aivojenKoko = value * 2;
            }
        }
        public int NokanKoko
        {
            get
            {
                return _nokanKoko;
            }
            set
            {
                _nokanKoko = value;
            }
        }
        //Konstruktorit 
        public Pelikaani()
        {
            // TEHTÄVÄN b-KOHDAN SISÄLTÖ TÄHÄN
            //a.
            _aivojenKoko = 3.2;
            //b.
            /* Ei toimi, koska private */ //_siivenPituus = 7;
            //c.
            OsaakoLentaa = true;
            //d.
            _ika = 3;
            //e.
            _nokanKoko = 4;
            //f.
            AivojenKoko = 1.2;
            //g.
            SiivenPituus = 4;
            //h.
            /* Ei toimi, koska ei määritetty luokkaa */ //Lintu();
            //i.
            /* Ei toimi, koska base constructoria ei voi kutsua näin */ //base();
        }
    }
}
