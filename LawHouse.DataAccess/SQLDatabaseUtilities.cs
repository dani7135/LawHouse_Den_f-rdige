using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawHouse.DataAccess
{
    public class SQLDatabaseUtilities //By Julius
    {
        public static void RunSqlInsertCommand(string commandToRun, SqlCommand com) //By Daniella, refactored by Julius
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnString))
            {
                using (com)
                {

                    com.Connection = conn;
                    try
                    {
                        conn.Open();
                        com.CommandText = commandToRun;
                        com.ExecuteNonQuery();
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        public static List<List<string>> ReadSqlCommand(string sqlString) //By Julius
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnString);
            SqlCommand com = new SqlCommand(sqlString, conn);
            List<List<string>> toReturn = new List<List<string>>();

            try
            {
                conn.Open();
                SqlDataReader sqld = com.ExecuteReader();
                if (sqld.HasRows)
                {
                    while (sqld.Read())
                    {
                        List<string> collectedAttributes = new List<string>();
                        for (int i = 0; i < sqld.FieldCount; i++)
                        {
                            collectedAttributes.Add(Convert.ToString(sqld.GetValue(i)));
                        }
                        toReturn.Add(collectedAttributes);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return toReturn;
        }
    }
}
