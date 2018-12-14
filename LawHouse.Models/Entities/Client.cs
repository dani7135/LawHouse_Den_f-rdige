namespace LawHouse.Shared.Entities
{
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public Client() { }
        public Client(string name, string address, string phoneNr)
        {
            Name = name;
            Address = address;
            PhoneNo = phoneNr;
        }

    }
}
