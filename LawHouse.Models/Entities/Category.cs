namespace LawHouse.Shared.Entities
{
    public class ServiceType
        //Daniella
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ServiceType() { }
        public ServiceType(int ydelsesTypeNr, string ydelsesNavn)
        {
            Name = ydelsesNavn;
            ID = ydelsesTypeNr;

        }
    }
}