using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_9
{
    class Lintu
    {
        //Kentät 
        private int _siivenPituus;
        protected double _aivojenKoko;
        private bool _osaakoLentaa;
        //Ominaisuudet 
        public int SiivenPituus
        {
            get
            {
                return _siivenPituus;
            }
            set
            {
                _siivenPituus = value;
            }
        }
        public virtual double AivojenKoko
        {
            get
            {
                return _aivojenKoko;
            }
            set
            {
                _aivojenKoko = value;
            }
        }
        public bool OsaakoLentaa
        {
            get
            {
                return _osaakoLentaa;
            }
            set
            {
                _osaakoLentaa = value;
            }
        }
        //Konstruktorit 
        public Lintu()
        {
            _siivenPituus = 11;
            _aivojenKoko = 100;
            _osaakoLentaa = false;
        }
    }

}
