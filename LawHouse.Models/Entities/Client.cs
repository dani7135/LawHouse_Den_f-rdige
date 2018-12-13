namespace LawHouse.Shared.Entities
{
    public class Client
    {
        public int ID { get; set; }
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public string TelefonNr { get; set; }
        public Client() { }
        public Client(string navn, string adresse, string telefonNr)
        {
            Navn = navn;
            Adresse = adresse;
            TelefonNr = telefonNr;
        }

    }
}
