using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Project_NP_
{
   public class Login
    {
       

        public static string userName { get; set; }
        public static string from { get; set; }
        public static string pass { get; set; }

        public static void Login_pro(string email)
        {
            try
            {
                int a = 0;
                String ab = email;

                String[] x = File.ReadAllLines("AccountInfo.txt");

                while (a < x.Length)
                {
                    if (x[a].Contains(email))
                    {

                        from = x[a];
                        pass = x[a + 1];
                        userName = x[a + 2];
                    }
                    a++;
                }
            }
            catch { MessageBox.Show("Something Went Wrong"); }
            } 
   
        
        }
       

    }

