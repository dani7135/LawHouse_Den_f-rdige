using System;
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


























































    }
}
