using System;
using System.Collections.Generic;
using LawHouse.DataAccess;
using LawHouse.Shared.Entities;
using LawHouse.Shared.Interfaces;

namespace LawHouse.BusinessLogic
{

    public class Controller
    {

        private static IDatabase currentDatabaseInstance = SqlDatabase.Instance(); //Sql Database

        #region Employee
        public static int CreateAdvokat(string advokatNavn)
        {
            Employee ad = new Employee(advokatNavn);
            int id = currentDatabaseInstance.CreateEmployee(ad);
            return id; 
        }

        public static List<Employee> GetAllAdvokat()
        {
            return currentDatabaseInstance.GetAllEmployee();
        }
        public static List<Employee> GetEmployeesFromCategory(int categoryID)
        {
            return currentDatabaseInstance.GetEmployeesFromCategory(categoryID);
        }

        public static void UpdateAdvokat(object objectToUpdate)
        {
            Employee employee = (Employee)objectToUpdate;
            currentDatabaseInstance.UpdateEmployee(employee);
        }
        #endregion

        #region Case
        public static int CreateCase(string arbejdstitel, string startDato, string slutDato, string kørselstimer,
        string timeEstimat, string sagsBeskrivelse, string interneNoter, int klientNr, int advokatId, int ydelsesTypeNr)
        {
            Case @case = new Case(arbejdstitel, startDato, slutDato, kørselstimer, timeEstimat, sagsBeskrivelse, interneNoter, klientNr, advokatId, ydelsesTypeNr);
            int id = currentDatabaseInstance.CreateCase(@case);
            return id;
        }
        public static List<Case> GetAllSag()
        {
            List<Case> listToReturn = currentDatabaseInstance.GetAllCase();
            return listToReturn;
        }
        public static void UpdateCase(object objectToUpdate)
        {
            Case @case = (Case)objectToUpdate;
            currentDatabaseInstance.UpdateCase(@case);
        }
        #endregion

        #region Client

        public static void CreateClient(string navn, string adresse, string telefonNr)
        {
            Client kl = new Client(navn, adresse, telefonNr);
            currentDatabaseInstance.CreateClient(kl);
        }

        public static void UpdateClient(object objectToUpdate)
        
        {
            Client client = (Client)objectToUpdate;
            currentDatabaseInstance.UpdateClient(client);
        }

        public static List<Client> GetAllClients()
        {
            List<Client> GetClient = currentDatabaseInstance.GetAllClient();
            return GetClient;
        }
        #endregion

        #region Service
        public static void CreateService(string startDato, string ydelseBeskrivelse, string pris, string timer, int sagsNr, int advokatId)
        {
            Service @ydelse = new Service(startDato, ydelseBeskrivelse, pris, timer, sagsNr, advokatId);
            currentDatabaseInstance.CreateService(@ydelse);
        }

        public static List<Service> GetAllServices()
        {
            return currentDatabaseInstance.GetAllServices();
        }

        public static void UpdateYdelse(object objectToUpdate)
        {

            Service service = (Service)objectToUpdate;
            currentDatabaseInstance.UpdateService(service);
        }
        #endregion

        #region Case
        public static void UpdateCase(Case @case)
        {
            currentDatabaseInstance.UpdateCase(@case);
        }
        #endregion

        #region Education
        public static List<Education> GetAllEducations()
        {
            return currentDatabaseInstance.GetAllEducation();
        }
        public static List<Education> GetEducationsFromEmployee(int employeeID)
        {
            return currentDatabaseInstance.GetEducationsFromEmployee(employeeID);
        }

        public static void AddEducationToEmployee(string specialName, int advokatId)
        {
            currentDatabaseInstance.AddEducationToEmployee(specialName, advokatId);
        }
        #endregion

        #region ServiceType
        public static List<Category> GetAllCategory()
        {
            return currentDatabaseInstance.GetAllServiceType();
        }
        #endregion

        //public static List<ListItems> GetAllItems()
        //{
        //    List<ListItems> GetItems = currentDatabaseInstance.GetAllList();
        //    return GetItems;
        //}



    }
}
