using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace BookWise
{
    public class Mail
    {
        private static readonly string smtpHost = ConfigurationManager.AppSettings["SmtpHost"];
        private static readonly int smtpPort = int.Parse(ConfigurationManager.AppSettings["SmtpPort"]);
        private static readonly string smtpUser = ConfigurationManager.AppSettings["smtpUser"];
        private static readonly string smtpPass = ConfigurationManager.AppSettings["smtpPass"];

        private SmtpClient smtpClient = new SmtpClient(smtpHost, smtpPort)
        {
            EnableSsl = true,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential(smtpUser, smtpPass)
        };

        protected MailMessage mail = new MailMessage
        {
            From = new MailAddress(smtpUser, "BookWise"),
            IsBodyHtml = true
        };

        public async void Send(string email)
        {
            mail.To.Add(email);
            await smtpClient.SendMailAsync(mail);
            mail.Dispose();
            smtpClient.Dispose();
        }
    }
}
