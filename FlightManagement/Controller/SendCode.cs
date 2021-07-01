using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Controller
{
    public class SendCode
    {
        private static SendCode instance;

        public static SendCode Instance
        {
            get { if (instance == null) instance = new SendCode(); return SendCode.instance; }
            set { SendCode.instance = value; }
        }
        private SendCode() { }
        public int SendMail(string to, string random)
        {
            
                string from, pass, messagebody;
                MailMessage message = new MailMessage();
                from = "19522187@gm.uit.edu.vn";
                pass = "1104108787";
                messagebody = "your code is " + random;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messagebody;
                message.Subject = "Password reseting code";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                    return 1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return 0;
                }
           

        }

    }
}
