using System.Net;
using System.Net.Mail;

namespace BookWise
{
    public class Mail
    {
        private static readonly string smtpHost = "smtp.zoho.com";
        private static readonly int smtpPort = 587;
        private static readonly string smtpUser = "noreply@technovizion.studio";
        private static readonly string smtpPass = "JdUjtDfB5edX";

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
            try
            {
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
