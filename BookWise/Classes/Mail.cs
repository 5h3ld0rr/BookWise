using System.Net;
using System.Net.Mail;

namespace BookWise
{
    public abstract class Mail
    {
        private static readonly string smtpHost = Config.SMTP.Host;
        private static readonly int smtpPort = Config.SMTP.Port;
        private static readonly string smtpUser = Config.SMTP.User;
        private static readonly string smtpPass = Config.SMTP.Password;

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
