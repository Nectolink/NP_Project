using OpenPop.Pop3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_NP_
{
    public class MailClass
    {

        public static void send(string[] Email)
        {

            try
            {
                MailMessage mail = new MailMessage();
                var domain = Email[1].Split('@')[1].ToLower();
                string mailserver = "";//net ka kchr kr apne ;p yar abhi to uska office bhi bhund hoga
                bool ssl = true;
                switch (domain)
                {
                    case "gmail.com":
                        mailserver = "smtp.gmail.com";
                        ssl = true;
                        break;
                    case "outlook.com":
                        mailserver = "smtp.live.com";
                        ssl = true;
                        break;
                    case "hotmail.com":
                        mailserver = "smtp.live.com";
                        ssl = true;
                        break;
                    case "live.com":
                        mailserver = "smtp.live.com";
                        ssl = true;
                        break;
                    case "yahoo.com":
                        mailserver = "smtp.yahoo.com";
                        ssl = true; ;//mnhs et tmka 
                        break;

                    case "aol.com":
                        mailserver = "smtp.aol.com";
                        ssl = false;
                        break;
                    default:
                        break;
                }
                SmtpClient SmtpServer = new SmtpClient(mailserver);

                mail.From = new MailAddress(Email[1]);
                mail.To.Add(Email[0]);
                if (Email[2] != "")
                {
                    mail.Subject = Email[2];
                }

                if (Email[3] != "")
                {
                    mail.Attachments.Add(new Attachment(Email[3]));
                }

                mail.Body = Email[5];


                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(Email[1], Email[4]);
                SmtpServer.EnableSsl = ssl;
                SmtpServer.Send(mail);
                MessageBox.Show("send");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static IEnumerable<OpenPop.Mime.Message> fetchEmail(string[] Email)
        {

            var domain = Email[0].Split('@')[1].ToLower();
            string mailserver = "";
            bool ssl = true;
            switch (domain)
            {
                case "gmail.com":
                    mailserver = "pop.gmail.com";
                    ssl = true;
                    break;
                case "outlook.com":
                    mailserver = "pop3.live.com";
                    ssl = true;
                    break;
                case "hotmail.com":
                    mailserver = "pop3.live.com";
                    ssl = true;
                    break;
                case "live.com":
                    mailserver = "pop3.live.com";
                    ssl = true;
                    break;
                case "yahoo.com":
                    mailserver = "	pop.mail.yahoo.com";
                    ssl = true; ;//mnhs et tmka 
                    break;

                case "aol.com":
                    mailserver = "pop.aol.com";
                    ssl = true;
                    break;
                default:
                    break;
            }
            Pop3Client kutta = new Pop3Client();
            kutta.Connect(mailserver, 995, ssl); ;
            kutta.Authenticate(Email[0], Email[1]);
            int khotaGetInboxCount = kutta.GetMessageCount();
            for (int i = khotaGetInboxCount; i > 0; i--)
            {
                yield return (kutta.GetMessage(i));
            }
        }

    
    }
}
