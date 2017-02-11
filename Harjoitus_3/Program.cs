using System;

namespace Harjoitus_3
{
    enum ViikonPaiva
    {
        maanantai = 1,
        tiistai = 2,
        keskiviikko = 3,
        torstai = 4,
        perjantai = 5,
        lauantai = 6,
        sunnuntai = 7
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Tehtävä 1
            //int userInput = -1;
            //bool correctInput = false;
            //while (!correctInput)
            //{
            //    Console.Write("Anna luku väliltä 1 - 7: ");
            //    correctInput = int.TryParse(Console.ReadLine(), out userInput);
            //    if(!correctInput)
            //        Console.WriteLine("Syöte ei ole kokonaisluku.");
            //    else if(userInput < 1 || userInput > 7)
            //    {
            //        correctInput = false;
            //        Console.WriteLine("Lukua ei ole väliltä 1-7.");
            //    }
            //}
            //Console.WriteLine($"Lukua {userInput} vastaa päivän nimeä {(ViikonPaiva)userInput}."); 
            #endregion

            #region Tehtävä 2
            string hetu = null;
            do
            {
                hetu = LueHetu("Anna henkilötunnus: ");
            } while (hetu == null);
            Console.WriteLine($"Syötit henkilötunnuksen {hetu}.");
            #endregion
        }

        static string LueHetu(string kehote)
        {
            Console.Write(kehote);
            string hetu = Console.ReadLine();
            try
            {
                // Tarkasta pituus
                if (hetu.Length != 11)
                    throw new ApplicationException("Henkilötunnuksen pituus on virheellinen.");

                // Tarkasta päivämäärä
                string paiva = hetu.Substring(0, 2);
                string kuukausi = hetu.Substring(0, 2);
                string vuosiPartial = hetu.Substring(0, 2);
                string vuosi = 
                    (hetu[6].Equals('+') ? "18" : 
                    (hetu[6].Equals('-') ? "19" : 
                    (hetu[6].Equals('A') ? "20" : ""))) + vuosiPartial;
                if (vuosi.Length != 4)
                    throw new ApplicationException("Syntymäajan vuosisata on virheellinen.");

                DateTime synttari;
                if(!DateTime.TryParse($"{paiva}.{kuukausi}.{vuosi}", out synttari))
                    throw new ApplicationException("Syntymäaika on virheellinen.");

                // Tarkasta yksilönumero
                int yksilonumero = -1;
                string _yksilonumero = hetu.Substring(7, 3);
                if (!int.TryParse(_yksilonumero, out yksilonumero))
                    throw new ApplicationException("Yksilönumero ei ole numeerinen.");

                // Tarkasta tarkistemerkki
                char tarkisteMerkki = Tarkiste(int.Parse($"{paiva}{kuukausi}{vuosiPartial}{_yksilonumero}"));
                if (!tarkisteMerkki.Equals(hetu[10]))
                    throw new ApplicationException("Virheellinen tarkistemerkki.");
            }
            catch (ApplicationException exception)
            {
                Console.WriteLine(exception.Message);
                hetu = null;
            }
            return (hetu);
        }

        static char Tarkiste(int luku)
        {
            int jakojaannos = luku % 31;
            switch (jakojaannos)
            {
                case 0:
                    return ('0');
                case 1:
                    return ('1');
                case 2:
                    return ('2');
                case 3:
                    return ('3');
                case 4:
                    return ('4');
                case 5:
                    return ('5');
                case 6:
                    return ('6');
                case 7:
                    return ('7');
                case 8:
                    return ('8');
                case 9:
                    return ('9');
                case 10:
                    return ('A');
                case 11:
                    return ('B');
                case 12:
                    return ('C');
                case 13:
                    return ('D');
                case 14:
                    return ('E');
                case 15:
                    return ('F');
                case 16:
                    return ('H');
                case 17:
                    return ('J');
                case 18:
                    return ('K');
                case 19:
                    return ('L');
                case 20:
                    return ('M');
                case 21:
                    return ('N');
                case 22:
                    return ('P');
                case 23:
                    return ('R');
                case 24:
                    return ('S');
                case 25:
                    return ('T');
                case 26:
                    return ('U');
                case 27:
                    return ('V');
                case 28:
                    return ('W');
                case 29:
                    return ('X');
                case 30:
                    return ('Y');
                default:
                    return ('?');
            }
        }
    }
}
