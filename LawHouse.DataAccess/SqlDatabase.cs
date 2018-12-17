using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawHouse.Shared.Entities;
using LawHouse.Shared.Interfaces;

namespace LawHouse.DataAccess
{
    //Singletone er blevet brugt nedenunder og i kontrolleren
    //A singleton is a convenient way for accessing the service from anywhere in the application code
    public class SqlDatabase : IDatabase
    {
        private static SqlDatabase _database = null;//By Daniella
        private SqlDatabase() { }
        public static SqlDatabase Instance()
        {
            if (_database == null)
            {
                _database = new SqlDatabase();
            }
            return _database;
        }
        #region Case
        public int CreateCase(Case @case)// By Daniella
        {//Grunden til at der den her er fordi den tager en case og opretter det ud for properties
            string sqlString = $"INSERT INTO Sag(Arbejdstitel, StartDato, SlutDato, Kørselstimer, TimeEstimat, SagsBeskrivelse, InterneNoter , KlientNr, AdvokatId, YdelsesTypeNr )" + $"values(@Arbejdstitel , @Startdato , @SlutDato , @Kørselstimer , @TimeEstimat ,  @SagsBeskrivelse,   @InterneNoter ,  @KlientNr,  @AdvokatId,  @YdelsesTypeNr) " +
                               $"SELECT CAST(SCOPE_IDENTITY() AS int)";
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnString))
            {
                using (SqlCommand com = new SqlCommand(sqlString, conn))
                {
                    conn.Open();
                    com.Parameters.Add(new SqlParameter("Arbejdstitel", @case.WorkTitle));
                    com.Parameters.Add(new SqlParameter("Startdato", @case.StartDate));
                    if (@case.EndDate == null)
                    {
                        com.Parameters.Add(new SqlParameter("SlutDato", DBNull.Value));
                    }
                    else
                    {
                        com.Parameters.Add(new SqlParameter("SlutDato", @case.EndDate.ToString()));

                    }
                    com.Parameters.Add(new SqlParameter("Kørselstimer", @case.Kilometers));
                    com.Parameters.Add(new SqlParameter("TimeEstimat", @case.TimeEstimat));
                    com.Parameters.Add(new SqlParameter("SagsBeskrivelse", @case.CaseDescription));
                    com.Parameters.Add(new SqlParameter("InterneNoter", @case.internal_Notes));
                    com.Parameters.Add(new SqlParameter("KlientNr", @case.ClientNr));
                    com.Parameters.Add(new SqlParameter("AdvokatId", @case.EmployeeID));
                    com.Parameters.Add(new SqlParameter("YdelsesTypeNr", @case.CategoryID));
                    return (int)com.ExecuteScalar();
                }
            }
            //  SqlDatabaseUtilities.RunSqlCommand(sqlString);
        }
        public void UpdateCase(Case @case)// By Daniella, refactored by Julius
        {
            string sqlString =
                $"UPDATE Sag SET Arbejdstitel = @Arbejdstitel, StartDato = @StartDato , SlutDato = @SlutDato , Kørselstimer = @Kørselstimer , TimeEstimat = @TimeEstimat , SagsBeskrivelse = @SagsBeskrivelse , InterneNoter = @InterneNoter , KlientNr = @KlientNr , AdvokatId = @AdvokatId , YdelsesTypeNr = @YdelsesTypeNr " +
                $"WHERE SagsNr = {@case.ID}";
            SqlCommand com = new SqlCommand();
            com.Parameters.Add(new SqlParameter("Arbejdstitel", @case.WorkTitle));
            com.Parameters.Add(new SqlParameter("Startdato", @case.StartDate));
            com.Parameters.Add(new SqlParameter("SlutDato", @case.EndDate.ToString()));
            com.Parameters.Add(new SqlParameter("Kørselstimer", @case.Kilometers));
            com.Parameters.Add(new SqlParameter("TimeEstimat", @case.TimeEstimat));
            com.Parameters.Add(new SqlParameter("SagsBeskrivelse", @case.CaseDescription));
            com.Parameters.Add(new SqlParameter("InterneNoter", @case.internal_Notes));
            com.Parameters.Add(new SqlParameter("KlientNr", @case.ClientNr));
            com.Parameters.Add(new SqlParameter("AdvokatId", @case.EmployeeID));
            com.Parameters.Add(new SqlParameter("YdelsesTypeNr", @case.CategoryID));
            SqlDatabaseUtilities.RunSqlCommand(sqlString, com);
        }
        public List<Case> GetAllCase()// By Daniella //By Julius
        {
            string sqlString = "SELECT * FROM Sag " +
                               "JOIN Advokat ON Sag.AdvokatID = Advokat.AdvokatId" +
                               " JOIN Klient ON Sag.KlientNr = Klient.KlientNr";
            List<Case> listOfSag = new List<Case>();

            List<List<string>> rawReadValue = SqlDatabaseUtilities.GenericSqlStringDataReader(sqlString);

            foreach (List<string> x in rawReadValue)
            {
                Case @sag = new Case();
                @sag.ID = Convert.ToInt32(x[0]);
                @sag.WorkTitle = x[1];
                @sag.StartDate = x[2];
                @sag.EndDate = DateTime.TryParse(x[3], out DateTime dateTime) ? dateTime : default(DateTime);

                @sag.Kilometers = x[4];
                @sag.TimeEstimat = x[5];
                @sag.CaseDescription = x[6];
                @sag.internal_Notes = x[7];
                @sag.ClientNr = Convert.ToInt32(x[8]);
                @sag.EmployeeID = Convert.ToInt32(x[9]);
                @sag.CategoryID = Convert.ToInt32(x[10]);
                listOfSag.Add(@sag);
            }
            return listOfSag;
        }

        #endregion

        #region Client
        public void CreateClient(Client klient)//By Thomas
        {
            SqlCommand com = new SqlCommand();
            string sqlString = $"INSERT INTO KLient(Navn, Adresse, TelefonNr) VALUES (@Navn , @Adresse , @TelefonNr)";
            SqlDatabaseUtilities.RunSqlCommand(sqlString, com);

        }
        public void UpdateClient(Client klient) // By Thomas
        {
            SqlCommand com = new SqlCommand();
            string sqlString =
                $"UPDATE Klient SET Navn =@Navn, Adresse = @Adresse, TelefonNr = @TelefonNr " +
                $"WHERE KlientNr = {klient.ID}";
            SqlDatabaseUtilities.RunSqlCommand(sqlString, com);
        }
        public List<Client> GetAllClient()// By Daniella //By Julius
        {
            string sqlString = "SELECT * FROM Klient";
            List<Client> listOfKlient = new List<Client>();

            List<List<string>> rawReadValue = SqlDatabaseUtilities.GenericSqlStringDataReader(sqlString);

            foreach (List<string> x in rawReadValue)
            {
                Client @klient = new Client();
                @klient.ID = Convert.ToInt32(x[0]);
                @klient.Name = x[1];
                @klient.Address = x[2];
                @klient.PhoneNo = x[3];
                listOfKlient.Add(@klient);
            }
            return listOfKlient;
        }
        #endregion

        #region Employee
        public int CreateEmployee(Employee advokat)// By Dennie
        {
            string sqlString = @"INSERT INTO Advokat(Navn) VALUES (@Navn)
                                SELECT CAST(SCOPE_IDENTITY() AS int)";
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnString))
            {
                using (SqlCommand com = new SqlCommand(sqlString, conn))
                {
                    conn.Open();
                    com.Parameters.Add(new SqlParameter("Navn", advokat.Name));
                    return (int)com.ExecuteScalar();
                }
            }
        }
        /* Når en advokat skal have tilføjet et speciale/efteruddannelse, skal man i vores database bare indtaste et "navn" på specialet + "advokat id'et", som skal have denne efteruddannelse.
             * Havde forstillet mig, at man i vores ViewListe skal kunne vælge "vis advokater" og derinde så tilføje efteruddannelse ud fra en "valgt" advokats id.
             - Dennie 
        */
        public void UpdateEmployee(Employee advokat) // by Thomas
        {
            SqlCommand com = new SqlCommand();
            String sqlString =
                $"UPDATE Advokat SET Navn = @Navn" +
                 $"WHERE AdvokatID =@AdvokatId";
            SqlDatabaseUtilities.RunSqlCommand(sqlString, com);

        }
        public List<Employee> GetAllEmployee()// By Daniella //By Julius
        {
            string sqlString = "SELECT * FROM Advokat";
            List<Employee> listOfAdvokat = new List<Employee>();

            List<List<string>> rawReadValue = SqlDatabaseUtilities.GenericSqlStringDataReader(sqlString);

            foreach (List<string> x in rawReadValue)
            {
                Employee @advokat = new Employee();
                @advokat.ID = Convert.ToInt32(x[0]);
                @advokat.Name = x[1];
                listOfAdvokat.Add(@advokat);
            }
            return listOfAdvokat;
        }

        public List<Employee> GetEmployeesFromCategory(int ydelsesTypeNr)// By Daniella //By Julius
        {
            string sqlString = @"SELECT * FROM ADVOKAT
                                JOIN Tjenesteydelse ON Tjenesteydelse.AdvokatId = Advokat.AdvokatId
                                WHERE YdelsesTypeNr = " + ydelsesTypeNr;
            List<Employee> listOfAdvokat = new List<Employee>();

            List<List<string>> rawReadValue = SqlDatabaseUtilities.GenericSqlStringDataReader(sqlString);

            foreach (List<string> x in rawReadValue)
            {
                Employee @advokat = new Employee();
                @advokat.ID = Convert.ToInt32(x[0]);
                @advokat.Name = x[1];
                listOfAdvokat.Add(@advokat);
            }
            return listOfAdvokat;
        }


        public List<EmployeeService> GetAllEmployeeService()// By Daniella //By Julius
        {
            string sqlString = "SELECT * FROM Tjenesteydelse";
            List<EmployeeService> listOfTjenesteydelse = new List<EmployeeService>();

            List<List<string>> rawReadValue = SqlDatabaseUtilities.GenericSqlStringDataReader(sqlString);

            foreach (List<string> x in rawReadValue)
            {
                EmployeeService tjenesteydelse = new EmployeeService();
                tjenesteydelse.ID = Convert.ToInt32(x[0]);
                tjenesteydelse.Services_descriptionID = Convert.ToInt32(x[1]);
                listOfTjenesteydelse.Add(tjenesteydelse);
            }
            return listOfTjenesteydelse;
        }
        #endregion

        #region ServiceType
        //Den har med kategory med i stedet for employeeservis, så den skal nok laves om
        public List<Category> GetAllServiceType()// By Daniella //By Julius
        {
            string sqlString = "SELECT * FROM YdelseType";
            List<Category> listOfYdelsetype = new List<Category>();

            List<List<string>> rawReadValue = SqlDatabaseUtilities.GenericSqlStringDataReader(sqlString);

            foreach (List<string> x in rawReadValue)
            {
                Category @ydelseType = new Category();
                @ydelseType.ID = Convert.ToInt32(x[0]);
                @ydelseType.Name = x[1];
                listOfYdelsetype.Add(@ydelseType);
            }
            return listOfYdelsetype;
        }
        #endregion

        #region Service
        public void CreateService(Service ydelse)
        {
            {
                SqlCommand com = new SqlCommand();
                string sqlString = $"INSERT INTO Ydelse( StartDato, YdelsesBeskrivelse, Pris, Timer, SagsNr, AdvokatId )" + $"values( @StartDato , @YdelsesBeskrivelse ,@Pris  ,@Timer , @SagsNr , @AdvokatId )";
                com.Parameters.Add(new SqlParameter("StartDato", ydelse.StartDate));
                com.Parameters.Add(new SqlParameter("YdelsesBeskrivelse", ydelse.Services_description));
                com.Parameters.Add(new SqlParameter("Pris", ydelse.Price));
                com.Parameters.Add(new SqlParameter("Timer", ydelse.Timer));
                com.Parameters.Add(new SqlParameter("SagsNr", ydelse.CaseID));
                com.Parameters.Add(new SqlParameter("AdvokatId", ydelse.EmployeeID));
                SqlDatabaseUtilities.RunSqlCommand(sqlString, com);
            }
            /*
                    public void CreateClient(Client klient)//By Thomas
        {
            SqlCommand com = new SqlCommand();
            string sqlString = $"INSERT INTO KLient(Navn, Adresse, TelefonNr) VALUES (@Navn , @Adresse , @TelefonNr)";
            SqlDatabaseUtilities.RunSqlCommand(sqlString, com);

        }
             */
        }
        public void UpdateService(Service ydelse)
        {
            SqlCommand com = new SqlCommand();
            string sqlString =
                $"UPDATE Ydelse SET Startdato = @StartDato , YdelsesBeskrivelse =@YdelsesBeskrivelse , Pris = @Pris ,Timer = @Timer , SagsNr = @SagsNr , AdvokatId = @AdvokatId " +
                $"WHERE YdelsesNr ={ydelse.ID}";
            SqlDatabaseUtilities.RunSqlCommand(sqlString, com);
        }
        public List<Service> GetAllServices()// By Daniella //By Julius
        {
            string sqlString = "SELECT * FROM Ydelse";
            List<Service> listOfYdelse = new List<Service>();

            List<List<string>> rawReadValue = SqlDatabaseUtilities.GenericSqlStringDataReader(sqlString);

            foreach (List<string> x in rawReadValue)
            {
                Service @ydelse = new Service();
                @ydelse.ID = Convert.ToInt32(x[0]);
                @ydelse.StartDate = x[1];
                @ydelse.Services_description = x[2];
                @ydelse.Price = Convert.ToInt32(x[3]);
                @ydelse.Timer = Convert.ToInt32(x[4]);
                @ydelse.CaseID = Convert.ToInt32(x[5]);
                @ydelse.EmployeeID = Convert.ToInt32(x[6]);
                listOfYdelse.Add(@ydelse);
            }
            return listOfYdelse;
        }
        #endregion

        #region Education
        public List<Education> GetAllEducation()//By Julius
        {
            string sqlString = "SELECT * FROM Efteruddannelse";
            List<Education> listOfEfteruddannelse = new List<Education>();

            List<List<string>> rawReadValue = SqlDatabaseUtilities.GenericSqlStringDataReader(sqlString);

            foreach (List<string> x in rawReadValue)
            {
                Education @Efteruddannelse = new Education();
                @Efteruddannelse.Name = x[0];
                @Efteruddannelse.EmployeeID = Convert.ToInt32(x[1]);
                listOfEfteruddannelse.Add(@Efteruddannelse);
            }
            return listOfEfteruddannelse;
        }

        public List<Education> GetEducationsFromEmployee(int employeeID)//Dniella
        {
            string sqlString = "SELECT * FROM Efteruddannelse " +
                 "JOIN Advokat ON Efteruddannelse.AdvokatId = Advokat.AdvokatId " +
                 $"WHERE Efteruddannelse.AdvokatId = {employeeID}";
     

           List <Education> listOfEducation = new List<Education>();
            List<List<string>> rawReadValue = SqlDatabaseUtilities.GenericSqlStringDataReader(sqlString);
            foreach (List<string> x in rawReadValue)
            {
                Education @Efteruddannelse = new Education();
                @Efteruddannelse.Name = x[0];
                @Efteruddannelse.EmployeeID = Convert.ToInt32(x[1]);
                listOfEducation.Add(@Efteruddannelse);
            }
            return listOfEducation;

        }
        public void AddEducationToEmployee(string efteruddannelse, int advokatId)// By Daniella
        {
            SqlCommand com = new SqlCommand();
            string sqlString = $"INSERT INTO Efteruddannelse(Navn, AdvokatId) VALUES (@efteruddannelse, @advokatId)";
            com.Parameters.Add(new SqlParameter("efteruddannelse", efteruddannelse));
            com.Parameters.Add(new SqlParameter("advokatId", advokatId));
            SqlDatabaseUtilities.RunSqlCommand(sqlString, com);
          
        }
        #endregion

        #region EmployeeService
        public void AddEmployeeServiceToEmployee(int id, int services_descriptionID)//By Julius
        {
            SqlCommand com = new SqlCommand();
            string sqlString = $"INSERT INTO Tjenesteydelse(AdvokatId, YdelsesTypeNr) VALUES (@advokatId, @ydelsesTypeNr)";
            SqlDatabaseUtilities.RunSqlCommand(sqlString, com);
        }
        public List<EmployeeService> GetEmployeeServices()
        {
            string sqlString = "SELECT * FROMTjenesteydelse";
            List<EmployeeService> listofEmployeeService = new List<EmployeeService>();
            List<List<string>> rawReadValue = SqlDatabaseUtilities.GenericSqlStringDataReader(sqlString);
            foreach (List<string> x in rawReadValue)
            {
                EmployeeService employeeService = new EmployeeService();
                employeeService.ID = Convert.ToInt32(x[0]);
                employeeService.Services_descriptionID = Convert.ToInt32(x[1]);
                listofEmployeeService.Add(employeeService);
            }
            return listofEmployeeService;
           
        }
        #endregion

        //public List<ListItems> GetAllList()// By Daniella //By Julius
        //{
        //    string sqlString = "SELECT * FROM List";
        //    List<ListItems> listOfListItems = new List<ListItems>();

        //    List<List<string>> rawReadValue = SqlDatabaseUtilities.GenericSqlStringDataReader(sqlString);

        //    foreach (List<string> x in rawReadValue)
        //    {
        //        ListItems @listItems = new ListItems();
        //        @listItems.ListID = x[0];
        //        @listItems.What_type = x[1];
        //        listOfListItems.Add(@listItems);
        //    }
        //    return listOfListItems;
        //}
    }
}
