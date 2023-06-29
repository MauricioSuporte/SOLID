using System.Net.Mail;

namespace SOLID.SRP.Violation;

public class Client
{
    private static List<Client> clients = new();

    public static List<Client> Clients
    {
        get { return clients; }
        private set { clients = value; }
    }

    public int ClientId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string CPF { get; set; } = string.Empty;

    public DateTime RegistrationDate { get; set; }

    public static string InserClient()
    {
        var client = new Client()
        {
            ClientId = 12345,
            Name = "Sample Exemple",
            Email = "exemple@email.com",
            CPF = "62825011053",
            RegistrationDate = DateTime.Now,
        };

        if (!client.Email.Contains('@'))
            return "Email invalid!";

        if (client.CPF.Length != 11)
            return "CPF invalid!";

        // Simulates database insert logic
        Clients.Add(client);

        // Simulates email send logic

        return "Successfully registered client";
    }
}
