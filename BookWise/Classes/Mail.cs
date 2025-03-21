using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace BookWise
{
    public abstract class Mail
    {
        private static readonly string smtpHost = ConfigurationManager.AppSettings["SmtpHost"];
        private static readonly int smtpPort = int.Parse(ConfigurationManager.AppSettings["SmtpPort"]);
        private static readonly string smtpUser = ConfigurationManager.AppSettings["smtpUser"];
        private static readonly string smtpPass = ConfigurationManager.AppSettings["smtpPass"];

        protected abstract string Subject { get; }
        protected abstract string Body { get; }

        private SmtpClient smtpClient = new SmtpClient(smtpHost, smtpPort)
        {
            EnableSsl = true,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential(smtpUser, smtpPass)
        };


        private MailMessage mail = new MailMessage
        {
            From = new MailAddress(smtpUser, "BookWise"),
            IsBodyHtml = true
        };


        public async void Send(string email)
        {
            try
            {
                mail.Subject = Subject;
                mail.Body = Body;
                mail.To.Add(email);
                await smtpClient.SendMailAsync(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mail.Dispose();
                smtpClient.Dispose();
            }
        }
    }
}
