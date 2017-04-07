using Helpers;
using System;

namespace Harjoitus_10
{
    class Program
    {
        static void Main(string[] args)
        {
            OmaKotiTalo omaKotiTalo = null;
            OsakeHuoneisto osakeHuoneisto = null;

            Console.WriteLine("Myyntikohde\n1. Omakotitalo\n2. Osakehuoneisto");
            var tyyppi = Syote.KokonaislukuPakottaen("Valinta: ", 1, 2);

            if (tyyppi.Equals(1)) // OmaKotiTalo
            {
                var katuOsoite = Syote.Merkkijono("Anna katuosoite: ");
                var postiNumero = Syote.Merkkijono("Anna postinumero: ");
                var postiToimiPaikka = Syote.Merkkijono("Anna postitoimipaikka: ");
                var rakennusVuosi = Syote.KokonaislukuPakottaen("Rakennusvuosi: ", 0, 2017);
                var hinta = Syote.DesimaalilukuPakottaen("Hinta: ");
                var omaTontti = (Syote.MerkkijonoPakottaen("Onko oma tontti (kyllä/ei): ", new string[] { "kyllä", "ei"}).ToLower().Equals("kyllä")) ? true : false;
                var tontinKoko = Syote.DesimaalilukuPakottaen("Tontin koko (m2): ");
                omaKotiTalo = new OmaKotiTalo(new Osoite() { Katuosoite = katuOsoite, Postinro = postiNumero, Postitoimipaikka = postiToimiPaikka });
                omaKotiTalo.RakennusVuosi = rakennusVuosi;
                omaKotiTalo.Hinta = hinta;
                omaKotiTalo.OmaTontti = omaTontti;
                omaKotiTalo.TontinKoko = tontinKoko;
            }
            else // OsakeHuoneisto
            {
                var katuOsoite = Syote.Merkkijono("Anna katuosoite: ");
                var postiNumero = Syote.Merkkijono("Anna postinumero: ");
                var postiToimiPaikka = Syote.Merkkijono("Anna postitoimipaikka: ");
                var rakennusVuosi = Syote.KokonaislukuPakottaen("Rakennusvuosi: ", 0, 2017);
                var hinta = Syote.DesimaalilukuPakottaen("Hinta: ");
                var kerros = Syote.KokonaislukuPakottaen("Kerros: ", 1, int.MaxValue);
                var yhtioVastike = Syote.DesimaalilukuPakottaen("Yhtiövastike (kk): ");
                osakeHuoneisto = new OsakeHuoneisto(new Osoite() { Katuosoite = katuOsoite, Postinro = postiNumero, Postitoimipaikka = postiToimiPaikka });
                osakeHuoneisto.RakennusVuosi = rakennusVuosi;
                osakeHuoneisto.Hinta = hinta;
                osakeHuoneisto.Kerros = kerros;
                osakeHuoneisto.YhtioVastike = yhtioVastike;
            }

            Console.WriteLine(); // Extra väli
            if (omaKotiTalo != null)
                omaKotiTalo.TulostaTiedot();
            if (osakeHuoneisto != null)
                osakeHuoneisto.TulostaTiedot();

            Console.ReadLine();
        }
    }
}
