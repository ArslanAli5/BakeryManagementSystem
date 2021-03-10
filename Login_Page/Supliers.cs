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
    class Supliers : DataBase_A.Models
    {
        public Supliers():base("Suppliers")
        { }

        public DataTable supplier_ID_List()
        {
            try
            {
                String query = "select ID from Suppliers";
                MySqlDataReader r = DataBase.Query(query);
                DataTable result = new DataTable();
                result.Load(r);
                r.Close();
                return result;

            }catch(Exception ex)
            { MessageBox.Show("Invalid data", "Error");
                return null;
            }
        }
    }
}
