namespace LawHouse.Shared.Entities
{
    public class Category
        //Daniella
        //YdelsesType
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Category() { }
        public Category(int id, string name)
        {
            Name = name;
            ID = id;

        }
    }
}