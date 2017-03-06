using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;
namespace Harjoitus_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tehtävä 1:");
            Tehtava_1();
            Console.WriteLine("\r\nTehtävä 2:");
            Tehtava_2();
        }

        private static void Tehtava_1()
        {
            Oppilaitos oppilaitos = new Oppilaitos();
            do
            {
                try
                {
                    oppilaitos.Id = Syote.Kokonaisluku("Anna oppilaitoksen id: ", 1);
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine(e.Message + "\r\nMinimi on 1");
                    oppilaitos.Id = -1;
                }
            } while (oppilaitos.Id <= -1);
            oppilaitos.Nimi = Syote.Merkkijono("Anna oppilaitoksen nimi: ");

            Koulutusohjelma koulutusohjelma = new Koulutusohjelma();
            do
            {
                try
                {
                    koulutusohjelma.Id = Syote.Kokonaisluku("Anna koulutusohjelman id: ", 1);
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine(e.Message + "\r\nMinimi on 1");
                    koulutusohjelma.Id = -1;
                }
            } while (koulutusohjelma.Id <= -1);
            koulutusohjelma.Nimi = Syote.Merkkijono("Anna koulutusohjelman nimi: ");

            do
            {
                try
                {
                    koulutusohjelma.Laajuus = Syote.Kokonaisluku("Anna laajuus: ", 0);
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine(e.Message + "\r\nEi saa olla negatiivinen");
                    koulutusohjelma.Laajuus = -1;
                }
            } while (koulutusohjelma.Laajuus < 0);
            koulutusohjelma.Tutkinto = Syote.Merkkijono("Anna tutkinnon nimi: ");
            koulutusohjelma.Oppilaitos = oppilaitos;
            Console.WriteLine($"{koulutusohjelma.Oppilaitos.Nimi}, {koulutusohjelma.Nimi} {koulutusohjelma.Laajuus} op ({koulutusohjelma.Tutkinto})");
        }

        private static void Tehtava_2()
        {
            Pari<int> intPari = new Pari<int>() { A = 4, B = 7 };
            Pari<double> doublePari = new Pari<double>() { A = 3.6, B = 1.5 };
            Pari<string> stringPari = new Pari<string>() { A = "banaani", B = "omena" };

            Console.WriteLine(intPari.ToString());
            Console.WriteLine(doublePari.ToString());
            Console.WriteLine(stringPari.ToString());
        }
    }
}
