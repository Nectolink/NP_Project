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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
           
            
        }



        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 fm = new Form1();
            fm.Show();
        }

        private void lblSendMail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SendEmail snd = new SendEmail();
            this.Hide();
            snd.Show();
        }

        private void lblReadEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReadMail rdm = new ReadMail();
            this.Hide();
            rdm.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblusername.Text = Login.userName;
        }
    }
}
