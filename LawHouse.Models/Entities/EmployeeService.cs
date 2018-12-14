namespace LawHouse.Shared.Entities
{
    public class EmployeeService
    //Daniella

    {
        public int ID { get; set; }
        public int Services_descriptionID { get; set; }

        public EmployeeService() { }
        public EmployeeService(int advokatId, int services_description)
        {
            ID = advokatId;
            Services_descriptionID = services_description;
        }
    }
}