using System.Net.Mail;
namespace SOLID.DIP.Viiolacao
{
    public class EmailService
    {
        public static bool IsValid(string email)
        {
            return email.Contains("@");
        }

        public static void Enviar(string from, string to, string subject, string message)
        {
            var mail = new MailMessage(from, to);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };
            mail.Subject = subject;
            mail.Body = message;
            client.Send();
        }
    }
}