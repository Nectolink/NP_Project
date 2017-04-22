using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_NP_
{
    public partial class ReadMail : Form
    {
        public ReadMail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RetriveMail_Click(object sender, EventArgs e)
        {
          
            string[] data = new string[6];
            data[0] = Login.from;
            data[1] = Login.pass;
            int i = 0;
            var thread1 = new Thread(() =>
            {
                foreach (OpenPop.Mime.Message item in MailClass.fetchEmail(data))
                {
                    Invoke(new Action(() =>
                    {
                        




                        dataGridView1.Rows.Add();

                        dataGridView1.Rows[i].Cells[0].Value = item.Headers.From.MailAddress.ToString();

                        dataGridView1.Rows[i].Cells[1].Value = item.Headers.Subject;
                        dataGridView1.Rows[i].Cells[2].Value = item.FindFirstHtmlVersion().GetBodyAsText();
                        i++;
                        //   listBox1.Items.Add(item.Headers.Subject+item.Headers.);
                    }));

                }
            });
            thread1.TrySetApartmentState(ApartmentState.MTA);
            thread1.Start();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {      
            //OpenPop.Mime.Message items;
            //DataTable dt = new DataTable();
            //if (e.RowIndex < dataGridView1.RowCount && e.RowIndex >= 0)
            {

              //  webBrowser1.DocumentText = dataGridView1.Rows[index].ToString();
                //webBrowser1.DocumentText =  dataGridView1.Rows[e.RowIndex].Index.ToString();
                //webBrowser1.DataBindings = dataGridView1.Rows[e.RowIndex].Index.ToString();

                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                    string a = Convert.ToString(selectedRow.Cells["Body"].Value);
                    string b = Convert.ToString(selectedRow.Cells["From"].Value);
                    string c = Convert.ToString(selectedRow.Cells["Subject"].Value);
                    webBrowser1.DocumentText = a;
                    tb_from.Text = b;
                    tb_Sub.Text = c;


                }
             
            }
        }

        private void btn_GetMail_Click(object sender, EventArgs e)
        {
            string[] data = new string[6];
            data[0] = Login.from;
            data[1] = Login.pass;
            int i = 0;
            var thread1 = new Thread(() =>
            {
                foreach (OpenPop.Mime.Message item in MailClass.fetchEmail(data))
                {
                    Invoke(new Action(() =>
                    {





                        dataGridView1.Rows.Add();

                        dataGridView1.Rows[i].Cells[0].Value = item.Headers.From.MailAddress.ToString();

                        dataGridView1.Rows[i].Cells[1].Value = item.Headers.Subject;
                        dataGridView1.Rows[i].Cells[2].Value = item.FindFirstHtmlVersion().GetBodyAsText();
                        i++;
                        //   listBox1.Items.Add(item.Headers.Subject+item.Headers.);
                    }));

                }
            });
            thread1.TrySetApartmentState(ApartmentState.MTA);
            thread1.Start();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dsh = new Dashboard();
            this.Hide();
            dsh.Show();
        }
    }
}
