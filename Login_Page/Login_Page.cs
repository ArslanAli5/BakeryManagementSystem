using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Page
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (text_user_name.Text != "" && IsAlphas_Only(text_user_name.Text) && text_paswrd.Text != "")
            {
                DataBase_A.Login_Class log = new DataBase_A.Login_Class();

                if (log.validate(text_user_name.Text, text_paswrd.Text))
                {
                    DataBase_A.Loading_Page pg = new DataBase_A.Loading_Page();
                    pg.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid UserName or Password ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
            // }
            else
            {
                MessageBox.Show("please enter correct username and password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
            }

        }

        private void Clear()
        {
            text_paswrd.Text = "";
            text_user_name.Text = "";
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void btn_Forget_Click(object sender, EventArgs e)
        {
            if (text_user_name.Text == "")
            {
                MessageBox.Show("Enter remembered UserName Characters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                if (IsAlphas_Only(text_user_name.Text))
                {
                    DataBase_A.Login_Class hint = new DataBase_A.Login_Class();

                    if (hint.forget(text_user_name.Text) != null)
                    {
                        MessageBox.Show(hint.forget(text_user_name.Text), "HINT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("User does not Exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        Clear();

                    }
                }
                else
                {
                    MessageBox.Show("User Name must be in Alphabets.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                Clear();
            }




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

        private void btn_Sign_up_Click(object sender, EventArgs e)
        {
            pnl_signUp.Visible = true;
            pnl_signUp.SetBounds(507, 197, 290, 250);
            btn_Sign_up.Enabled = false;
        }

        private void btn_signUp_back_Click(object sender, EventArgs e)
        {
            pnl_signUp.Visible = false;
            btn_Sign_up.Enabled = true;

        }

        private void btn_register_user_Click(object sender, EventArgs e)
        {
            if (text_signUP_username.Text != "" && IsAlphas_Only(text_signUP_username.Text) && text_signUp_paswrd.Text != "")
            {
                DataBase_A.Login_Class register = new DataBase_A.Login_Class();

                if (register.signUp(text_signUP_username.Text, text_signUp_paswrd.Text))
                {
                    MessageBox.Show("Successfully Registerd The User", "REGISTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Clear();
                }
                else
                {
                    MessageBox.Show("User does not Exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Clear();

                }
            }
            else if (!IsAlphas_Only(text_signUP_username.Text))
            {
                MessageBox.Show("UserName Must be in Alphabets.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else
            {
                MessageBox.Show("Both Fields are required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void text_paswrd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
