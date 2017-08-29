using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Emailing
{
    public class Email
    {
        public static void SendEmail(string from, string To, string Subject, string Message, string fileName)
        {
            using (MailMessage mail = new MailMessage(from, To))
            {
                try
                {
                    mail.Subject = Subject;

                    mail.Body = Message;

                    if (fileName != string.Empty)

                    {

                        mail.Attachments.Add(new Attachment(fileName));

                    }

                    mail.IsBodyHtml = false;
                
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "DEADPOOL.lightsourcemanagement.com";
                    //NetworkCredential networkCredential = new NetworkCredential(ConfigurationManager.AppSettings["UserID"], ConfigurationManager.AppSettings["Password"]);
                    //smtp.UseDefaultCredentials = true;
                    //smtp.Credentials = networkCredential;
                    smtp.Port = 25;
                    Console.WriteLine("trying to send mail !");
                    
                    smtp.Send(mail);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Email sent");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
                    
                
            }
        }
    }
}
