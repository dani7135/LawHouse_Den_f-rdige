using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using LawHouse.DataAccess;
using LawHouse.Shared.Entities;
using LawHouse.Shared.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
 using LawHouse.UnitTest.Properties;
using LawHouse.Shared.Entities;

namespace LawHouse.UnitTest
{
    [TestClass]
    public class XUnitTest
    {
        
        public void CheckGetAllEducationIndex()
        {

            const string sqlString = "select * from Efteruddannelse";
            using (SqlConnection conn = new SqlConnection(Settings.Default.ConnString))
            using (SqlCommand com = new SqlCommand(sqlString, conn))
            {
                using ()
            }
        }



























        //40
        [TestMethod]
        public void CheckSQLDatabaseHandler_GetInstance() //Julius
        {
            IDatabase currentDatabaseInstance = SQLDatabaseHandler.Instance();
            Assert.IsInstanceOfType(currentDatabaseInstance, typeof(IDatabase));
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
