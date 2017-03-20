using System;
using System.Linq;

namespace Helpers
{
    public static class Syote
    {
        public static int Kokonaisluku(string kehote, int min = int.MinValue, int max = int.MaxValue)
        {
            Console.Write(kehote);
            int result;
            if (int.TryParse(Console.ReadLine(), out result))
                if (result >= min && result <= max)
                    return (result);

            throw new ApplicationException($"Syöte ei ole kelvollinen kokonaisluku.{((min != int.MinValue || max != int.MaxValue) ? $" Minimi on {min}. Maksimi on {max}." : "")}");
        }

        public static double Desimaaliluku(string kehote, int tarkkuus = -1)
        {
            Console.Write(kehote);
            double result;
            if (double.TryParse(Console.ReadLine(), out result))
            {
                if (tarkkuus < 0)
                    return (result);
                else
                    return (Math.Round(result, tarkkuus));
            }

            throw new ApplicationException("Syöte ei ole kelvollinen desimaaliluku.");
        }

        public static char Merkki(string kehote)
        {
            Console.Write(kehote);
            char result;
            if (char.TryParse(Console.ReadLine(), out result))
                return (result);

            throw new ApplicationException("Syöte ei ole kelvollinen merkki.");
        }

        public static string Merkkijono(string kehote)
        {
            Console.Write(kehote);
            return (Console.ReadLine());
        }

        public static char Merkki(string kehote, char[] merkkitaulukko)
        {
            Console.Write(kehote);
            char result;
            if (!char.TryParse(Console.ReadLine(), out result))
                throw new ApplicationException("Syöte ei ole kelvollinen merkki.");

            if (!merkkitaulukko.Contains(result))
                throw new ApplicationException($"Syöte ei ole kelvollinen merkki. Sallittuja merkkejä ovat {string.Join(", ", merkkitaulukko)}.");

            return (result);
        }

        public static string Merkkijono(string kehote, string[] merkkijonot, bool tasoherkkyys = false)
        {
            Console.Write(kehote);

            string result = Console.ReadLine();
            if (!tasoherkkyys && merkkijonot.Contains(result))
                return (result);
            else if (tasoherkkyys && merkkijonot.Contains(result, StringComparer.OrdinalIgnoreCase))
                return (result);
            else
                throw new ApplicationException($"Syöte ei ole kelvollinen merkki. Sallittuja syötteitä ovat {string.Join(", ", merkkijonot)}.");
        }

        public static DateTime Paivays(string kehote)
        {
            Console.Write(kehote);
            DateTime result;
            if (DateTime.TryParse(Console.ReadLine(), out result))
                return (result);

            throw new ApplicationException("Syöte ei ole kelvollinen päiväys.");
        }

        public static int KokonaislukuPakottaen()
        {
            int min = int.MinValue;
            int max = int.MaxValue;
            int result;
            while (true)
                try
                {
                    result = Helpers.Syote.Kokonaisluku($"Anna kokonaisluku{((min != int.MinValue || max != int.MaxValue) ? $" väliltä {min}-{max}" : "")}: ", min, max);
                    return (result);
                }
                catch (ApplicationException appException)
                {
                    Console.WriteLine(appException.Message);
                }
        }

        public static double DesimaalilukuPakottaen()
        {
            double result;
            while (true)
                try
                {
                    result = Helpers.Syote.Desimaaliluku($"Anna desimaaliluku: ");
                    return (result);
                }
                catch (ApplicationException appException)
                {
                    Console.WriteLine(appException.Message);
                }
        }

        public static char MerkkiPakottaen(string kehote, char[] sallitut = null)
        {
            char result;
            while (true)
                try
                {
                    if (sallitut == null)
                        result = Helpers.Syote.Merkki(kehote);
                    else
                        result = Helpers.Syote.Merkki(kehote, sallitut);
                    return (result);
                }
                catch (ApplicationException appException)
                {
                    Console.WriteLine(appException.Message);
                }
        }

        public static string MerkkijonoPakottaen(string kehote, string[] sallitut, bool tasoherkkyys = false)
        {
            string result;
            while (true)
                try
                {
                    if (sallitut == null)
                        result = Helpers.Syote.Merkkijono(kehote);
                    else
                        result = Helpers.Syote.Merkkijono(kehote, sallitut, tasoherkkyys);
                    return (result);
                }
                catch (ApplicationException appException)
                {
                    Console.WriteLine(appException.Message);
                }
        }

        public static DateTime PaivaysPakottaen()
        {
            DateTime result;
            while (true)
                try
                {
                    result = Helpers.Syote.Paivays($"Anna päivämäärä: ");
                    return (result);
                }
                catch (ApplicationException appException)
                {
                    Console.WriteLine(appException.Message);
                }
        }
    }
}
