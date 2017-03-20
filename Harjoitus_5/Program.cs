using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;

namespace Harjoitus_5
{
    class Program
    {
        static void Main(string[] args) {
            int[] kokonaisluvut = new int[2];
            double desimaaliluku = 0;
            DateTime dt = default(DateTime);
            Paivays paivays = null;

            bool stopLooping = false;
            do {
                stopLooping = IntTesti(out kokonaisluvut[0], 5, 10);
            } while (!stopLooping);
            stopLooping = false;
            do {
                stopLooping = IntTesti(out kokonaisluvut[1], int.MinValue, int.MaxValue);
            } while (!stopLooping);

            stopLooping = false;
            do {
                stopLooping = DoubleTesti(out desimaaliluku, tarkkuus: 1);
            } while (!stopLooping);

            stopLooping = false;
            do {
                stopLooping = DateTimeTesti(out dt, out paivays);
            } while (!stopLooping);

            Console.WriteLine("\r\nSyötit seuraavat: kokonaisluvut {0} ja {1}, desimaaliluvun {2} sekä päivämäärän {3} {4}",
                kokonaisluvut[0],
                kokonaisluvut[1],
                desimaaliluku,
                $"{dt.ToShortDateString()} (DateTime).",
                $"{paivays.ToString(PaivaysMuoto.Suomi)} (Paivays).");
            Console.ReadLine();
        }

        static bool IntTesti(out int result, int min = int.MinValue, int max = int.MaxValue) {
            try {
                result = Helpers.Syote.Kokonaisluku($"Anna kokonaisluku{((min != int.MinValue || max != int.MaxValue) ? $" väliltä {min}-{max}" : "")}: ", min, max);
                return (true);
            }
            catch (ApplicationException appException) {
                Console.WriteLine(appException.Message);
                result = -1;
                return (false);
            }
        }

        static bool DoubleTesti(out double result, int tarkkuus = -1) {
            try {
                result = Helpers.Syote.Desimaaliluku($"Anna desimaaliluku: ", tarkkuus);
                return (true);
            }
            catch (ApplicationException appException) {
                Console.WriteLine(appException.Message);
                result = -1;
                return (false);
            }
        }

        static bool DateTimeTesti(out DateTime result, out Paivays paivays) {
            try {
                result = Helpers.Syote.Paivays($"Anna päivämäärä: ");
                paivays = Helpers.Paivays.Parse(result);
                return (true);
            }
            catch (ApplicationException appException) {
                Console.WriteLine(appException.Message);
                result = default(DateTime);
                paivays = null;
                return (false);
            }
        }
    }
}
