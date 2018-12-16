using System;

namespace LawHouse.Shared.Entities
{
    public class Case
    //Daniella

    {
        public int ID { get; set; }
        public string WorkTitle { get; set; }
        public string StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Kilometers { get; set; }
        public string TimeEstimat { get; set; }
        public string CaseDescription { get; set; }
        public string internal_Notes { get; set; }
        public int ClientNr { get; set; }
        public int EmployeeID { get; set; }
        public int CategoryID { get; set; }

        public Case() { }
        public Case(string arbejdstitel, string startDato, DateTime slutDato, string kørselstimer, string timeEstimat, string sagsBeskrivelse, string interneNoter, int klientNr, int advokatId, int ydelsesTypeNr)
        {//Daniella
            WorkTitle = arbejdstitel;
            StartDate = startDato;
            EndDate = slutDato;
            Kilometers = kørselstimer;
            TimeEstimat = timeEstimat;
            CaseDescription = sagsBeskrivelse;
            internal_Notes = interneNoter;
            ClientNr = klientNr;
            EmployeeID = advokatId;
            CategoryID = ydelsesTypeNr;
        }
    }
}
