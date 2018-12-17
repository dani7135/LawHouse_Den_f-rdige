namespace LawHouse.Shared.Entities
{
    public class ServiceType
        //Daniella
        //YdelsesType
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ServiceType() { }
        public ServiceType(int id, string name)
        {
            Name = name;
            ID = id;

        }
    }
}