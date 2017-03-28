using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Neliö");
            var x = Helpers.Syote.KokonaislukuPakottaen("Anna sijainnin x-koordinaatti: ");
            var y = Helpers.Syote.KokonaislukuPakottaen("Anna sijainnin y-koordinaatti: ");
            var sarma = Helpers.Syote.KokonaislukuPakottaen("Anna neliön särmn pituus: ");

            Console.WriteLine("Viiva");
            var a_x = Helpers.Syote.KokonaislukuPakottaen("Anna alkupisteen x-koordinaatti: ");
            var a_y = Helpers.Syote.KokonaislukuPakottaen("Anna alkupisteen y-koordinaatti: ");
            var l_x = Helpers.Syote.KokonaislukuPakottaen("Anna loppupisteen x-koordinaatti: ");
            var l_y = Helpers.Syote.KokonaislukuPakottaen("Anna loppupisteen y-koordinaatti: ");

            var nelio = new Nelio(new Piste(x, y), sarma);
            var viiva = new Viiva(new Piste(a_x, a_y), new Piste(l_x, l_y));

            Console.WriteLine("Neliö: {0}", nelio.ToString());
            Console.WriteLine("Viiva: {0}", viiva.ToString());

            Console.WriteLine("Piirretään oliot");
            nelio.Piirra();
            viiva.Piirra();

            Console.ReadLine();
        }

        void tehtava_1()
        {
            Lintu isolintu = new Lintu();
            Pelikaani petteri = new Pelikaani();

            // TEHTÄVÄN a-KOHDAN SISÄLTÖ TÄHÄN
            //a.
            /* Ei toimi, koska protected */ //petteri._aivojenKoko = 3.2;
            //b.
            /* Ei toimi, koska private */ //petteri._siivenPituus = 7;
            //c.
            petteri.OsaakoLentaa = true;
            //d.
            /* Ei toimi, koska private */ //petteri._ika = 3;
            //e.
            petteri.NokanKoko = 4;
            //f.
            petteri.SiivenPituus = 7;
        }
    }
}
