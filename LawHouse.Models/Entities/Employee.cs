namespace LawHouse.Shared.Entities
{
    public class Employee //Dennie
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Employee() { }
        public Employee(string navn)
        {
            Name = navn;
        }

        public string Training { get; set; }
        public Employee(int employeeID, string name)
        {
            ID = employeeID;
            this.Name = name;
        }
        public Employee(int advokatId, string navn, string training)
        {
            ID = advokatId;
            Name = navn;
            Training = training;
        }
    }
}