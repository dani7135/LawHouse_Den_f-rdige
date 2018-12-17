namespace LawHouse.Shared.Entities
{
    public class Service
    //Daniella

    {
        public int ID { get; set; }
        public string StartDate { get; set; }
        public string Services_description { get; set; }
        public int Price { get; set; }
        public int Timer { get; set; }
        public int CaseID { get; set; }
        public int EmployeeID { get; set; }

        public Service() { }

        public Service( string startDato, string services_description, int price, int timer, int caseID, int employeeID)
        {
           
            StartDate = startDato;
            Services_description = services_description;
            Price = price;
            Timer = timer;
            CaseID = caseID;
            EmployeeID = employeeID;
        }
    }
}
