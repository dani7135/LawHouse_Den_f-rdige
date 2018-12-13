namespace LawHouse.Shared.Entities
{
    public class EmployeeService
    //Daniella

    {
        public int AdvokatId { get; set; }
        public int YdelsesTypeNr { get; set; }

        public EmployeeService() { }
        public EmployeeService(int advokatId, int ydelsesTypeNr)
        {
            AdvokatId = advokatId;
            YdelsesTypeNr = ydelsesTypeNr;
        }
    }
}