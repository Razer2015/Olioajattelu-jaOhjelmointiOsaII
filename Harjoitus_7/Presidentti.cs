using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_7
{
    class Presidentti
    {
        public string Nimi { get; set; }
        public DateTime SyntymaAika { get; set; }
        public DateTime VirkaAlkuPvm { get; set; }
        public DateTime VirkaLoppuPvm { get; set; }

        public string VirkaKausi
        {
            get
            {
                return ($"{this.VirkaAlkuPvm.Day}.{this.VirkaAlkuPvm.Month}.{this.VirkaAlkuPvm.Year} - {this.VirkaLoppuPvm.Day}.{this.VirkaLoppuPvm.Month}.{this.VirkaLoppuPvm.Year}");
            }
        }

        public Presidentti()
        {

        }

        public override string ToString()
        {
            return (String.Format("{0} ({1})", this.Nimi, this.VirkaKausi));
        }
    }
}
