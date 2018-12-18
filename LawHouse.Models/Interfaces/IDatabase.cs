using LawHouse.Shared.Entities;
using System.Collections.Generic;

namespace LawHouse.Shared.Interfaces
{
    public interface IDatabase
    {
        #region Employee
        int CreateEmployee(Employee employee);
        List<Employee> GetAllEmployee();
        List<Employee> GetEmployeesFromServiceType(int serviceTypeID);
        void UpdateEmployee(Employee advokat);
        #endregion

        #region Case
        int CreateCase(Case sag);
        List<Case> GetAllCase();
        void UpdateCase(Case sag);
        #endregion

        #region Client
        void CreateClient(Client klient);
        void UpdateClient(Client klient);
        List<Client> GetAllClient();
 
        #endregion

        #region Service
        void CreateService(Service ydelse);

        void UpdateService(Service ydelse);

        List<Service> GetAllServices();
        #endregion

        #region EmployeeService
        //List<EmployeeService> GetAllEmployeeService();
        #endregion

        #region ServiceType
        List<ServiceType> GetAllServiceType();
        #endregion

        //List<ListItems> GetAllList();

        #region Education
        List<Education> GetAllEducation();
        List<Education> GetEducationsFromEmployee(int employeeID);
        void AddEducationToEmployee(string educationName, int employeeID);
        #endregion

        #region EmployeeService
        void AddEmployeeServiceToEmployee(int id, int services_descriptionID);
        List<EmployeeService> GetEmployeeService(int employeeID);
        #endregion
    }
}
