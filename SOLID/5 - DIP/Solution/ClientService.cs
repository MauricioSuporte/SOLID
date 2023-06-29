namespace SOLID.DIP.Solution;

public class ClientService : IClientService
{
    private readonly IEmailService _emailService;
    private readonly IClientRepository _clientRepository;

    public ClientService(
        IEmailService emailService,
        IClientRepository clientRepository)
    {
        _emailService = emailService;
        _clientRepository = clientRepository;
    }

    public bool AddClient(Client client)
    {
        if (!client.IsValid())
        {
            Console.WriteLine("Invalid Client!");
            return false;
        }

        _clientRepository.InsertClient(client);

        _emailService.Enviar("empresa@empresa.com", client.Email, "Welcome", "Registration completed successfully.");

        Console.WriteLine("Successfully registered client.");
        return true;
    }
}