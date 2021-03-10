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
    class Login_Class
    {
        public Boolean validate(String name, String pass)
        {

            try
            {
                String query = "Select* From tb_login as l Where l.user_name ='" + name + "'and l.password ='" + pass + "';";
                MySqlDataReader r = DataBase.Query(query);
                DataTable result = new DataTable();
                result.Load(r);

                DataRow r1 = result.Rows[0];
                object[] o = r1.ItemArray;
                String val = (String)o[0];
                var res1 = val.Trim();
               
                if (res1.Equals("true") )
                {
                    r.Close();
                    return true;
                }
                else
                {
                    r.Close();
                    return true;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Invalid UserName or Password", "Error");
                return false;
            }
        }

        public Boolean signUp(String name, String pass)
        {
             String query = "insert into tb_login values('" + name + "','" + pass + "')";
             MySqlDataReader r = DataBase.Query(query);
             return true;
        }

//using System.Data;



    public String forget(String hint)
        {

            try
            {
                String query = "select substring(l.user_name,1,3) as user_name,substring(l.password,1,3) as password from tb_Login as l where l.user_name like '"+ hint +"'";             
                MySqlDataReader r = DataBase.Query(query);
                DataTable result = new DataTable();
                result.Load(r);
                DataRow r1 = result.Rows[0];               
                object[] o = r1.ItemArray;               
                String ret = "User Name Like     "+(String)o[0]+"\n\nPassword   Like     "+(String)o[1];
                r.Close();
                return ret;
            }
            catch (Exception ex)
            {
                MessageBox.Show("User Does not Exist !", "Sorry",MessageBoxButtons.OK,MessageBoxIcon.Hand);          
                return null;
            }
        }
    }

   
}
