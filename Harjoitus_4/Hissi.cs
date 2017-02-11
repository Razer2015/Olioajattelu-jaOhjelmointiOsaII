using System;

namespace Harjoitus_4
{
    /// <summary>
    /// Hissi olio
    /// </summary>
    class Hissi
    {
        private bool _ovetAuki;
        private int _kerros;
        private int _maxKerros;

        #region Constructor
        /// <summary>
        /// Tee uusi hissi olio seuraavilla parametreillä
        /// </summary>
        /// <param name="kerroksia">Kuinka monta kerrosta on.</param>
        public Hissi(int kerroksia)
        {
            this._ovetAuki = false;
            this._kerros = 1;
            this._maxKerros = kerroksia;
        } 
        #endregion

        #region Siirtyminen
        /// <summary>
        /// Siirrä hissiä, joko ylös tai alas
        /// </summary>
        /// <param name="kerros">Kerros, johon hissiä siirretään.</param>
        public void Siirry(int kerros)
        {
            if (kerros > this._kerros)
                SiirryYlos(kerros);
            else if (kerros < this._kerros)
                SiirryAlas(kerros);
        }

        /// <summary>
        /// Siirtää hissiä ylöspäin
        /// </summary>
        /// <param name="kerros">Kerros, johon hissiä siirretään.</param>
        private void SiirryYlos(int kerros)
        {
            if (kerros > this._kerros && kerros <= this._maxKerros && kerros >= 0)
            {
                SuljeOvet();
                for (int i = this._kerros; i < kerros; i++)
                {
                    _kerros++;
                    NaytaKerrokset();
                }
                AvaaOvet();
            }
        }

        /// <summary>
        /// Siirrä hissiä alaspäin
        /// </summary>
        /// <param name="kerros">Kerros, johon hissiä siirretään.</param>
        private void SiirryAlas(int kerros)
        {
            if (kerros < this._kerros && kerros <= this._maxKerros && kerros >= 0)
            {
                SuljeOvet();
                for (int i = this._kerros; i > kerros; i--)
                {
                    _kerros--;
                    NaytaKerrokset();
                }
                AvaaOvet();
            }
        }
        #endregion

        #region Ovet
        /// <summary>
        /// Sulkee hissin ovet
        /// </summary>
        private void SuljeOvet()
        {
            Console.WriteLine("Ovet ovat kiinni.");
            this._ovetAuki = false;
        }

        /// <summary>
        /// Avaa hissin ovet
        /// </summary>
        private void AvaaOvet()
        {
            Console.WriteLine("Ovet ovat auki.");
            this._ovetAuki = true;
        }
        #endregion

        #region Näytä Kerrokset
        /// <summary>
        /// Näyttää hissin nykyisen kerroksen
        /// </summary>
        public void NaytaKerrokset()
        {
            Console.Write("Kerrokset:");
            for (int i = 1; i <= this._maxKerros; i++)
            {
                if (i == this._kerros)
                    Console.Write(" [{0}]", i);
                else
                    Console.Write(" {0}", i);
            }
            Console.WriteLine();
        } 
        #endregion
    }
}
