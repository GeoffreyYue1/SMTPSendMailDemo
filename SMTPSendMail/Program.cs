using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;
using System.IO;

namespace SMTPSendMail
{
    class Program
    {
        static void Main(string[] args)
        {

          


            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.office365.com");
            SmtpServer.UseDefaultCredentials = false;

       
            mail.From = new MailAddress("u8@geoffrey1.onmicrosoft.com");
            mail.To.Add("u8@geoffrey1.onmicrosoft.com");
            mail.Subject = "Mail";

            string htmlBody = File.ReadAllText(@"actionablemessage.html");
            //string filePath = @"C:\temp\dream.jpg";
           // string htmlBody = "<html><body><h1>Picture</h1><br></body></html>";

            mail.Body = htmlBody;

            mail.HeadersEncoding = Encoding.UTF8;
            mail.BodyEncoding = Encoding.UTF8;
            mail.SubjectEncoding = Encoding.UTF8;
           



            mail.IsBodyHtml = true;
           

            SmtpServer.Port = 587;

            SmtpServer.Credentials = new System.Net.NetworkCredential("u8@geoffrey1.onmicrosoft.com", "Your Password");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
           

        }
    }
}
