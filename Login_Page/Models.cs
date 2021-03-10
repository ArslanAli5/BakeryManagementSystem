using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DataBase_A
{
    class Models
    {

        public string tableName = "";

        public Models(string tableName)
        {
            this.tableName = tableName;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pbfont"></param>
        /// <param name="cbfont"></param>
        /// <param name="pdv"></param>
        /// <param name="pcFonts"></param>
        /// <returns></returns>
        /// 
        /// 
        /// *****############## Insert through List/// *********************##############

        public Boolean insert(List<String> attributes)
        {
            string query;
            String q="";
            query = "";
            /**IF table name is customer and all fields **/
            if (tableName == "Employee")
            {
                query = "insert into Employee (Name, Email, PhoneNumber, Adress, City, Salary, HireDate) values ('" + attributes[0] + "','" + attributes[1] + "','" + attributes[2] + "', '" + attributes[3] + "','" + attributes[4] + "','" + attributes[5] + "','" + attributes[6] + "' );";
            }
            else if (tableName == "Customer")
            {
                query = "insert into customer (Name,Email,Adress,City,PhoneNumber,Grade) values ('" + attributes[0] + "','" + attributes[1] + "','" + attributes[2] + "', '" + attributes[3] + "'," + attributes[4] + ",'" + attributes[5] + "');";
            }
            else if (tableName == "Suppliers")
            {
                query = "insert into Suppliers(Name,Adress,City,phoneNumber) values ('" + attributes[0] + "','" + attributes[1] + "','" + attributes[2] + "', " + attributes[3] + ");";
            }
            else if (tableName == "Products")
            {
                query = "insert into Products (Name, Price,qty) values ('" + attributes[0] + "'," + attributes[1] + "," + attributes[2] + ")";
                q = "insert into Stock (prdct_ID ,Sup_ID,Qty,supplied_amnt)  values ((Select max(ID) from Products)," + attributes[3] + "," + attributes[4] + "," + attributes[5] + " )";
                MessageBox.Show(query);
            }
            try
            {

                MySqlDataReader r = DataBase.Query(query);
                r.Close();
                if (tableName == "Products")
                {
                    MySqlDataReader s = DataBase.Query(q);
                    s.Close();
                    return true;
                }
                return true;
            }
            catch (Exception ex)
            {
                //ex is the error 
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pbfont"></param>
        /// <param name="cbfont"></param>
        /// <param name="pdv"></param>
        /// <param name="pcFonts"></param>
        /// <returns></returns>
        /// 
        /// 
        /// *****##############Get the tables and search functions/// *********************##############

        public DataTable get()
        {
            MySqlDataReader r = DataBase.Query("Select * from " + tableName);
            DataTable result = new DataTable();
            result.Load(r);
            return result;
        }

        public DataTable getBY_ID(String id)
        {
            MySqlDataReader r = DataBase.Query("Select * from " + tableName + " where iD  = " + id + "");
            DataTable result = new DataTable();
            result.Load(r);
            r.Close();
            return result;
        }

        public DataTable get(String name)
        {
            MySqlDataReader r = DataBase.Query("Select * from " + tableName + " where Name like ('%" + name + "%')");
            DataTable result = new DataTable();
            result.Load(r);
            r.Close();
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pbfont"></param>
        /// <param name="cbfont"></param>
        /// <param name="pdv"></param>
        /// <param name="pcFonts"></param>
        /// <returns></returns>
        /// 
        /// 
        /// *****############## Updating Query area bu attribute list/// *********************##############

        public Boolean set(List<Attribute> SetAttributes, List<Attribute> WhereAttributes)
        {
            string query = "Update " + tableName + " SET ";
            for (int i = 0; i < SetAttributes.Count; i++)
            {
                if (i != SetAttributes.Count - 1)
                {
                    query += SetAttributes[i].Name + "=" + SetAttributes[i].Value + " , ";

                }
                else
                {
                    query += SetAttributes[i].Name + "=" + SetAttributes[i].Value;

                }
            }
            query += " Where ";

            for (int i = 0; i < WhereAttributes.Count; i++)
            {
                if (i != WhereAttributes.Count - 1)
                {
                    query += WhereAttributes[i].Name + "=" + WhereAttributes[i].Value + " and ";

                }
                else
                {
                    query += WhereAttributes[i].Name + "=" + WhereAttributes[i].Value;

                }
            }
            try
            {
                MySqlDataReader r = DataBase.Query(query);
                r.Close();
                return true;
            }
            catch (Exception ex)
            {
                //ex is the error object
                return false;
            }
        }

        public Boolean set(List<Attribute> SetAttributes, int whereId)
        {
            return set(SetAttributes, Attribute.fromArray(new string[] { "id", "" + whereId }));
        }

        public Boolean set(List<Attribute> SetAttributes, string WhereColumnName, string WhereColumnValue)
        {
            return set(SetAttributes, Attribute.fromArray(new string[] { WhereColumnName, WhereColumnValue }));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pbfont"></param>
        /// <param name="cbfont"></param>
        /// <param name="pdv"></param>
        /// <param name="pcFonts"></param>
        /// <returns></returns>
        /// 
        /// 
        /// *****############## Delete function/// *********************##############

        public Boolean delete(string id)
        {
            try
            {
               String query = "call tb" + tableName + " (" + id+")";
                // System.Windows.Forms.MessageBox.Show(query);
                if (System.Windows.Forms.MessageBox.Show("\nAll References May Also Be Deleted !", "Warning", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Warning)==System.Windows.Forms.DialogResult.OK)
                {
                    MySqlDataReader r = DataBase.Query(query);
                    r.Close();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                //ex is the error object
                return false;
            }
        }

    }

}
