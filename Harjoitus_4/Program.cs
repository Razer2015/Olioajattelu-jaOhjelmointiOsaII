using System;

namespace Harjoitus_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Noppa
            Console.WriteLine("Tehtävä 1 | Noppa\r\n");
            Noppa noppa = new Noppa();
            int heitot = 0;
            while (true)
            {
                noppa.Heita();
                Console.WriteLine("Nopan silmäluku: {0}", noppa.NaytaLukema());
                heitot += noppa.NaytaLukema();
                Console.Write("Heitetaanko viela (kyllä/ei)? ");
                if (Console.ReadLine().Equals("ei", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Heittojen määrä on {0}.", noppa.NaytaHeittojenMaara());
                    Console.WriteLine("Heittojen keskiarvo on {0}.", (heitot / noppa.NaytaHeittojenMaara()));
                    break;
                }
            }

            // Hissi
            Console.WriteLine("\r\nTehtävä 2 | Hissi\r\n");
            int maxKerros;
            while (true)
            {
                Console.Write("Anna hissin kerrosten määrä: ");
                if (int.TryParse(Console.ReadLine(), out maxKerros))
                    break;
            }

            Hissi hissi = new Hissi(maxKerros);
            hissi.NaytaKerrokset();
            while (true)
            {
                Console.Write("Anna kerros: ");
                int kerros;
                if (int.TryParse(Console.ReadLine(), out kerros))
                {
                    hissi.Siirry(kerros);
                    if (kerros.Equals(1))
                        break;
                }
            }
        }
    }
}
