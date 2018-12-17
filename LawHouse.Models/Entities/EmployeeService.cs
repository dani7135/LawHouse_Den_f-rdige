namespace LawHouse.Shared.Entities
{
    public class EmployeeService
    //Daniella

    {
        public int EmployeeID { get; set; }
        public int ServiceID { get; set; }

        public EmployeeService() { }
        public EmployeeService(int advokatId, int services_description)
        {
            EmployeeID = advokatId;
            ServiceID = services_description;
        }
    }
}