namespace SOLID.DIP.Solution;

public class EmailService : IEmailService
{
    public bool IsValid(string email)
    {
        return email.Contains('@');
    }

    public void Enviar(string from, string to, string subject, string messege)
    {
        // Send email logic
    }
}
