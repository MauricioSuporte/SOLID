using System.Net.Mail;

namespace SOLID.SRP.Solution;

public static class EmailService
{
    public static bool IsValid(string email)
    {
        return email.Contains('@');
    }

    public static void Send(string from, string to, string assunto, string messege)
    {
        var mail = new MailMessage(from, to);
        var client = new SmtpClient
        {
            Port = 25,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Host = "smtp.google.com"
        };

        mail.Subject = assunto;
        mail.Body = messege;
        // Simulates email send logic
    }
}