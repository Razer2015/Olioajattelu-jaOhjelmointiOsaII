using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_6
{
    interface IPari<T>
    {
        T A { get; set; }
        T B { get; set; }
    }
}
