using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public enum PaivaysMuoto
    {
        Usa = 1,
        Ranska,
        Englanti,
        Ruotsi,
        Saksa,
        Suomi,
        Italia,
        Japani
    }

    public class Paivays
    {
        int Pp { get; set; }
        int Kk { get; set; }
        int Vv { get; set; }
        bool Arki { get; set; }

        public Paivays(int pp, int kk, int vv, bool arki) {
            DateTime result;
            if (!DateTime.TryParse($"{pp}.{kk}.{vv}", out result))
                throw new ApplicationException("Päiväys-oliota ei voitu tehdä.");
            this.Pp = result.Day;
            this.Kk = result.Month;
            this.Vv = result.Year;
            this.Arki = arki;
        }

        public Paivays(int pp, int kk, int vv)
            : this(pp, kk, vv, true) { }

        public override string ToString() {
            return ($"{Pp}.{Kk}.{Vv}");
        }

        public string ToString(PaivaysMuoto paivaysMuoto) {
            switch (paivaysMuoto) {
                case PaivaysMuoto.Usa:
                    return ($"{Kk}/{Pp}/{Vv}");
                case PaivaysMuoto.Ranska:
                case PaivaysMuoto.Englanti:
                case PaivaysMuoto.Ruotsi:
                    return ($"{Pp}/{Kk}/{Vv}");
                case PaivaysMuoto.Saksa:
                case PaivaysMuoto.Suomi:
                default:
                    return ($"{Pp}.{Kk}.{Vv}");
                case PaivaysMuoto.Italia:
                    return ($"{Pp}-{Kk}-{Vv}");
                case PaivaysMuoto.Japani:
                    return ($"{Vv}/{Kk}/{Pp}");
            }
        }

        public bool OnkoUudempiKuin(Paivays paivays) {
            if ((this.Vv > paivays.Vv) ||
                (this.Vv == paivays.Vv && this.Kk > paivays.Kk) ||
                (this.Vv == paivays.Vv && this.Kk == paivays.Kk && this.Pp > paivays.Pp))
                return (true);
            else
                return (false);
        }

        public bool OnkoVanhempiKuin(Paivays paivays) {
            if ((this.Vv < paivays.Vv) ||
                (this.Vv == paivays.Vv && this.Kk < paivays.Kk) ||
                (this.Vv == paivays.Vv && this.Kk == paivays.Kk && this.Pp < paivays.Pp))
                return (true);
            else
                return (false);
        }

        public bool OnkoSamaKuin(Paivays paivays) {
            if ((this.Vv == paivays.Vv) && (this.Kk == paivays.Kk) && (this.Pp == paivays.Pp))
                return (true);
            else
                return (false);
        }

        public static Paivays Parse(DateTime dt) {
            return (new Paivays(dt.Day, dt.Month, dt.Year, ((dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday) ? false : true)));
        }

        public static Paivays Parse(string pvm) {
            DateTime dt;
            if (DateTime.TryParseExact(pvm, "dd.MM.yyyy", new CultureInfo("fi-FI"), DateTimeStyles.None, out dt))
                return (new Paivays(dt.Day, dt.Month, dt.Year, ((dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday) ? false : true)));
            else
                throw new ApplicationException("Päiväyksen muoto virheellinen.");
        }

        public static Paivays Parse(string pvm, PaivaysMuoto paivaysMuoto) {
            string[] formats = null;
            CultureInfo culture = null;
            switch (paivaysMuoto) {
                case PaivaysMuoto.Usa:
                    formats = new string[] { "M/d/yyyy", "MM/d/yyyy", "MM/dd/yyyy" };
                    culture = new CultureInfo("en-US");
                    break;
                case PaivaysMuoto.Ranska:
                case PaivaysMuoto.Englanti:
                case PaivaysMuoto.Ruotsi:
                    formats = new string[] { "dd/M/yyyy", "d/MM/yyyy", "dd/MM/yyyy" };
                    culture = new CultureInfo("sv-SE");
                    break;
                case PaivaysMuoto.Saksa:
                case PaivaysMuoto.Suomi:
                    formats = new string[] { "dd.M.yyyy", "d.MM.yyyy", "dd.MM.yyyy" };
                    culture = new CultureInfo("fi-FI");
                    break;
                case PaivaysMuoto.Italia:
                    formats = new string[] { "dd-M-yyyy", "d-MM-yyyy", "dd-MM-yyyy" };
                    culture = new CultureInfo("it-IT");
                    break;
                case PaivaysMuoto.Japani:
                    formats = new string[] { "yyyy/M/dd", "yyyy/MM/d", "yyyy/MM/dd" };
                    culture = new CultureInfo("ja-JP");
                    break;
                default:
                    throw new ApplicationException("Päiväyksen muoto virheellinen.");
            }

            DateTime dt;
            if (DateTime.TryParseExact(pvm, formats, culture, DateTimeStyles.None, out dt))
                return (new Paivays(dt.Day, dt.Month, dt.Year, ((dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday) ? false : true)));
            else
                throw new ApplicationException("Päiväyksen muoto virheellinen.");
        }
    }
}
