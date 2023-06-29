using SOLID.DIP.Solution;
using SOLID.ISP.Solution;
using SOLID.LSP.Solution;
using SOLID.OCP.Solution;

namespace SOLID;

public class Menu
{
    private readonly IClientService _clientService;
    private readonly IEmailService _emailService;
    private readonly ICPFService _cpfService;

    public Menu(
        IClientService clientService,
        IEmailService emailService,
        ICPFService cpfService)
    {
        _clientService = clientService;
        _emailService = emailService;
        _cpfService = cpfService;
    }

    public static void RedirectSRP()
    {
        SRP.Solution.ClientService.AddClient(
            new SRP.Solution.Client()
            {
                ClientId = 1,
                CPF = "97895025082",
                Email = "exemple@email.com",
                Name = "Sample Exemple",
                RegistrationDate = DateTime.Now,
            });
    }

    public static void RedirectOCP()
    {
        CreditCard creditCard = new();
        creditCard.MakePayment(78.54m);
    }

    public static void RedirectLSP()
    {
        Rectangle rectangle = new(10, 5);

        Console.WriteLine($"Rectangle area is {rectangle.Area}m²");
    }

    public static void RedirectISP()
    {
        RegisterClient registerClient = new();
        registerClient.ValidateData();
        registerClient.SaveDatabase();
        registerClient.SendEmail();
    }

    public void RedirectDIP()
    {
        _clientService.AddClient(
            new Client(
                _emailService,
                _cpfService)
            {
                ClientId = 1,
                CPF = "97895025082",
                Email = "exemple@email.com",
                Name = "Sample Exemple",
                RegistrationDate = DateTime.Now,
            });
    }
}