namespace Harjoitus_10
{
    class Osoite
    {
        public string Katuosoite { get; set; }
        public string Postinro { get; set; }
        public string Postitoimipaikka { get; set; }

        public Osoite()
        {

        }

        public override string ToString()
        {
            return $"{Katuosoite}, {Postinro}, {Postitoimipaikka}";
        }
    }
}
