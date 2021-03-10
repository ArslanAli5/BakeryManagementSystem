using Login_Page;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_A
{
    public partial class Loading_Page : Form
    {
        Timer timer1 = new Timer();
        int i = 0;
        public Loading_Page()
        {
            InitializeComponent();
            panel2.Left = 0;
        }
        int plus = 1;

        private void Loading_Page_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(move);
            timer1.Interval = 10;
            timer1.Start();
        }
        void move(object sender, EventArgs e)
        {
            i++;
            panel2.Left += plus;
            if (panel2.Left > 250)
            {
                plus = -1;
            }
            if (panel2.Left < 120)
            {
                plus = 1;
            }
            if (i == 250)
            {
                this.Close();
                Main_Page main = new Main_Page();

                this.Hide();
                main.Show();
            }
        }
    }
}
