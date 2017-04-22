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
    public partial class SendEmail : Form
    {
        public SendEmail()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string[] data = new string[6];
            data[0] = tb_To.Text;
            data[1] = Login.from;

            data[2] = tb_subj.Text;
            data[3] = tb_attach.Text;
            data[5] = tb_body.Text;
            data[4] = Login.pass;
            MailClass.send(data);
        }

        private void browsAttach_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                tb_attach.Text = o.FileName;
            }
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                tb_attach.Text = o.FileName;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dsh = new Dashboard();
            this.Hide();
            dsh.Show();
        }
    }
}
