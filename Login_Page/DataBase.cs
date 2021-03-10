using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace DataBase_A
{
    public static class DataBase
    {

        public static MySqlConnection con;
        static DataBase()
        {
            try
            {
                con = new MySqlConnection(@"server=LocalHost;user id=root;database=bakery1");
                con.Open();
            }
            catch (Exception ex)
            {
                Console.Write("Couldn't connect\n" + ex.Message);
            }
        }

        public static MySqlDataReader Query(string sqlQuery)
        {
            MySqlCommand cmd = new MySqlCommand(sqlQuery, con);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            return dataReader;
        }

        public static IAsyncResult NonQuery(string sqlQuery)
        {
            MySqlCommand c = new MySqlCommand(sqlQuery, con);
            IAsyncResult result = c.BeginExecuteNonQuery();
            while (!result.IsCompleted)
            {
                System.Threading.Thread.Sleep(100);
            }
            c.EndExecuteNonQuery(result);
            
            return result;
        }
    }
}
