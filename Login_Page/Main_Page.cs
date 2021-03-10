
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Login_Page
{
    public partial class Main_Page : Form
    {
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
        /// *********************############## REQUIRED INSTANCE VAIRABLES /// *********************##############
        /// 

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);
        FontFamily ff;
        Font font;
        DataTable dt;
        DataBase_A.Models model;
        int generate_bill = 0;

        private int childFormNumber = 0;

        public Main_Page()
        {
            InitializeComponent();
            pnl_take_order.Visible = false;
            pnl_home.Visible = true;
            pnl_home.SetBounds(336, 28, 1011, 554);
            pnl_balance_grids.Visible = false;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
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
        /// *********************############## Setting the Clock Fonts /// *********************##############
        /// 
        private void Main_Page_Load(object sender, EventArgs e)
        {
            loadFonts();
            AllocFont(font, this.Time, 48);
            AllocFont(font, this.Seconds, 20);
            AllocFont(font, this.Date, 25);
            AllocFont(font, this.Day, 25);
            Timer.Start();
        }
        /////////////////// LOading the Font ///////////////////////
        /// <summary>
        /// 
        /// </summary>

        private void loadFonts()
        {

            Byte[] fontArray = DataBase_A.Properties.Resources.digital_7;
            int datalength = DataBase_A
.Properties.Resources.digital_7.Length;

            IntPtr ptrdata = Marshal.AllocCoTaskMem(datalength);
            Marshal.Copy(fontArray, 0, ptrdata, datalength);
            uint cFonts = 0;
            AddFontMemResourceEx(ptrdata, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddMemoryFont(ptrdata, datalength);
            Marshal.FreeCoTaskMem(ptrdata);
            ff = pfc.Families[0];
            font = new Font(ff, 15f, FontStyle.Bold);


        }

        private void AllocFont(Font f, Control c, float size)
        {
            FontStyle fontStyle = FontStyle.Regular;
            c.Font = new Font(ff, size, fontStyle);


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
        /// *********************############## Button Exit /// *********************##############
        /// 
        private void btn_EXIT_App_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        /// *********************############## Clock Time Setting /// *********************##############
        /// 

        private void Timer_Tick_1(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString("HH:mm");
            Seconds.Text = DateTime.Now.ToString("ss");
            Date.Text = DateTime.Now.ToString("MMM dd yyyy");
            Day.Text = DateTime.Now.ToString("dddd");
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
        /// *********************############## Main Display Button /// *********************##############
        /// 
        private void btn_display_Main_Click(object sender, EventArgs e)
        {
            pnl_Display.SetBounds(336, 28, 1011, 554);
            pnl_Display.Visible = true;
            pnl_Cust.Visible = false;
            pnl_home.Visible = false;
            panel13.Visible = false;
            panel5.Visible = false;
            pnl_Employee_Fields.Visible = false;
            pnl_Order_fields.Visible = false;
            pnl_prod_fields.Visible = false;
            pnl_stok_fields.Visible = false;
            pnl_cust_Fields.Visible = false;
            pnl_suplier_fields.Visible = false;
            panel14.Visible = false;
            panel17.Visible = false;
            panel16.Visible = false;
            pnl_Accounts.Visible = false;
            pnl_take_order.Visible = false;
            pnl_net_profit.Visible = false;
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
        /// *********************############## Display center's Back button /// *********************##############
        /// 
        private void btn_bk_Customer_Click(object sender, EventArgs e)
        {
            btn_display_Main_Click(sender, e);
            // Cust_Combo.Items.Add("By Name");
            Cust_Combo.Text = "";

            pnl_balance_grids.Visible = false;
            pnl_Employee_Fields.Visible = false;
            pnl_Order_fields.Visible = false;
            pnl_prod_fields.Visible = false;
            pnl_stok_fields.Visible = false;
            pnl_cust_Fields.Visible = false;
            pnl_suplier_fields.Visible = false;
            btn_Cust_Update_Button.Enabled = false;
            btn_Cust_Delete.Enabled = false;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_cust_Click(object sender, EventArgs e)
        {
            btn_Home_Click(sender, e);
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
        /// *********************############## Search Key Up Even /// *********************##############
        /// 

        private void textBox_cust_search_KeyUp(object sender, KeyEventArgs e)
        {
            int i = 0;
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox_cust_search.Text != "")
                {
                    if (!Search_Data(i))
                    {
                        textBox_cust_search.Text = "";
                        get_Table();
                    }
                }
                else
                {
                    get_Table();
                    return;
                }

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
        /// *********************############## function Open Search Logic /// *********************##############
        /// 


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
        /// *********************############## function Simple Search/// *********************##############
        /// 
        private Boolean Search_Data(int i)
        {
            if (model is DataBase_A.Stock || model is DataBase_A.Orders)
            {
                if (Cust_Combo.SelectedIndex == 1)
                {
                    if (IsDigitsOnly(textBox_cust_search.Text))
                    {
                        dt = model.getBY_ID(textBox_cust_search.Text);
                        i = Convert.ToInt32(dt.Rows.Count.ToString());
                        if (i == 0)
                        {
                            MessageBox.Show("There is No ID Like " + textBox_cust_search.Text, "Search Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            return false;
                        }

                        else
                        {
                            Cust_GridView.DataSource = dt;
                            return true;

                        }
                    }
                    else
                    {
                        MessageBox.Show("ID must be in Digits ", "Incorrect Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Open search and By Id allowed here", "Something Wrong", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return false;
                }
            }
            else
            {
                if (Cust_Combo.SelectedIndex == 0)
                {
                    //MessageBox.Show("Yes");
                    if (IsAlphas_Only(textBox_cust_search.Text))
                    {
                        dt = model.get(textBox_cust_search.Text);

                        i = Convert.ToInt32(dt.Rows.Count.ToString());
                        if (i == 0)
                        {
                            MessageBox.Show("There is No Name Like " + textBox_cust_search.Text, "Search Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            return false;
                        }
                        else
                        {
                            Cust_GridView.DataSource = dt;
                            return true;
                            // MessageBox.Show("Done");
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Name must be in Alphabets ", "Incorrect Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        return false;
                    }
                }
                else if (Cust_Combo.SelectedIndex == 1)
                {
                    if (IsDigitsOnly(textBox_cust_search.Text))
                    {
                        dt = model.getBY_ID(textBox_cust_search.Text);
                        i = Convert.ToInt32(dt.Rows.Count.ToString());
                        if (i == 0)
                        {
                            MessageBox.Show("There is No ID Like " + textBox_cust_search.Text, "Search Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            return false;
                        }

                        else
                        {
                            Cust_GridView.DataSource = dt;
                            return true;

                        }
                    }
                    else
                    {
                        MessageBox.Show(" ID must be in Numbers ", "Incorrect Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        return false;
                    }

                }
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
        /// *********************############## Reset Button  /// *********************##############
        /// 
        private void btn_Cust_reset_Click(object sender, EventArgs e)
        {
            textBox_cust_search.Text = "";
            btn_Cust_Delete.Enabled = false;
            btn_Cust_Update_Button.Enabled = false;
            pnl_cust_Fields.Visible = false;
            pnl_Employee_Fields.Visible = false;

            pnl_Order_fields.Visible = false;
            pnl_prod_fields.Visible = false;
            pnl_balance_grids.Visible = false;
            pnl_suplier_fields.Visible = false;
            pnl_stok_fields.Visible = false;
            cust_Fields_clear();
            get_Table();
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
        /// *********************##############function  Display Table with Different Class Objects /// *********************##############
        /// 
        private void get_Table()
        {
            DataTable dt = model.get();
            Cust_GridView.DataSource = dt;
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
        /// *********************############## Button Search Clicked/// *********************##############
        /// 
        private void btn_Cust_search_Click(object sender, EventArgs e)
        {
            int i = 0;

            if (textBox_cust_search.Text != "")
            {
                if (!Search_Data(i))
                {
                    textBox_cust_search.Text = "";
                    get_Table();
                    //cust_Fields_clear();
                }
            }
            else
                MessageBox.Show("There Field is Empty  " + textBox_cust_search.Text, "Search Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);


        }

        //               END       CUSTOMER
        /////////////////////////////////////////Checking the String for search Mismatch/////////////////////////////////

        private static bool IsDigitsOnly(string str)
        {
            int i = 1;
            foreach (char c in str)
            {
                if (i == 1)
                {
                    if (c <= '0' || c > '9')
                    {
                        return false;
                    }
                    i++;
                }
                else if (c < '0' || c > '9')
                {
                    return false;
                }
                else
                {


                    if (Convert.ToInt32(c) > 0)
                        continue;
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static bool IsAlphas_Only(string str)
        {
            foreach (char c in str)
            {
                if (c >= '0' && c <= '9')
                    return false;
            }

            return true;
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
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
        /// *********************############## Home Button/// *********************##############
        /// 

        private void btn_Home_Click(object sender, EventArgs e)
        {
            pnl_home.Visible = true;
            pnl_home.SetBounds(336, 28, 1011, 554);
            pnl_Cust.Visible = false;
            pnl_take_order.Visible = false;
            pnl_net_profit.Visible = false;
            panel13.Visible = false;
            pnl_Employee_Fields.Visible = false;
            pnl_Order_fields.Visible = false;
            pnl_prod_fields.Visible = false;
            pnl_stok_fields.Visible = false;
            pnl_cust_Fields.Visible = false;
            pnl_suplier_fields.Visible = false;
            panel5.Visible = false;
            panel14.Visible = false;
            panel17.Visible = false;
            panel16.Visible = false;
            pnl_Accounts.Visible = false;
            pnl_Display.Visible = false;

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
        /// *********************############## Button Delete data/// *********************##############
        /// 
        private void btn_Cust_Delete_Click(object sender, EventArgs e)
        {
            if (Delete_record(Cust_GridView.Rows[Cust_GridView.CurrentCell.RowIndex].Cells[0].Value.ToString()) == true)
            {
                get_Table();

                cust_Fields_clear();

            }
            else
            {
                MessageBox.Show(" Record is not deleted ! ", "Deletion Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

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
        /// *********************############## Clearing the all textboxes used/// *********************##############
        /// 
        private void cust_Fields_clear()
        {
            text_Cust_Name.Text = "";
            text_Cust_Phn.Text = "";
            text_Cust_Grad_Combo.Text = "";
            text_Cust_City.Text = "";
            text_Cust_Address.Text = "";
            text_Cust_Email.Text = "";

            text_emp_Name.Text = "";
            Text_emp_phn.Text = "";
            Text_emp_Address.Text = "";
            Text_emp_City.Text = "";
            Text_emp_Email.Text = "";
            Text_emp_Sal.Text = "";
            ///////
            Text_prod_price.Text = "";
            Text_prod_Name.Text = "";
            text_prod_stor_qty.Text = "";
            Comb_ord_custID.Text = "";
            text_ord_date.Text = "";
            Comb_ord_salesID.Text = "";
            /////////////////////////////
            text_sup_Name.Text = "";
            text_sup_phn.Text = "";

            text_sup_city.Text = "";
            text_sup_Address.Text = "";

            ////////////////////////////
            Text_stock_prod_qty.Text = "";
            comb_stok_sup_ID.Text = "";
            comb_stok_prod_ID.Text = "";
            Text_stok_sell.Text = "";
            ////////////////////////////
            ///
            textBox6.Text = "";
            textBox28.Text = "";
            textBox7.Text = "";
            // Combo_Employer.Text = "";
            textBox9.Text = "";
            textBox27.Text = "";
            textBox26.Text = "";
            ////////////////////////////
            ///
            comboBox1.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";

            textBox14.Text = "";
            textBox29.Text = "";
            textBox30.Text = "";
            /////////////////////
            ///
            textBox25.Text = "";
            textBox22.Text = "";

            textBox24.Text = "";
            textBox33.Text = "";

            textBox30.Text = "";
            /////////////////////
            ///
            textBox21.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            comboBox2.Text = "";

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
        /// *********************############## delet record function/// *********************##############
        /// 
        private bool Delete_record(String id)
        {
            try
            {
                if (MessageBox.Show(" Delete the Selected Row_Record ?", "Record Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (model.delete(id))
                    {
                        MessageBox.Show("\nRecord Successfully Deleted", "Completed", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        cust_Fields_clear();

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("this field has refrence in other tables");
            }
            return false;
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
        /// *********************############## Grid cell Clicked Event handling all the Entity objects/// *********************##############
        /// 
        private void Cust_GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (model is DataBase_A.Customers)
            {
                if (e.RowIndex >= 0)
                {

                    pnl_cust_Fields.Visible = true;
                    pnl_prod_fields.Visible = false;
                    pnl_stok_fields.Visible = false;
                    pnl_cust_Fields.SetBounds(197, 321, 804, 230);
                    pnl_Order_fields.Visible = false;
                    pnl_suplier_fields.Visible = false;

                    int index = e.RowIndex;
                    pnl_Employee_Fields.Visible = false;
                    text_Cust_Name.Text = Cust_GridView.Rows[index].Cells[1].Value.ToString();
                    text_Cust_Email.Text = Cust_GridView.Rows[index].Cells[2].Value.ToString();
                    text_Cust_Address.Text = Cust_GridView.Rows[index].Cells[3].Value.ToString();
                    text_Cust_City.Text = Cust_GridView.Rows[index].Cells[4].Value.ToString();
                    text_Cust_Phn.Text = Cust_GridView.Rows[index].Cells[5].Value.ToString();
                    text_Cust_Grad_Combo.Text = Cust_GridView.Rows[index].Cells[6].Value.ToString();
                }
            }
            else if (model is DataBase_A.Employees)
            {
                if (e.RowIndex >= 0)
                {
                    pnl_Employee_Fields.SetBounds(199, 316, 802, 235);
                    pnl_Employee_Fields.Visible = true;
                    pnl_prod_fields.Visible = false;
                    pnl_Order_fields.Visible = false;
                    pnl_cust_Fields.Visible = false;
                    pnl_stok_fields.Visible = false;
                    pnl_suplier_fields.Visible = false;

                    int index = e.RowIndex;
                    text_emp_Name.Text = Cust_GridView.Rows[index].Cells[1].Value.ToString();
                    Text_emp_Email.Text = Cust_GridView.Rows[index].Cells[2].Value.ToString();
                    Text_emp_phn.Text = Cust_GridView.Rows[index].Cells[3].Value.ToString();
                    Text_emp_Address.Text = Cust_GridView.Rows[index].Cells[4].Value.ToString();
                    Text_emp_City.Text = Cust_GridView.Rows[index].Cells[5].Value.ToString();
                    Text_emp_Sal.Text = Cust_GridView.Rows[index].Cells[6].Value.ToString();
                    Datepk_Emp_hire.Text = Cust_GridView.Rows[index].Cells[7].Value.ToString();
                }
            }
            else if (model is DataBase_A.Products)
            {
                if (e.RowIndex >= 0)
                {
                    pnl_prod_fields.SetBounds(197, 321, 804, 230);
                    pnl_prod_fields.Visible = true;
                    pnl_Employee_Fields.Visible = false;
                    pnl_stok_fields.Visible = false;
                    pnl_suplier_fields.Visible = false;
                    pnl_cust_Fields.Visible = false;
                    pnl_Order_fields.Visible = false;
                    btn_prod_update.Enabled = true;


                    int index = e.RowIndex;
                    Text_prod_Name.Text = Cust_GridView.Rows[index].Cells[1].Value.ToString();
                    Text_prod_price.Text = Cust_GridView.Rows[index].Cells[2].Value.ToString();
                    text_prod_stor_qty.Text = Cust_GridView.Rows[index].Cells[3].Value.ToString();

                }

            }
            else if (model is DataBase_A.Orders)
            {
                if (e.RowIndex >= 0)
                {
                    pnl_Order_fields.SetBounds(183, 315, 813, 231);
                    pnl_Order_fields.Visible = true;
                    pnl_Employee_Fields.Visible = false;
                    pnl_cust_Fields.Visible = false;
                    pnl_stok_fields.Visible = false;
                    pnl_suplier_fields.Visible = false;
                    pnl_prod_fields.Visible = false;
                    btn_ord_show.Enabled = true;

                    int index = e.RowIndex;

                    text_ord_date.Text = Cust_GridView.Rows[index].Cells[3].Value.ToString();
                    // get the combo box fill

                    DataBase_A.Orders ord = new DataBase_A.Orders();
                    DataTable dt = ord.employee_ID_List();
                    DataTable dt1 = ord.Cust_ID_List();
                    DataTable dt2 = ord.ord_id();


                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Comb_ord_salesID.Items.Add(dt.Rows[i]["ID"]);

                    }
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        Comb_ord_custID.Items.Add(dt1.Rows[i]["ID"]);

                    }
                    for (int i = 0; i < dt2.Rows.Count; i++)
                    {
                        comb_ord_detail.Items.Add(dt2.Rows[i]["ID"]);

                    }


                    Comb_ord_salesID.Text = Cust_GridView.Rows[index].Cells[2].Value.ToString();
                    Comb_ord_custID.Text = Cust_GridView.Rows[index].Cells[1].Value.ToString();
                }
            }
            else if (model is DataBase_A.Supliers)
            {
                if (e.RowIndex >= 0)
                {

                    pnl_cust_Fields.Visible = false;
                    pnl_prod_fields.Visible = false;
                    pnl_suplier_fields.Visible = true;
                    pnl_stok_fields.Visible = false;
                    pnl_suplier_fields.SetBounds(197, 321, 804, 230);
                    pnl_Order_fields.Visible = false;

                    int index = e.RowIndex;
                    pnl_Employee_Fields.Visible = false;
                    text_sup_Name.Text = Cust_GridView.Rows[index].Cells[1].Value.ToString();
                    text_sup_Address.Text = Cust_GridView.Rows[index].Cells[2].Value.ToString();
                    text_sup_city.Text = Cust_GridView.Rows[index].Cells[3].Value.ToString();
                    text_sup_phn.Text = Cust_GridView.Rows[index].Cells[4].Value.ToString();
                }
            }
            else if (model is DataBase_A.Stock)
            {
                if (e.RowIndex >= 0)
                {
                    pnl_stok_fields.SetBounds(197, 325, 790, 209);
                    pnl_stok_fields.Visible = true;
                    pnl_Employee_Fields.Visible = false;
                    pnl_suplier_fields.Visible = false;
                    pnl_cust_Fields.Visible = false;
                    pnl_Order_fields.Visible = false;
                    pnl_prod_fields.Visible = false;


                    int index = e.RowIndex;
                    Text_stock_prod_qty.Text = Cust_GridView.Rows[index].Cells[3].Value.ToString();
                    Text_stok_sell.Text = Cust_GridView.Rows[index].Cells[4].Value.ToString();
                    // get the combo box fill
                    DataBase_A.Supliers sup = new DataBase_A.Supliers();
                    // prod id in order class
                    DataBase_A.Orders ord = new DataBase_A.Orders();

                    DataTable dt1 = ord.Prod_ID_List();

                    DataTable dt = sup.supplier_ID_List();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        comb_stok_sup_ID.Items.Add(dt.Rows[i]["ID"]);
                    }
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        comb_stok_prod_ID.Items.Add(dt1.Rows[i]["ID"]);
                    }
                    comb_stok_prod_ID.Text = Cust_GridView.Rows[index].Cells[1].Value.ToString();
                    comb_stok_sup_ID.Text = Cust_GridView.Rows[index].Cells[2].Value.ToString();

                }

            }
            btn_Cust_Delete.Enabled = true;
            btn_Cust_Update_Button.Enabled = true;
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
        /// *********************############## Button Update logic with all the Entity Objects/// *********************##############
        /// 

        private void btn_Cust_Update_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (model is DataBase_A.Customers)
                {

                    if (IsAlphas_Only(text_Cust_Name.Text) && IsAlphas_Only(text_Cust_City.Text) && IsDigitsOnly(text_Cust_Phn.Text) && IsValidEmail(text_Cust_Email.Text))
                    {
                        String[] ar = { "Name", "'" + text_Cust_Name.Text + "'", "Email", "'" + text_Cust_Email.Text + "'", "Adress", "'" + text_Cust_Address.Text + "'", "City", "'" + text_Cust_City.Text + "'", "PhoneNumber", text_Cust_Phn.Text, "Grade", "'" + text_Cust_Grad_Combo.Text + "'" };
                        List<DataBase_A.Attribute> cust_record = DataBase_A.Attribute.fromArray(ar);

                        Update_Customer(cust_record);
                        cust_Fields_clear();
                        get_Table();
                    }
                    else
                    {
                        MessageBox.Show(" Mismatch in Data Correction ! ", "Updated Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        cust_Fields_clear();
                    }
                }
                else if (model is DataBase_A.Employees)
                {
                    if (IsAlphas_Only(text_emp_Name.Text) && IsAlphas_Only(Text_emp_City.Text) && IsDigitsOnly(Text_emp_phn.Text) && IsValidEmail(Text_emp_Email.Text) && IsDigitsOnly(Text_emp_Sal.Text))
                    {
                        String[] ar = { "Name", "'" + text_emp_Name.Text + "'", "Email", "'" + Text_emp_Email.Text + "'", "Adress", "'" + Text_emp_Address.Text + "'", "City", "'" + Text_emp_City.Text + "'", "PhoneNumber", Text_emp_phn.Text, "Salary", Text_emp_Sal.Text, "HireDate", "'" + Datepk_Emp_hire.Text + "'" };
                        List<DataBase_A.Attribute> cust_record = DataBase_A.Attribute.fromArray(ar);

                        Update_Customer(cust_record);
                        cust_Fields_clear();
                        get_Table();
                    }
                    else
                    {
                        MessageBox.Show(" Mismatch in Data Correction ! ", "Updated Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        cust_Fields_clear();
                    }

                }
                else if (model is DataBase_A.Products)
                {
                    if (IsAlphas_Only(Text_prod_Name.Text) && IsDigitsOnly(Text_prod_price.Text) && IsDigitsOnly(text_prod_stor_qty.Text))
                    {
                        String[] ar = { "Name", "'" + Text_prod_Name.Text + "'", "Price", Text_prod_price.Text, "qty", text_prod_stor_qty.Text };
                        List<DataBase_A.Attribute> cust_record = DataBase_A.Attribute.fromArray(ar);

                        Update_Customer(cust_record);
                        cust_Fields_clear();
                        get_Table();
                    }
                    else
                    {
                        MessageBox.Show(" Mismatch in Data Correction ! ", "Updated Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        cust_Fields_clear();
                    }

                }
                else if (model is DataBase_A.Orders)
                {
                    if (Comb_ord_custID.Text != "" && Comb_ord_salesID.Text != "")
                    {
                        String[] ar = { "cust_ID", Comb_ord_custID.Text, "emp_ID", Comb_ord_salesID.Text };
                        List<DataBase_A.Attribute> cust_record = DataBase_A.Attribute.fromArray(ar);

                        Update_Customer(cust_record);
                        cust_Fields_clear();
                        get_Table();
                    }
                    else
                    {
                        MessageBox.Show(" Mismatch in Data Correction ! ", "Updated Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        cust_Fields_clear();
                    }

                }
                else if (model is DataBase_A.Supliers)
                {


                    if (IsAlphas_Only(text_sup_Name.Text) && IsAlphas_Only(text_sup_city.Text) && IsDigitsOnly(text_sup_phn.Text))
                    {
                        String[] ar = { "Name", "'" + text_sup_Name.Text + "'", "adress", "'" + text_sup_Address.Text + "'", "City", "'" + text_sup_city.Text + "'", "PhoneNumber", text_sup_phn.Text };
                        List<DataBase_A.Attribute> cust_record = DataBase_A.Attribute.fromArray(ar);

                        Update_Customer(cust_record);
                        cust_Fields_clear();
                        get_Table();
                    }
                    else
                    {
                        MessageBox.Show(" Mismatch in Data Correction ! ", "Updated Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        cust_Fields_clear();
                    }
                }
                else if (model is DataBase_A.Stock)
                {
                    if (IsDigitsOnly(Text_stock_prod_qty.Text) && IsDigitsOnly(Text_stok_sell.Text))
                    {
                        String[] ar = { "prdct_ID", comb_stok_prod_ID.Text, "Sup_ID", comb_stok_sup_ID.Text, "Qty", Text_stock_prod_qty.Text, "supplied_amnt", Text_stok_sell.Text };
                        List<DataBase_A.Attribute> cust_record = DataBase_A.Attribute.fromArray(ar);

                        Update_Customer(cust_record);
                        cust_Fields_clear();
                        get_Table();
                    }
                    else
                    {
                        MessageBox.Show(" Mismatch in Data Correction ! ", "Updated Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        cust_Fields_clear();
                    }

                }
                else
                {
                    MessageBox.Show(" Mismatch in Data Correction ! ", "Updated Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    cust_Fields_clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Something is not valid ! ", "Error Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
        /// *********************############## function to create update list attributes/// *********************##############
        /// 
        private void Update_Customer(List<DataBase_A.Attribute> record)
        {
            try
            {

                if (model.set(record, Convert.ToInt32(Cust_GridView.Rows[Cust_GridView.CurrentCell.RowIndex].Cells[0].Value.ToString())))
                {
                    MessageBox.Show(" Record Successfully Updated ! ", "Updated Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show(" Updation is not possible ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show(" Updation is not possible", "Incorrect Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);


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
        /// *********************############## BUttons to display all /// *********************##############
        /// 

        private void btn_Order_View_Click(object sender, EventArgs e)
        {
            model = new DataBase_A.Orders();
            pnl_Cust.SetBounds(336, 28, 1011, 554);
            get_Table();
            Cust_Combo.Text = "";
            panel13.Visible = false;
            panel5.Visible = false;
            panel14.Visible = false;
            panel17.Visible = false;
            panel16.Visible = false;
            pnl_Cust.Visible = true;
            pnl_balance_grids.Visible = false;
            pnl_take_order.Visible = false;
            pnl_Accounts.Visible = false;
            pnl_Display.Visible = false;
            pnl_home.Visible = false;

            lbl_Record_Name.Text = "ORDERS RECORD";
        }

        private void btn_Emp_view_Click(object sender, EventArgs e)
        {
            model = new DataBase_A.Employees();
            pnl_Cust.SetBounds(336, 28, 1011, 554);
            get_Table();
            Cust_Combo.Text = "";
            pnl_Cust.Visible = true;
            pnl_take_order.Visible = false;
            pnl_balance_grids.Visible = false;
            pnl_Accounts.Visible = false;
            pnl_Display.Visible = false;
            pnl_home.Visible = false;
            lbl_Record_Name.Text = "STAFF RECORD";
        }

        private void btn_prod_view_Click(object sender, EventArgs e)
        {
            model = new DataBase_A.Products();
            pnl_Cust.SetBounds(336, 28, 1011, 554);
            get_Table();
            Cust_Combo.Text = "";
            pnl_take_order.Visible = false;
            pnl_Accounts.Visible = false;
            pnl_balance_grids.Visible = false;
            pnl_Cust.Visible = true;
            pnl_Display.Visible = false;
            pnl_home.Visible = false;
            lbl_Record_Name.Text = "PRODUCTS RECORD";
        }

        private void btn_Suplier_view_Click(object sender, EventArgs e)
        {
            model = new DataBase_A.Supliers();
            pnl_Cust.SetBounds(336, 28, 1011, 554);
            get_Table();
            Cust_Combo.Text = "";
            pnl_Cust.Visible = true;
            pnl_take_order.Visible = false;
            pnl_Accounts.Visible = false;
            pnl_balance_grids.Visible = false;
            pnl_Display.Visible = false;
            pnl_home.Visible = false;
            lbl_Record_Name.Text = "SUPPLIERS RECORD";
        }

        private void btn_Stok_View_Click(object sender, EventArgs e)
        {
            model = new DataBase_A.Stock();
            pnl_Cust.SetBounds(336, 28, 1011, 554);
            pnl_take_order.Visible = false;
            get_Table();
            Cust_Combo.Text = "";
            pnl_Cust.Visible = true;
            pnl_balance_grids.Visible = false;
            pnl_Accounts.Visible = false;
            pnl_Display.Visible = false;
            pnl_home.Visible = false;
            lbl_Record_Name.Text = "STOCK RECORD";
        }
        private void btn_Cust_View_Click(object sender, EventArgs e)
        {

            model = new DataBase_A.Customers();
            pnl_Cust.SetBounds(336, 28, 1011, 554);
            get_Table();
            Cust_Combo.Text = "";
            pnl_take_order.Visible = false;
            pnl_Accounts.Visible = false;
            pnl_Cust.Visible = true;
            panel13.Visible = false;
            panel5.Visible = false;
            panel14.Visible = false;
            panel17.Visible = false;
            panel16.Visible = false;
            pnl_balance_grids.Visible = false;
            pnl_Display.Visible = false;
            pnl_home.Visible = false;
            lbl_Record_Name.Text = "CUSTOMERS RECORD";

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
        /// *********************##############Main add button to add data /// *********************##############
        /// 
        private void btn_Add_main_Click(object sender, EventArgs e)
        {
            panel5.SetBounds(336, 28, 1011, 554);
            panel5.Visible = true;
            panel14.Visible = false;
            panel13.Visible = false;
            pnl_Cust.Visible = false;
            pnl_Display.Visible = false;
            pnl_Employee_Fields.Visible = false;
            pnl_Order_fields.Visible = false;
            pnl_prod_fields.Visible = false;
            pnl_stok_fields.Visible = false;
            pnl_cust_Fields.Visible = false;
            pnl_suplier_fields.Visible = false;
            pnl_take_order.Visible = false;
            pnl_home.Visible = false;
            pnl_Accounts.Visible = false;
            pnl_net_profit.Visible = false;
            panel16.Visible = false;
            panel17.Visible = false;
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
        /// *********************############## To show the detail of the Orders and stock /// *********************##############
        /// 


        private void btn_stok_show_Click(object sender, EventArgs e)
        {
            DataBase_A.Stock ord = new DataBase_A.Stock();
            DataTable dt = ord.show();
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
        /// *********************############## BUttons Take Orders /// *********************##############
        /// 
        private void btn_Take_Order_Click(object sender, EventArgs e)
        {
            pnl_take_order.Visible = true;
            pnl_take_order.SetBounds(336, 28, 1011, 554);
            pnl_Cust.Visible = false;
            pnl_Display.Visible = false;
            pnl_home.Visible = false;
            pnl_Accounts.Visible = false;
            pnl_Employee_Fields.Visible = false;
            pnl_Order_fields.Visible = false;
            pnl_prod_fields.Visible = false;
            pnl_stok_fields.Visible = false;
            pnl_cust_Fields.Visible = false;
            pnl_suplier_fields.Visible = false;
            pnl_net_profit.Visible = false;
            panel13.Visible = false;
            panel5.Visible = false;
            panel14.Visible = false;
            panel17.Visible = false;
            panel16.Visible = false;
            set_emp_cust_Combo();

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
        /// *********************############## Combo box loading /// *********************##############
        /// 
        private void set_emp_cust_Combo()
        {
            DataBase_A.Orders ord = new DataBase_A.Orders();
            DataTable dt = ord.employee_ID_List();
            DataTable dt1 = ord.Cust_ID_List();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comb_ord_taking_empID.Items.Add(dt.Rows[i]["ID"]);
            }
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                comb_ord_taking_custID.Items.Add(dt1.Rows[i]["ID"]);
            }

        }
        private void get_prodName_list()
        {
            DataBase_A.Orders ord = new DataBase_A.Orders();
            DataTable dt = ord.Prod_name_list();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comb_add_cart_prodName.Items.Add(dt.Rows[i]["name"]);
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
        /// *********************############## Add order to start Cart and bill and Receipt/// *********************##############
        /// 
        private void btn_addOrder_Click(object sender, EventArgs e)
        {
            if (comb_ord_taking_custID.Text != "" && comb_ord_taking_empID.Text != "")
            {

                pnl_Add_cart.Visible = true;
                get_prodName_list();
                comb_ord_taking_empID.Enabled = false;
                comb_ord_taking_custID.Enabled = false;
                DataBase_A.Orders ord = new DataBase_A.Orders();
                ord.add_new_order(comb_ord_taking_empID.Text, comb_ord_taking_custID.Text);
                btn_addOrder.Enabled = false;

            }
            else
            {
                MessageBox.Show("Both Customer and Salesman ID's are required ", "Something Wromg", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
        }


        private void btn_add_cart_Click(object sender, EventArgs e)
        {

            if (IsDigitsOnly(text_add_cart_prodQTY.Text))
            {
                DataBase_A.Orders ord = new DataBase_A.Orders();
                ord.add_to_cart(comb_add_cart_prodName.Text, text_add_cart_prodQTY.Text);
                comb_add_cart_prodName.Text = "";
                text_add_cart_prodQTY.Text = "";
                generate_bill = 1;

            }
            else
                MessageBox.Show("Quantity Must be in Numbers", "Something Wrong", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

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
        /// *****############## Update the product and add detail of supply to the Accounts/// *********************##############

        private void btn_prod_update_Click(object sender, EventArgs e)
        {
            new DataBase_A.Orders().Accounts(Cust_GridView.Rows[Cust_GridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
            get_Table();
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
        /// *****############## setting the balance sheet tables/// *********************##############


        private void btn_get_Sheet_Click(object sender, EventArgs e)
        {
            DataBase_A.Orders ord = new DataBase_A.Orders();
            grid_net_purchase.DataSource = ord.get_Net_purchase(Datepick_from.Text, datepick_to.Text);
            grid_net_sale.DataSource = ord.get_net_sale(Datepick_from.Text, datepick_to.Text);
            grid_salesman_salary.DataSource = ord.get_salary();

            DataTable dt = ord.get_total_salary();
            DataRow dr = dt.Rows[0];
            object[] o = dr.ItemArray;
            text_salesMan_count.Text = o[0] + "";
            text_salesman_total_sal.Text = o[1] + "";
            dt = ord.get_Balance(Datepick_from.Text, datepick_to.Text);
            dr = dt.Rows[0];
            o = dr.ItemArray;
            Text_balance.Text = o[0] + "";
            pnl_balance_grids.Visible = true;
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
        /// *****############## Button accounts and show all tables data/// *********************##############

        private void button8_Click(object sender, EventArgs e)
        {

            pnl_Cust.Visible = false;
            pnl_take_order.Visible = false;
            pnl_top_details.Visible = false;
            pnl_Employee_Fields.Visible = false;
            pnl_Order_fields.Visible = false;
            pnl_prod_fields.Visible = false;
            pnl_stok_fields.Visible = false;
            pnl_cust_Fields.Visible = false;
            pnl_suplier_fields.Visible = false;
            pnl_net_profit.Visible = false;
            panel13.Visible = false;
            panel5.Visible = false;
            panel14.Visible = false;
            panel17.Visible = false;
            panel16.Visible = false;
            pnl_Display.Visible = false;
            pnl_home.Visible = false;
            pnl_Accounts.SetBounds(336, 28, 1011, 554);
            pnl_Accounts.Visible = true;

        }

        private void btn_show_top_Click(object sender, EventArgs e)
        {
            pnl_top_details.Visible = true;
            DataBase_A.Orders ord = new DataBase_A.Orders();
            DataTable dt = ord.get_top_products(datepk_top_from.Text, datepk_top_to.Text);
            grid_top_prodct.DataSource = dt;

            dt = ord.get_daily_Customers(datepk_top_from.Text, datepk_top_to.Text);
            grid_top_cust.DataSource = dt;

            dt = ord.get_account_detail(datepk_top_from.Text, datepk_top_to.Text);
            grid_purch_detail.DataSource = dt;
        }

        private void Net_sale_Click(object sender, EventArgs e)
        {
            pnl_net_profit.Visible = true;
            pnl_net_profit.SetBounds(336, 28, 1011, 554);
            pnl_balance_grids.Visible = false;
            pnl_Employee_Fields.Visible = false;
            pnl_Order_fields.Visible = false;
            pnl_prod_fields.Visible = false;
            pnl_stok_fields.Visible = false;
            pnl_cust_Fields.Visible = false;
            pnl_suplier_fields.Visible = false;
            pnl_Cust.Visible = false;
            pnl_take_order.Visible = false;
            pnl_Display.Visible = false;
            pnl_home.Visible = false;
            panel13.Visible = false;
            panel5.Visible = false;
            panel14.Visible = false;
            panel17.Visible = false;
            panel16.Visible = false;
            pnl_Accounts.Visible = false;
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
        /// *****############## Add data start/// *********************##############


        private void btn_add_employee_Click(object sender, EventArgs e)
        {
            panel13.SetBounds(336, 28, 1011, 554);
            panel13.Visible = true;
            panel5.Visible = false;
            panel14.Visible = false;
            panel17.Visible = false;
            panel16.Visible = false;
        }

        private void tbn_add_product_Click(object sender, EventArgs e)
        {
            panel16.SetBounds(336, 28, 1011, 554);

            DataBase_A.Supliers sup = new DataBase_A.Supliers();
            DataTable dt = sup.supplier_ID_List();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox2.Items.Add(dt.Rows[i]["ID"]);
            }
            panel16.Visible = true;
            panel5.Visible = false;
            panel14.Visible = false;
            panel17.Visible = false;
        }

        private void btn_add_customer_Click(object sender, EventArgs e)
        {
            panel14.SetBounds(336, 28, 1011, 554);
            panel14.Visible = true;
            panel5.Visible = false;
            panel17.Visible = false;
            panel16.Visible = false;
        }

        private void btn_add_suplier_Click(object sender, EventArgs e)
        {
            panel17.SetBounds(336, 28, 1011, 554);
            panel17.Visible = true;
            panel5.Visible = false;
            panel14.Visible = false;
            panel16.Visible = false;
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
        /// *****############## Data entry to add the records/// *********************##############

        private void btn_add_emplyee_data_Click(object sender, EventArgs e)
        {



            if (String.IsNullOrEmpty(textBox6.Text) || String.IsNullOrEmpty(textBox7.Text) || String.IsNullOrEmpty(textBox28.Text) || String.IsNullOrEmpty(this.dateTimePicker1.Text) || String.IsNullOrEmpty(textBox26.Text))

            {

                MessageBox.Show("Enter * Fields Please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //dataGridView1.Rows.Clear();
            }
            else if (IsAlphas_Only(textBox6.Text) && IsDigitsOnly(textBox7.Text) && IsAlphas_Only(textBox28.Text) && ((textBox9.Text != "" && IsValidEmail(textBox9.Text)) || textBox9.Text == "") && IsDigitsOnly(textBox27.Text))

            {
                List<String> ls = new List<string>(8);
                ls.Add(textBox6.Text);/*Name*/
                ls.Add(textBox9.Text);/*Email*/
                ls.Add(textBox27.Text);/*PhoneNumber*/
                ls.Add(textBox26.Text);/*address*/
                ls.Add(textBox28.Text);/*City*/
                ls.Add(textBox7.Text);/*Salary*/
                ls.Add(this.dateTimePicker1.Text);/*HireDate*/
                if (new DataBase_A.Employees().insert(ls))
                {
                    MessageBox.Show("Data Entered Successfully ");
                    cust_Fields_clear();
                }
                else
                    MessageBox.Show("Sorry, data can not be entered");

            }
            else
            {
                MessageBox.Show("Mismatch data please Enter the Correct data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_add_cust_data_Click(object sender, EventArgs e)
        {



            if (String.IsNullOrEmpty(textBox13.Text) || String.IsNullOrEmpty(textBox12.Text) || String.IsNullOrEmpty(textBox29.Text))

            {
                MessageBox.Show("Enter * Fields Please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //dataGridView1.Rows.Clear();
            }
            else if (IsAlphas_Only(textBox13.Text) && IsAlphas_Only(textBox12.Text) && IsDigitsOnly(textBox14.Text) && ((textBox30.Text != "" && IsValidEmail(textBox30.Text)) || textBox30.Text == ""))

            {
                List<String> ls1 = new List<string>(7);
                ls1.Add(textBox13.Text);
                ls1.Add(textBox30.Text);
                ls1.Add(textBox29.Text);

                ls1.Add(textBox12.Text);
                ls1.Add(textBox14.Text);
                ls1.Add(comboBox1.Text);
                if (new DataBase_A.Customers().insert(ls1))
                {
                    MessageBox.Show("Data Entered Successfully ");
                    cust_Fields_clear();
                }
                else
                    MessageBox.Show("Sorry, data can not be entered");


            }
            else
                MessageBox.Show("Mismatch Data PLease Enter the Correct data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_add_suplier_data_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(textBox25.Text) || String.IsNullOrEmpty(textBox22.Text) || String.IsNullOrEmpty(textBox24.Text))

            {
                MessageBox.Show("Enter * Fields Please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //dataGridView1.Rows.Clear();
            }
            else if (!IsAlphas_Only(textBox25.Text))
            {
                MessageBox.Show("Enter name in AlphaBats", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!IsAlphas_Only(textBox22.Text))
            {
                MessageBox.Show("Enter city name in AlphaBats", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!IsDigitsOnly(textBox33.Text))
            {
                MessageBox.Show("Enter Phone Number In Digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                List<String> ls2 = new List<string>(4);
                ls2.Add(textBox25.Text);/*name*/
                ls2.Add(textBox24.Text);/*Address*/
                ls2.Add(textBox22.Text);/*Cty*/
                ls2.Add(textBox33.Text);/*PhoneNo*/
                if (new DataBase_A.Supliers().insert(ls2))
                {
                    MessageBox.Show("Data Entered Successfully ");
                    cust_Fields_clear();
                }
                else
                    MessageBox.Show("Sorry, data can not be entered");

            }

        }

        private void btn_add_product_data_Click(object sender, EventArgs e)
        {


            if (textBox21.Text == "" || textBox20.Text == "" || textBox19.Text == "" || comboBox2.Text == "" || textBox4.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Enter * Fields Please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (IsAlphas_Only(textBox21.Text) && IsDigitsOnly(textBox20.Text) && IsDigitsOnly(textBox19.Text) && IsDigitsOnly(comboBox2.Text) && IsDigitsOnly(textBox3.Text))
            {
                List<String> ls3 = new List<string>(6);
                ls3.Add(textBox21.Text);
                ls3.Add(textBox20.Text);
                ls3.Add(textBox19.Text);
                //ls3.Add(textBox1.Text);
                ls3.Add(comboBox2.Text);
                ls3.Add(textBox4.Text);
                ls3.Add(textBox3.Text);
                if (new DataBase_A.Products().insert(ls3))
                {
                    MessageBox.Show("Data Entered Successfully ");
                    cust_Fields_clear();
                }
                else
                    MessageBox.Show("Record is not entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                MessageBox.Show("Mismatched data please enter correct data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
        /// *****############## Button back and clear fields  *********************##############

        private void btn_back_from_add_emp_Click(object sender, EventArgs e)
        {
            btn_Add_main_Click(sender, e);
        }

        private void btn_clear_employee_Click(object sender, EventArgs e)
        {
            cust_Fields_clear();
        }

        private void btn_back_from_add_cust_Click(object sender, EventArgs e)
        {
            btn_Add_main_Click(sender, e);
        }

        private void btn_clear_cust_fields_Click(object sender, EventArgs e)
        {
            cust_Fields_clear();
        }

        private void btn_back_from_supplier_Click(object sender, EventArgs e)
        {
            btn_Add_main_Click(sender, e);
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_clear_suplier_fields_Click(object sender, EventArgs e)
        {
            cust_Fields_clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_Add_main_Click(sender, e);
        }

        private void btn_product_clear_fields_Click(object sender, EventArgs e)
        {
            cust_Fields_clear();
        }

        private void pnl_Cust_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_top_details_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

