using System;

namespace Harjoitus_1
{
    class Program
    {
        #region Main
        static void Main(string[] args)
        {
            Console.WriteLine("#### Tehtävä 1 ####\r\n");
            TulostaKolmio(4);

            Console.WriteLine("\r\n#### Tehtävä 2 ####\r\nJouluKuusi(4):");
            JouluKuusi(4);
            Console.WriteLine("JouluKuusi(10):");
            JouluKuusi(10);

            Console.WriteLine("\r\n#### Tehtävä 3 ####\r\nViivanPituus(-3, 3, 4, 1):");
            Console.WriteLine(ViivanPituus(-3, 3, 4, 1));

            Console.WriteLine("\r\n#### Tehtävä 4 ####\r\nImplikaatio(p, q):");
            Console.WriteLine($"1, 1 = {Implikaatio(Convert.ToBoolean(1), true)}");
            Console.WriteLine($"1, 0 = {Implikaatio(true, false)}");
            Console.WriteLine($"0, 1 = {Implikaatio(false, true)}");
            Console.WriteLine($"0, 0 = {Implikaatio(false, false)}");

            Console.WriteLine("\r\n#### Tehtävä 5 ####\r\nKokonaisluku 1: 5\r\nKokonaisluku 2: 3\r\nKokonaisluku 3: 4");
            Console.WriteLine($"{(Jarjestyksessa(5, 3, 4) ? "Luvut ovat järjestyksessä." : "Luvut eivät ole järjestyksessä.")}");
            Console.WriteLine($"Suurin luvuista on {Suurin(5, 3, 4)}.");

            Console.ReadLine();
        } 
        #endregion

        #region Tehtävä 1
        static void TulostaTyhjaa(int maara)
        {
            for (int i = 0; i < maara; i++)
                Console.Write(" ");
        }

        static void TulostaTahtia(int lkm)
        {
            for (int i = 0; i < lkm; i++)
                Console.Write("*");
            //Console.Write("\r\n"); 
            // tai
            Console.WriteLine("");
        }

        static void TulostaKolmio(int koko)
        {
            for (int i = 0; i < koko; i++)
            {
                TulostaTyhjaa(koko - (i+1));
                TulostaTahtia((i + 1));
            }
        }
        #endregion

        #region Tehtävä 2
        static void JouluKuusi(int korkeus)
        {
            // Tulosta kuusi
            int nextPrint = 1;
            for (int i = 0; i < korkeus; i++)
            {
                TulostaTyhjaa(korkeus - (i+1));
                TulostaTahtia(nextPrint);
                nextPrint += 2;
            }
            // Tulosta jalka
            for (int i = 0; i < 2; i++)
            {
                TulostaTyhjaa(korkeus - 2);
                TulostaTahtia(3);
            }
        }
        #endregion

        #region Tehtävä 3
        static double ViivanPituus(double x, double y, double x2, double y2)
        {
            return (Math.Sqrt(Math.Pow(Math.Abs(y - y2), 2) + Math.Pow(Math.Abs(x - x2), 2)));
        }
        #endregion

        #region Tehtävä 4
        static bool Implikaatio(bool p, bool q)
        {
            return (!p | q);
        }
        #endregion

        #region Tehtävä 5
        static bool Jarjestyksessa(int a, int b, int c)
        {
            return (a < b && b < c);
        }

        static double Suurin(double val1, double val2, double val3)
        {
            return (Math.Max(val1, Math.Max(val2, val3)));
        }
        #endregion
    }
}
