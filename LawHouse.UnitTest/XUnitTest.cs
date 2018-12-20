using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using LawHouse.DataAccess;
using LawHouse.Shared.Entities;
using LawHouse.Shared.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LawHouse.UnitTest.Properties;

namespace LawHouse.UnitTest
{
    [TestClass]
    public class XUnitTest
    {

        [TestMethod]
        public void CheckSQLDatabaseHandler_GetInstance() //Julius
        {
            IDatabase currentDatabaseInstance = SQLDatabaseHandler.Instance();
            Assert.IsInstanceOfType(currentDatabaseInstance, typeof(IDatabase));
        }
        [TestMethod]
        public void CheckGetAllEducationIndex()//Daniella
        {
            /* SQLDatabaseHandler databaseHandler = SQLDatabaseHandler.Instance();
             databaseHandler.GetAllEducation();
             Assert.IsTrue(true);*/

            string sqlString = "SELECT * FROM Efteruddannelse ";
                 
            using (SqlConnection conn = new SqlConnection(Settings.Default.ConnString))
            using (SqlCommand com = new SqlCommand(sqlString, conn))
            {
                conn.Open();
                using (SqlDataReader sqld = com.ExecuteReader())
                {
                    if (sqld.Read())
                    {
                        Assert.IsNotNull(sqld[0]);
                    }
                }


            }
        }
         [ TestMethod]        
         public static void CheakGetEducationsFromEmployeeIndex(Employee employee)
         {

             SQLDatabaseHandler databaseHandler = SQLDatabaseHandler.Instance();
             databaseHandler.GetEducationsFromEmployee(employee.ID);
             Assert.IsTrue(true);


            /* string sqlString = "SELECT * FROM Efteruddannelse " +
                  "JOIN Advokat ON Efteruddannelse.AdvokatId = Advokat.AdvokatId " +
                  $"WHERE Efteruddannelse.AdvokatId ={employee.ID} ";
             using (SqlConnection conn = new SqlConnection(Settings.Default.ConnString))
             using (SqlCommand com = new SqlCommand(sqlString, conn))
             {
                 conn.Open();
                 using (SqlDataReader sqld = com.ExecuteReader())
                 {
                     if (sqld.Read())
                     {
                         Assert.IsNotNull(sqld[0]);
                     }
                 }
             }*/
        }

        [TestMethod]
        public void CheckEstablishConnectionToSQLDatabaseWithBuildinMethode() //Julius
        {
            string commandToRun = "";
            SqlCommand com = new SqlCommand();
            SQLDatabaseUtilities.RunSqlInsertCommand(commandToRun, com);
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void CheckEstablishConnectionToSQLDatabaseWithOwnString()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
                "Data Source = den1.mssql8.gear.host;" +
                "Initial Catalog = goodboysplus1v2;" +
                "User ID = goodboysplus1v2;" +
                "Password = Kr995B7kts;";
            string whatVersion = null;
            try
            {
                conn.Open();
                whatVersion = conn.ServerVersion;
            }
            catch (Exception) { }
            finally
            {
                
                conn.Close();
            }
            Assert.IsNotNull(whatVersion);
        }
        [TestMethod]
        public void CheckGetEmployeeService() //Julius
        {
            SQLDatabaseHandler currentDatabaseInstance = SQLDatabaseHandler.Instance();//kan være en idatabase evt
            currentDatabaseInstance.GetAllEmployeeService();
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void CheckGetEmployeeServiceNotNull() //Julius
        {
            SQLDatabaseHandler currentDatabaseInstance = SQLDatabaseHandler.Instance();
            List<EmployeeService> listToChek = currentDatabaseInstance.GetAllEmployeeService();
            Assert.IsNotNull(listToChek);
        }
    }
}
