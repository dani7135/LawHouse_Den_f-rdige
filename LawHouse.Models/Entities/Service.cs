namespace LawHouse.Shared.Entities
{
    public class Service
    //Daniella

    {
        public int ID { get; set; }
        public string StartDato { get; set; }
        public string YdelsesBeskrivelse { get; set; }
        public string Pris { get; set; }
        public string Timer { get; set; }
        public int SagsNr { get; set; }
        public int AdvokatId { get; set; }

        public Service() { }

        public Service( string startDato, string ydelsesBeskrivelse, string pris, string timer, int sagsNr, int advokatId)
        {
           
            StartDato = startDato;
            YdelsesBeskrivelse = ydelsesBeskrivelse;
            Pris = pris;
            Timer = timer;
            SagsNr = sagsNr;
            AdvokatId = advokatId;
        }
    }
}
