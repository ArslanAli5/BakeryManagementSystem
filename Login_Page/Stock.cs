using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace DataBase_A
{
    class Stock : DataBase_A.Models
    {
        public Stock():base("Stock")
        { }

        public DataTable show()
        {
            try
            {

                String query = "call display_Stock();";
                MySqlDataReader r = DataBase.Query(query);
                DataTable result = new DataTable();
                result.Load(r);
                r.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data is not present");
                return null;
            }
        }
    }
}
