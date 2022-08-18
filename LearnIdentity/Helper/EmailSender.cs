using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace LearnIdentity.Helper
{
    public class EmailSender : IEmailSender
    {
        public EmailSender()
        {

        }
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            SmtpClient smtpClient = new SmtpClient();
            MailMessage message = new MailMessage();
            string fromMail = "wds10@24livehost.com";
            string fromPassword = "wds#2010wS";
            string host = "mail.24livehost.com";
            try
            {
                MailAddress fromAddres = new MailAddress(fromMail, "LearnNetCore");
                smtpClient.Host = host;
                smtpClient.Port = 25;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new System.Net.NetworkCredential(fromMail, fromPassword);

                message.From = fromAddres;
                message.To.Add(email);
                message.Subject = subject;
                message.IsBodyHtml = true;
                message.Body = htmlMessage;
                smtpClient.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
