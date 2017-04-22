using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_NP_
{
    class AccountClass
    {
        StreamWriter sw = new StreamWriter("AccountInfo.txt",true);
        
        public void addUser(string email, string password, string name)
        {
            sw.WriteLine(email);
            sw.WriteLine(password);
            sw.WriteLine(name);
            sw.Close();
            
        
        }

    }
}
