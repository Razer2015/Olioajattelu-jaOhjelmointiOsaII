using Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_8
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo cultInfo = CultureInfo.CurrentCulture;
            int weekNumNow = cultInfo.Calendar.GetWeekOfYear(new DateTime(2017, 1, 1),
                                 cultInfo.DateTimeFormat.CalendarWeekRule,
                                     cultInfo.DateTimeFormat.FirstDayOfWeek);

            var result1 = Paivays.VuodenViikot(2017);
            var result2 = Paivays.VuodenPaivaykset(2017);
            var result3 = Viikko.TeeViikot(1, 2009, 5);
        }
    }
}
