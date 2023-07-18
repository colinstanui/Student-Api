using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using Student_Api;



namespace Student_Api
{
    public class Email
    { 

    public static void SendMyEmail(string recipient, string subject, string message)
    {
        try
        {



            string email = EmailConfig.MailFromAddress;
            string password = EmailConfig.MailPassword;






            var loginInfo = new NetworkCredential(email, password);
            var msg = new MailMessage();
            var smtpClient = new SmtpClient(EmailConfig.MailServer, EmailConfig.MailPort);





            msg.From = new MailAddress(email);
            msg.To.Add(new MailAddress(recipient));
            msg.Subject = subject;
            msg.Body = message;
            msg.IsBodyHtml = true;





            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = loginInfo;
            smtpClient.Send(msg);





        }
        catch (Exception Ex)
        {
            Ex.Data.Clear();
            // throw;
        }
    }
}
}
