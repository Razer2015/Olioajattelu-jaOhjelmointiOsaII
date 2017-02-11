using System;

namespace Harjoitus_4
{
    /// <summary>
    /// Noppa olio
    /// </summary>
    class Noppa
    {
        private int _lukema;
        private int _heittoLkm;
        static Random r = new Random();

        /// <summary>
        /// Konstruktori
        /// </summary>
        public Noppa()
        {
            this._lukema = -1;
            this._heittoLkm = 0;
        }

        /// <summary>
        /// Heitä noppaa
        /// </summary>
        public void Heita()
        {
            this._lukema = r.Next(1, 7);
            this._heittoLkm++;
        }

        /// <summary>
        /// Palauttaa nopan arvon int -muuttujana
        /// </summary>
        /// <returns></returns>
        public int NaytaLukema()
        {
            return (this._lukema);
        }

        /// <summary>
        /// Palauttaa heittojen määrän int -muuttujana
        /// </summary>
        /// <returns></returns>
        public int NaytaHeittojenMaara()
        {
            return (this._heittoLkm);
        }
    }
}
