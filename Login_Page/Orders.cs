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
    class Orders : DataBase_A.Models

    {
        public Orders() : base("Orders")
        { }
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
        /// *****############## Show order names and load the ID in combo /// *********************##############

        public DataTable show()
        {
            try
            {
                String query = "select o.ID,o.ord_Date as order_date,c.Name as Customer,e.Name as salesman from Customer c inner join Orders o on c.ID = o.cust_ID inner join Employee e on e.ID = o.emp_ID;";
                MySqlDataReader r = DataBase.Query(query);
                DataTable result = new DataTable();
                result.Load(r);
                r.Close();
                return result;
            }
            catch (Exception ex)
            { MessageBox.Show("Data is not present");
                return null;
            }
        }
        public DataTable ord_id()
        {
            try
            {

                String query = "select id from Orders";
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
        public DataTable employee_ID_List()
        {
            try
            {
                String query = "select id from Employee";
                MySqlDataReader r = DataBase.Query(query);
                DataTable result = new DataTable();
                result.Load(r);
                r.Close();
                return result;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid data", "Error");
                return null;
            }
        }
        public DataTable Cust_ID_List()
        {
            try
            {
                String query = "select id from Customer";
                MySqlDataReader r = DataBase.Query(query);
                DataTable result = new DataTable();
                result.Load(r);
                r.Close();
                return result;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid data", "Error");
                return null;
            }
        }
        public DataTable Prod_ID_List()
        {
            try
            {
                String query = "select id from Products";
                MySqlDataReader r = DataBase.Query(query);
                DataTable result = new DataTable();
                result.Load(r);
                r.Close();
                return result;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid data", "Error");
                return null;
            }
        }
        public DataTable Prod_name_list()
        {
            try
            {
                String query = "select name from Products";
                MySqlDataReader r = DataBase.Query(query);
                DataTable result = new DataTable();
                result.Load(r);
                r.Close();
                return result;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid data", "Error");
                return null;
            }
        }

        public DataTable ord_detail(String id)
        {
            try
            {

                String query = "select o.ID,p.Name as Product,p.Price,d.Qty as Quantity ,d.bill as total_Price from products p inner join ord_Drived d on d.prdct_ID = p.ID inner join Orders o on o.ID = d.ord_ID where o.ID = "+id+";";
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
        /// *****############## Total amount query/// *********************##############

        public DataTable total_Amount(String id)
        {
            try
            {

                String query = "select sum(d.bill) as Total from ord_Drived d where ord_ID = "+id+"";
                IAsyncResult r2 = DataBase.NonQuery(query);
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
        /// *****############## Add order csut and emp/// *********************##############

        public void add_new_order(String eid, String cid)
        {
            try
            {
                String query = "insert into Orders(cust_ID,emp_ID) values(" + cid + "," + eid + ");";
                MySqlDataReader r = DataBase.Query(query);
                r.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid data", "Error");
                return;
            }
        }

        public String get_max_ord_id()
        {
            try
            {
                String query = "select max(id) as max_ID from Orders";
                MySqlDataReader r = DataBase.Query(query);
                DataTable result = new DataTable();
                result.Load(r);
                r.Close();
                DataRow r1 = result.Rows[0];
                object[] o = r1.ItemArray;
                String ret = (int)o[0] + "";
                r.Close();
                return ret;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid data", "Error");
                return null;
            }
        }

        public void add_to_cart(String pname, String qty)
        {
            try
            {
                String pro_id = getProdId(pname);
                String query = "call take_order ("+pro_id+"," +qty+")";
                MySqlDataReader r = DataBase.Query(query);
                DataTable result = new DataTable();
                result.Load(r);
               
                DataRow r1 = result.Rows[0];
                object[] o = r1.ItemArray;
                String val = (String)o[0];
                var res1 = val.Trim();
                r.Close();
                if (res1.Equals("false") || res1.Equals("exist"))
                {

                    MessageBox.Show("please update the Product [ "+pname+" ]!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    r.Close();
                    return;
                }
                r.Close();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid data", "Error");
                return;
            }
        }
        public String getProdId(String pname)
        {
            try
            {

                String query = "select id from products where name = '"+pname+"'";
                MySqlDataReader r = DataBase.Query(query);
                DataTable result = new DataTable();
                result.Load(r);
                r.Close();
                DataRow r1 = result.Rows[0];
                object[] o = r1.ItemArray;
                String ret = (int)o[0] + "";
                return ret;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data is not present");
                return null;
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
        /// *****############## Generating bill and accounts/// *********************##############


        public void Accounts(String pid)
        {
            try
            {
                
                String query = "call proc_accounts ("+pid+")";
                MySqlDataReader r = DataBase.Query(query);
                r.Close();
                MessageBox.Show("Inventory Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid data", "Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        public DataTable get_top_products(String dateFrom, String dateTo)
        {
            try
            {
                string[] dateFrom1 = dateFrom.Split('/');
                dateFrom = dateFrom1[2] + '/' + dateFrom1[0] + '/' + dateFrom1[1];
                string[] dateTo1 = dateTo.Split('/');
                dateTo = dateTo1[2] + '/' + dateTo1[0] + '/' + dateTo1[1];
                String query = "call proc_popular_product ('" + dateFrom + "','" + dateTo + "')";
                MySqlDataReader r = DataBase.Query(query);
                DataTable result = new DataTable();
                result.Load(r);
                r.Close();
                return result;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Top products Not Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return null;
            }
        }

        public DataTable get_daily_Customers(String dateFrom, String dateTo)
        {
            try
            {
                string[] dateFrom1 = dateFrom.Split('/');
                dateFrom = dateFrom1[2] + '/' + dateFrom1[0] + '/' + dateFrom1[1];
                string[] dateTo1 = dateTo.Split('/');
                dateTo = dateTo1[2] + '/' + dateTo1[0] + '/' + dateTo1[1];
                String query = "call proc_Daily_customer ('" + dateFrom + "','" + dateTo + "')";
                MySqlDataReader r = DataBase.Query(query);
                DataTable result = new DataTable();
                result.Load(r);
                r.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Top customers Not Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return null;
            }
        }

        public DataTable get_Net_purchase(String dateFrom, String dateTo)
        {
            try
            {
                string[] dateFrom1 = dateFrom.Split('/');
                dateFrom = dateFrom1[2] + '/' + dateFrom1[0] + '/' + dateFrom1[1];
                string[] dateTo1 = dateTo.Split('/');
                dateTo = dateTo1[2] + '/' + dateTo1[0] + '/' + dateTo1[1];
                //MessageBox.Show("call proc_net_purchase ('" + dateFrom + "','" + dateTo + "')");
                String query = "call proc_net_purchase ('"+dateFrom+"','"+dateTo+"');";
                //String query = "select count(ID) as Total_Supplies,sum(sell_amnt)as Total_purchase_Amount from Accounts where purch_date >= str_to_date('" + dateFrom + "','m%-d%-%Y') and purch_date<= str_to_date('" + dateTo + "','m%-d%-%Y')";
                MySqlDataReader r = DataBase.Query(query);
                DataTable result = new DataTable();

;


                r.Close();
                return result;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Net Purchase Not Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return null;
            }
        }

        public DataTable get_salary()
        {
            try
            {
                String query = "select ID,Name,Salary from Employee ";
                MySqlDataReader r = DataBase.Query(query);
                DataTable result = new DataTable();
                result.Load(r);
                r.Close();
                return result;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Net Purchase Not Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return null;
            }
        }
        public DataTable get_total_salary()
        {
            try
            {
                //String query = "select count(ID) as Salesman,sum(Salary) as Month_Salary from Employee;";
                String query = "call proc_net_saleries();";
                MySqlDataReader r = DataBase.Query(query);
                DataTable result = new DataTable();
                result.Load(r);
                r.Close();
                return result;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Net Purchase Not Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return null;
            }
        }

        public DataTable get_net_sale(String dateFrom, String dateTo)
        {
            try
            {
                string[] dateFrom1 = dateFrom.Split('/');
                dateFrom = dateFrom1[2] + '/' + dateFrom1[0] + '/' + dateFrom1[1];
                string[] dateTo1 = dateTo.Split('/');
                dateTo = dateTo1[2] + '/' + dateTo1[0] + '/' + dateTo1[1];

                String query = "call proc_net_sale ('" + dateFrom + "','" + dateTo + "');";
                MySqlDataReader r = DataBase.Query(query);
                DataTable result = new DataTable();
                result.Load(r);
                r.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Net Sale Not Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return null;
            }
        }

        public DataTable get_Balance (String dateFrom, String dateTo)
        {
            try
            {
                string[] dateFrom1 = dateFrom.Split('/');
                dateFrom = dateFrom1[2] + '/' + dateFrom1[0] + '/' + dateFrom1[1];
                string[] dateTo1 = dateTo.Split('/');
                dateTo = dateTo1[2] + '/' + dateTo1[0] + '/' + dateTo1[1];
                String query = "call proc_Balance_sheet ('" + dateFrom + "','" + dateTo + "');";
                MySqlDataReader r = DataBase.Query(query);
                DataTable result = new DataTable();
                result.Load(r);
                r.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Net Sale Not Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return null;
            }
        }


        public DataTable get_account_detail(String dateFrom, String dateTo)
        {
            try
            {
                string[] dateFrom1 = dateFrom.Split('/');
                dateFrom = dateFrom1[2] + '-' + dateFrom1[0] + '-' + dateFrom1[1];
                string[] dateTo1 = dateTo.Split('/');
                dateTo = dateTo1[2] + '/' + dateTo1[0] + '/' + dateTo1[1];
                String query = "call proc_acnt_detail ('" + dateFrom + "','" + dateTo + "')";
                MySqlDataReader r = DataBase.Query(query);
                DataTable result = new DataTable();
                result.Load(r);
                r.Close();
                return result;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Net Sale Not Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return null;
            }
        }

    }

}
