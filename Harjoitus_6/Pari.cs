using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_6
{
    class Pari<T> : IPari<T>
    {
        T _A;
        T _B;

        public T A
        {
            get { return (this._A); }
            set { this._A = value; }
        }

        public T B
        {
            get { return (this._B); }
            set { this._B = value; }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public Pari(T a, T b)
        {
            this.A = a;
            this.B = b;
        }

        /// <summary>
        /// Additional constructor
        /// </summary>
        public Pari()
        {
            this.A = default(T);
            this.B = default(T);
        }

        /// <summary>
        /// Palauttaa yhdistetyn A ja B ominaisuuksien arvon
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return A + ", " + B;
        }


    }
}
