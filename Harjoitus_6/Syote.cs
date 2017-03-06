using System;

namespace Helpers
{
    public static class Syote
    {
        public static int Kokonaisluku(string kehote, int min = int.MinValue, int max = int.MaxValue) {
            Console.Write(kehote);
            int result;
            if (int.TryParse(Console.ReadLine(), out result))
                if (result >= min && result <= max)
                    return (result);

            throw new ApplicationException($"Syöte ei ole kelvollinen kokonaisluku.{((min != int.MinValue || max != int.MaxValue) ? $" Minimi on {min}. Maksimi on {max}." : "")}");
        }

        public static double Desimaaliluku(string kehote, int tarkkuus = -1) {
            Console.Write(kehote);
            double result;
            if (double.TryParse(Console.ReadLine(), out result)) {
                if (tarkkuus < 0)
                    return (result);
                else
                    return (Math.Round(result, tarkkuus));
            }

            throw new ApplicationException("Syöte ei ole kelvollinen desimaaliluku.");
        }

        public static char Merkki(string kehote) {
            Console.Write(kehote);
            char result;
            if (char.TryParse(Console.ReadLine(), out result))
                return (result);

            throw new ApplicationException("Syöte ei ole kelvollinen merkki.");
        }

        public static string Merkkijono(string kehote) {
            Console.Write(kehote);
            return (Console.ReadLine());
        }

        public static DateTime Paivays(string kehote) {
            Console.Write(kehote);
            DateTime result;
            if (DateTime.TryParse(Console.ReadLine(), out result))
                return (result);

            throw new ApplicationException("Syöte ei ole kelvollinen päiväys.");
        }
    }
}
