using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_6
{
    class Koulutusohjelma
    {
        public int Id { get; set; }
        public string Nimi { get; set; }
        public string Tutkinto { get; set; }
        public int Laajuus { get; set; }
        public Oppilaitos Oppilaitos { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Koulutusohjelma()
        {

        }

        /// <summary>
        /// Palauttaa Koulutusohjelma luokan Nimi, arvon
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return (this.Nimi);
        }
    }
}
