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

    public DateTime DataRegister { get; set; }

    public string InserClient()
    {
        var client = new Client()
        {
            ClientId = 12345,
            Name = "Sample Exemple",
            Email = "exemple@email.com",
            CPF = "62825011053",
            DataRegister = DateTime.Now,
        };

        if (!client.Email.Contains('@'))
            return "Email invalid!";

        if (client.CPF.Length != 11)
            return "CPF invalid!";

        // Simulates database insert logic
        Clients.Add(client);

        var mail = new MailMessage("company@company.com", Email);

        var smtpClient = new SmtpClient
        {
            Port = 25,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Host = "smtp.google.com"
        };

        mail.Subject = "Welcome!";
        mail.Body = "Registration completed successfully.";

        // Simulates email send logic

        return "Successfully registered client";
    }
}
