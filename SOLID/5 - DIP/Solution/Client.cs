namespace SOLID.DIP.Solution;

public class Client
{
    private readonly IEmailService _emailService;
    private readonly ICPFService _cpfService;

    public Client(
        IEmailService emailService,
        ICPFService cpfService)
    {
        _emailService = emailService;
        _cpfService = cpfService;
    }

    public int ClientId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string CPF { get; set; } = string.Empty;

    public DateTime RegistrationDate { get; set; }

    public bool IsValid()
    {
        return _emailService.IsValid(Email) && _cpfService.IsValid(CPF);
    }
}
