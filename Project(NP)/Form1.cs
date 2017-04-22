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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration Reg = new Registration();
            Reg.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            Dashboard dh = new Dashboard();


            if (tb_email.Text != null && tb_pass.Text != null)
            {
                Login.Login_pro(tb_email.Text);
                if (tb_email.Text == Login.from && tb_pass.Text == Login.pass)
                {
                    dh.Show();
                    this.Hide();
                }
              else { MessageBox.Show("Wrong Credentials Entered"); }

            }
            
           

        }

        
    }
}
