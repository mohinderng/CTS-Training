using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace FileSend
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("mohinderng@gmail.com");
                mail.To.Add("vinodrawool00@gmail.com");
                mail.Subject = "Best";
                mail.Body = " LELE";


                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("mohinderng@gmail.com", "9993136152");
                smtp.EnableSsl = true;

                Console.WriteLine("Mail Sent");

                smtp.Send(mail);
            }
            catch (Exception x) { Console.WriteLine(x.ToString()); }



        }
    }
}


