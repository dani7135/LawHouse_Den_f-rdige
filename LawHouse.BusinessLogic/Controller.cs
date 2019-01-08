using System;
using System.Collections.Generic;
using LawHouse.DataAccess;
using LawHouse.Shared.Entities;
using LawHouse.Shared.Interfaces;

namespace LawHouse.BusinessLogic
{
    public class Controller
    {

        private static IDatabase currentDatabaseInstance = SQLDatabaseHandler.Instance(); //Sql Database

        #region Employee
        public static int CreateAdvokat(string advokatNavn)//Dennie//Denne linje kode
        {
            Employee ad = new Employee(advokatNavn);
            int id = currentDatabaseInstance.CreateEmployee(ad);
            return id; 
        }

        public static List<Employee> GetAllAdvokat()//Daniella
        {
            return currentDatabaseInstance.GetAllEmployee();
        }
        public static List<Employee> GetEmployeesFromServiceType(int serviceTypeID)//Daniella
        {
            return currentDatabaseInstance.GetEmployeesFromServiceType(serviceTypeID);
        }

        public static void UpdateAdvokat(object objectToUpdate)//Daniella
        {
            Employee employee = (Employee)objectToUpdate;
            currentDatabaseInstance.UpdateEmployee(employee);
        }
        #endregion

        #region Case
        //Daniella
        public static int CreateCase(string arbejdstitel, string startDato, DateTime slutDato, string kørselstimer,
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

        public static void CreateClient(string navn, string adresse, string telefonNr)//Thomas
        {
            Client kl = new Client(navn, adresse, telefonNr);
            currentDatabaseInstance.CreateClient(kl);
        }

        public static void UpdateClient(object objectToUpdate)//Thomas
        
        {
            Client client = (Client)objectToUpdate;
            currentDatabaseInstance.UpdateClient(client);
        }

        public static List<Client> GetAllClients()//Daniella
        {
            List<Client> GetClient = currentDatabaseInstance.GetAllClient();
            return GetClient;
        }
        #endregion

        #region Service
        public static void CreateService(string startDato, string ydelseBeskrivelse, int pris, int timer, int sagsNr, int advokatId)//Daniella
        {
            Service @ydelse = new Service(startDato, ydelseBeskrivelse, pris, timer, sagsNr, advokatId);
            currentDatabaseInstance.CreateService(@ydelse);
        }

        public static List<Service> GetAllServices()//Daniella
        {
            return currentDatabaseInstance.GetAllServices();
        }

        public static void UpdateYdelse(object objectToUpdate)//Daniella
        {

            Service service = (Service)objectToUpdate;
            currentDatabaseInstance.UpdateService(service);
        }
        #endregion

        #region Case
        public static void UpdateCase(Case @case)//Daniella
        {
            currentDatabaseInstance.UpdateCase(@case);
        }
        #endregion

        #region Education
        public static List<Education> GetAllEducations()//Julius
        {
            return currentDatabaseInstance.GetAllEducation();
        }

        public static List<Education> GetEducationsFromEmployee(int employeeID)//Julius
        {
            return currentDatabaseInstance.GetEducationsFromEmployee(employeeID);
        }

        public static void AddEducationToEmployee(string specialName, int advokatId)//Dene kode
        {
            currentDatabaseInstance.AddEducationToEmployee(specialName, advokatId);
        }
        #endregion

        #region ServiceType
        public static List<ServiceType> GetAllServiceType()
        {
            return currentDatabaseInstance.GetAllServiceType();
        }

        public static List<Service>GetAllServise()
        {
            return currentDatabaseInstance.GetAllServices();
        }

        #endregion
        #region EmployeeService
        public static void AddEmployeeServiceToEmployee(int id,int services_descriptionID)//Daniella//Denne linje kode
        {
           currentDatabaseInstance.AddEmployeeServiceToEmployee(id, services_descriptionID);
        }

        public static List<EmployeeService> GetEmployeeServices(int serviceTypeID) //Daniella
        {
            return currentDatabaseInstance.GetEmployeeService(serviceTypeID);
        }
        #endregion

        //public static List<ListItems> GetAllItems()
        //{
        //    List<ListItems> GetItems = currentDatabaseInstance.GetAllList();
        //    return GetItems;
        //}
    }
}
