namespace SOLID.DIP.Violation;

public class EmailService
{
    public static bool IsValid(string email)
    {
        return email.Contains('@');
    }

    public static void Enviar(string from, string to, string subject, string messege)
    {
        // Send email logic
    }
}
