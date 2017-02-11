using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harjoitus_2
{
    class Program
    {
        static char[] hexChars = new char[]
        {
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
            'A', 'B', 'C', 'D', 'E', 'F', 'G' // G ei ole heksadesimaalisymboli
        };
        static bool[] enabledMethods = new bool[]
        {
            true, // Tehtävä 1
            true, // Tehtävä 2
            true, // Tehtävä 3_1
            true, // Tehtävä 3_2
            true, // Tehtävä 4
            true  // Tehtävä 5
        };
        static void Main(string[] args)
        {
            #region Tehtävä 1
            if (enabledMethods[0])
            {
                Console.WriteLine("#### Tehtävä 1 - Heksamerkit luvuiksi ####");
                for (int i = 0; i < hexChars.Length; i++)
                    Console.WriteLine($"{hexChars[i]} = {HeksamerkkiLukuna(hexChars[i])}");
            }
            #endregion

            #region Tehtävä 2
            if (enabledMethods[1])
            {
                Console.WriteLine("\r\n#### Tehtävä 2 - Palindromi tarkastus ####");
                while (true)
                {
                    Console.Write("Syötä teksti (exit to quit): ");
                    string input = Console.ReadLine();
                    if (input.Equals("exit", StringComparison.OrdinalIgnoreCase) || String.IsNullOrEmpty(input))
                        break;
                    else
                    {
                        if (!OnkoPalindromi(input))
                            Console.WriteLine("Ei ole palindromi.");
                        else
                            Console.WriteLine("On palindromi.");
                    }
                }
            }
            #endregion

            #region Tehtävä 3
            if (enabledMethods[2])
            {
                Console.WriteLine("\r\n#### Tehtävä 3 - Päivämäärän erottelu (Helpompi) ####");
                while (true)
                {
                    Console.Write("Anna päivämäärä (exit to quit): ");
                    string input = Console.ReadLine();
                    if (input.Equals("exit", StringComparison.OrdinalIgnoreCase) || String.IsNullOrEmpty(input))
                        break;
                    else
                    {
                        var output = PaivamaaraErottaja(input);
                        if (output != null)
                        {
                            Console.WriteLine("Päivämäärä eroteltuna:");
                            foreach (var kvp in output)
                            {
                                Console.WriteLine($"{kvp.Key} = {kvp.Value}");
                            }
                        }
                        else
                            Console.WriteLine("Ei ole kelvollinen päiväys.");
                    }
                }
            }

            if (enabledMethods[3])
            {
                Console.WriteLine("\r\n#### Tehtävä 3 - Päivämäärän erottelu (Vaikeampi) ####");
                while (true)
                {
                    Console.Write("Anna päivämäärä (exit to quit): ");
                    string input = Console.ReadLine();
                    if (input.Equals("exit", StringComparison.OrdinalIgnoreCase) || String.IsNullOrEmpty(input))
                        break;
                    else
                    {
                        PaivamaaraErottaja_Hankalampi(input);
                    }
                }
            }
            #endregion

            #region Tehtävä 4
            if (enabledMethods[4])
            {
                Console.WriteLine("\r\n#### Tehtävä 4 - Päivämäärä erottelija (Testillä) ####");
                while (true)
                {
                    Console.Write("Anna päivämäärä (exit to quit): ");
                    string input = Console.ReadLine();
                    if (input.Equals("exit", StringComparison.OrdinalIgnoreCase) || String.IsNullOrEmpty(input))
                        break;
                    else
                    {
                        PaivamaaraErottaja_Testilla(input);
                    }
                }
            }
            #endregion

            #region Tehtävä 5
            if (enabledMethods[5])
            {
                Console.WriteLine("\r\n#### Tehtävä 5 - Kehystys ja Harvaan tulostus ####");
                Console.Write("Anna teksti: ");
                string teksti = Console.ReadLine();
                Console.Write("Anna kehysmerkki: ");
                string kehysmerkki = Console.ReadLine();
                if (kehysmerkki.Length > 0)
                    TulostaKehystettyna(teksti, kehysmerkki[0]);
                TulostaHarvasti(teksti);
            }
            #endregion

            Console.WriteLine("\r\nKaikki tehtävät käyty läpi!");
            Console.ReadLine();
        }

        #region Tehtävä 1 Metodi
        static int HeksamerkkiLukuna(char hexChar)
        {
            int valOut = -1;
            if (int.TryParse(hexChar.ToString(), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.CurrentCulture, out valOut))
                return (valOut);
            else
                return (-1);
        }
        #endregion

        #region Tehtävä 2 Metodit
        static string PoistaValimerkit(string merkkijono)
        {
            StringBuilder sb = new StringBuilder(merkkijono);
            sb.Replace(" ", "");
            sb.Replace(".", "");
            sb.Replace(":", "");
            sb.Replace(";", "");
            sb.Replace(",", "");
            sb.Replace("!", "");
            sb.Replace("?", "");
            return (sb.ToString());
        }

        static string Kaanna(string merkkijono)
        {
            return (String.Join("", merkkijono.Reverse().ToArray()));
        }

        static bool OnkoPalindromi(string merkkijono)
        {
            merkkijono = PoistaValimerkit(merkkijono);
            string toCompare = Kaanna(merkkijono);

            if (merkkijono.Equals(toCompare))
                return (true);
            else
                return (false);
        }
        #endregion

        #region Tehtävä 3 Metodit
        static Dictionary<string, int> PaivamaaraErottaja(string paivamaara)
        {
            DateTime date;
            if (DateTime.TryParse(paivamaara, out date))
                return (new Dictionary<string, int>()
                {
                    { "Vuosi", date.Year },
                    { "Kuukausi", date.Month },
                    { "Päivä", date.Day }

                });
            else
                return (null);
        }
        static void PaivamaaraErottaja_Hankalampi(string paivamaara)
        {
            int ekaIndex = paivamaara.IndexOf('.');
            int vikaIndex = paivamaara.LastIndexOf('.');

            string vuosi = paivamaara.Substring(vikaIndex +1, 4);
            string kuukausi = paivamaara.Substring(ekaIndex + 1, (vikaIndex - (ekaIndex + 1)));
            string paiva = paivamaara.Substring(0, ekaIndex);

            Console.WriteLine("Päivämäärä eroteltuna:");
            Console.WriteLine($"Vuosi = {vuosi}");
            Console.WriteLine($"Kuukausi = {kuukausi}");
            Console.WriteLine($"Päivä = {paiva}");

            // Tai
            string[] result = paivamaara.Split('.');
            if(result.Length == 3)
            {
                Console.WriteLine("Päivämäärä eroteltuna:");
                Console.WriteLine($"Vuosi = {result[2]}");
                Console.WriteLine($"Kuukausi = {result[1]}");
                Console.WriteLine($"Päivä = {result[0]}");
            }
        }
        #endregion

        #region Tehtävä 4 Metodit
        static void PaivamaaraErottaja_Testilla(string paivamaara)
        {
            string[] result = paivamaara.Split('.');
            if (result.Length == 3)
            {
                if (OnkoPaivays(int.Parse(result[2]), int.Parse(result[1]), int.Parse(result[0])))
                {
                    Console.WriteLine("Päivämäärä eroteltuna:");
                    Console.WriteLine($"Vuosi = {result[2]}");
                    Console.WriteLine($"Kuukausi = {result[1]}");
                    Console.WriteLine($"Päivä = {result[0]}");
                }
                else
                    Console.WriteLine("Ei ole kelvollinen päiväys.");
            }
        }

        static bool OnkoKarkausvuosi(int vuosi)
        {
            if (((vuosi % 4) == 0 && (vuosi % 100) != 0) || (vuosi % 400) == 0)
                return (true);
            else
                return (false);
        }
        static bool OnkoPaivays(int vuosi, int kuukausi, int paiva)
        {
            if (vuosi < 1800 && vuosi > 2200)
                return (false);

            switch (kuukausi)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (paiva >= 1 && paiva <= 31)
                        return (true);
                    else
                        return (false);
                case 4:
                case 6:
                case 9:
                case 11:
                    if (paiva >= 1 && paiva <= 31)
                        return (true);
                    else
                        return (false);
                case 2:
                    if (!OnkoKarkausvuosi(vuosi))
                    {
                        if (paiva >= 1 && paiva <= 28)
                            return (true);
                        else
                            return (false);
                    }
                    else
                    {
                        if (paiva >= 1 && paiva <= 29)
                            return (true);
                        else
                            return (false);
                    }
                default:
                    return (false);
            }
        }
        #endregion

        #region Tehtävä 5 Metodit
        static void TulostaKehystettyna(string teksti, char merkki)
        {
            for (int i = 0; i < (teksti.Length + 4); i++)
                Console.Write(merkki);
            Console.WriteLine();
            Console.WriteLine($"{merkki} {teksti} {merkki}");
            for (int i = 0; i < (teksti.Length + 4); i++)
                Console.Write(merkki);
            Console.WriteLine();
        }

        static void TulostaHarvasti(string teksti)
        {
            for (int i = 0; i < teksti.Length; i++)
                Console.Write($"{teksti[i]} ");
            Console.WriteLine();
        }
        #endregion
    }
}
