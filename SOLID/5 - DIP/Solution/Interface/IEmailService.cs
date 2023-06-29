namespace SOLID.DIP.Solution;

public interface IEmailService
{
    bool IsValid(string email);

    void Enviar(string from, string to, string subject, string messege);
}
