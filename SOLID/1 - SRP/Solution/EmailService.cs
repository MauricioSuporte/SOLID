using System.Net.Mail;

namespace SOLID.SRP.Solution;

public static class EmailService
{
    public static bool IsValid(string email)
    {
        return email.Contains('@');
    }

    public static void Send(string from, string to, string subject, string messege)
    {
        // Simulates email send logic
    }
}