using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tehtava_1();
            //Console.WriteLine(LaskeIka(new DateTime(1996, 12, 3)));
            Tehtava_2();
        }

        static void Tehtava_1()
        {
            Muuntaja muuntaja = new Muuntaja();
            muuntaja.LisaaMuunnos(new Muunnos('ä', 'a'));
            muuntaja.LisaaMuunnos(new Muunnos('Ä', 'A'));
            muuntaja.LisaaMuunnos(new Muunnos('å', 'a'));
            muuntaja.LisaaMuunnos(new Muunnos('Å', 'a'));
            muuntaja.LisaaMuunnos(new Muunnos('ö', 'o'));
            muuntaja.LisaaMuunnos(new Muunnos('Ö', 'O'));

            Console.Write("Anna teksti: ");
            Console.WriteLine($"Skandit pois: {muuntaja.Muunna(Console.ReadLine())}");
        }

        static void Tehtava_2()
        {
            List<Presidentti> pressat = new List<Presidentti>();
            pressat.Add(new Presidentti()
            { Nimi = "Ståhlberg, Kaarlo Juho", SyntymaAika = new DateTime(1865, 1, 28), VirkaAlkuPvm = new DateTime(1919, 7, 26), VirkaLoppuPvm = new DateTime(1925, 3, 2) });
            pressat.Add(new Presidentti()
            { Nimi = "Relander, Lauri Kristian", SyntymaAika = new DateTime(1883, 5, 31), VirkaAlkuPvm = new DateTime(1925, 3, 2), VirkaLoppuPvm = new DateTime(1931, 3, 2) });
            pressat.Add(new Presidentti()
            { Nimi = "Svinhufvud, Pehr Evind", SyntymaAika = new DateTime(1861, 12, 15), VirkaAlkuPvm = new DateTime(1931, 3, 2), VirkaLoppuPvm = new DateTime(1937, 3, 2) });
            pressat.Add(new Presidentti()
            { Nimi = "Kallio, Köysti", SyntymaAika = new DateTime(1873, 4, 10), VirkaAlkuPvm = new DateTime(1937, 3, 1), VirkaLoppuPvm = new DateTime(1940, 12, 19) });
            pressat.Add(new Presidentti()
            { Nimi = "Ryti, Risto Heikki", SyntymaAika = new DateTime(1889, 2, 3), VirkaAlkuPvm = new DateTime(1940, 12, 19), VirkaLoppuPvm = new DateTime(1944, 8, 4) });
            pressat.Add(new Presidentti()
            { Nimi = "Mannerhein, Carl Gustav Emil", SyntymaAika = new DateTime(1867, 6, 4), VirkaAlkuPvm = new DateTime(1944, 8, 4), VirkaLoppuPvm = new DateTime(1946, 3, 11) });
            pressat.Add(new Presidentti()
            { Nimi = "Paasikivi, Juho Kusti", SyntymaAika = new DateTime(1870, 3, 27), VirkaAlkuPvm = new DateTime(1946, 3, 11), VirkaLoppuPvm = new DateTime(1956, 3, 1) });
            pressat.Add(new Presidentti()
            { Nimi = "Kekkonen, Urho Kaleva", SyntymaAika = new DateTime(1900, 9, 3), VirkaAlkuPvm = new DateTime(1956, 3, 1), VirkaLoppuPvm = new DateTime(1982, 1, 27) });
            pressat.Add(new Presidentti()
            { Nimi = "Koivisto, Mauno Henrik", SyntymaAika = new DateTime(1923, 11, 25), VirkaAlkuPvm = new DateTime(1982, 1, 27), VirkaLoppuPvm = new DateTime(1994, 3, 1) });
            pressat.Add(new Presidentti()
            { Nimi = "Ahtisaari, Martti Oiva Kalevi", SyntymaAika = new DateTime(1937, 6, 23), VirkaAlkuPvm = new DateTime(1994, 3, 1), VirkaLoppuPvm = new DateTime(2000, 3, 1) });
            pressat.Add(new Presidentti()
            { Nimi = "Halonen, Tarja Kaarina", SyntymaAika = new DateTime(1943, 12, 24), VirkaAlkuPvm = new DateTime(2000, 3, 1), VirkaLoppuPvm = new DateTime(2012, 3, 1) });
            pressat.Add(new Presidentti()
            { Nimi = "Niinistö, Sauli Väinämö", SyntymaAika = new DateTime(1948, 8, 24), VirkaAlkuPvm = new DateTime(2012, 3, 1), VirkaLoppuPvm = new DateTime(2018, 3, 1) });

            Console.Write("Anna päiväys: ");
            string paivays;
            while (!string.IsNullOrEmpty(paivays = Console.ReadLine()))
            {
                DateTime annettuPaivays;
                Presidentti pressa = null;
                if(DateTime.TryParse(paivays, out annettuPaivays))
                {
                    for (int i = 0; i < pressat.Count; i++)
                    {
                        if (annettuPaivays.Ticks > pressat[i].VirkaAlkuPvm.Ticks && annettuPaivays.Ticks < pressat[i].VirkaLoppuPvm.Ticks)
                        {
                            pressa = pressat[i];
                            break;
                        }
                    }
                }
                if (pressa == null)
                    Console.WriteLine("Ei presidenttiä");
                else
                {
                    Console.WriteLine("{0} {1}, {2}-vuotias", pressa.Nimi, pressa.VirkaKausi, LaskeIka(pressa.SyntymaAika, annettuPaivays));
                }
                Console.Write("Anna päiväys: ");
            }
        }

        public static int LaskeIka(DateTime syntymaPaiva, DateTime referenssi = default(DateTime))
        {
            DateTime loppuPvm = (referenssi == default(DateTime)) ? DateTime.Now : referenssi;
            int ika = loppuPvm.Year - syntymaPaiva.Year;
            if (loppuPvm < syntymaPaiva.AddYears(ika)) ika--;

            return (ika);
        }
    }
}
