namespace SOLID.SRP.Solution;

public class Client
{
    public int ClienteId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string CPF { get; set; } = string.Empty;

    public DateTime DateRegister { get; set; }

    public bool IsValid()
    {
        return EmailService.IsValid(Email) && CPFService.IsValid(CPF);
    }
}
