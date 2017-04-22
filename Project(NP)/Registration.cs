using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_NP_
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            //Main Logic
            


            // Show Hide
            this.Close();
            Form1 fm = new Form1();
            fm.Show();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            AccountClass ac = new AccountClass();
            ac.addUser(tb_email.Text, tb_pass.Text, tb_userName.Text);
            MessageBox.Show("You Are Registered");
        }
    }
}
