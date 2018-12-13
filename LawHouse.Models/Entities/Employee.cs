namespace LawHouse.Shared.Entities
{
    public class Employee //Dennie
    {
        public int ID { get; set; }
        public string Navn { get; set; }
        public Employee() { }
        public Employee(string navn)
        {
            Navn = navn;
        }

        public string Efteruddannelse { get; set; }
        public Employee(int advokatId, string navn)
        {
            ID = advokatId;
            Navn = navn;
        }
        public Employee(int advokatId, string navn, string efteruddannelse)
        {
            ID = advokatId;
            Navn = navn;
            Efteruddannelse = efteruddannelse;
        }
    }
}