using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_6
{
    class Oppilaitos
    {
        public int Id { get; set; }
        public string Nimi { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Oppilaitos()
        {

        }

        /// <summary>
        /// Palauttaa Oppilaitos luokan Nimi, arvon
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return (this.Nimi);
        }
    }
}
