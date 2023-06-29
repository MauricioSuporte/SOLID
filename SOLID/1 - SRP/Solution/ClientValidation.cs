namespace SOLID.SRP.Solution;

public class ClientValidation
{
    public static bool IsValid(string email, string cpf)
    {
        return EmailService.IsValid(email) && CPFService.IsValid(cpf);
    }
}
