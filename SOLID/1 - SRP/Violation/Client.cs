using System.Net.Mail;

namespace SOLID.SRP.Violation;

public class Client
{
    private static List<Client> clients = new List<Client>();

    public static List<Client> Clients
    {
        get { return clients; }
        private set { clients = value; }
    }

    public int ClienteId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string CPF { get; set; } = string.Empty;

    public DateTime DataCadastro { get; set; }

    public string AdicionarCliente()
    {
        var client = new Client()
        {
            ClienteId = 12345,
            Name = "Sample Exemple",
            Email = "exemple@email.com",
            CPF = "62825011053",
            DataCadastro = DateTime.Now,
        };

        if (!client.Email.Contains('@'))
            return "Email invalid!";

        if (client.CPF.Length != 11)
            return "CPF invalid!";

        // Simulates database insert logic
        Clients.Add(client);

        var mail = new MailMessage("empresa@empresa.com", Email);

        var smtpClient = new SmtpClient
        {
            Port = 25,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Host = "smtp.google.com"
        };

        mail.Subject = "Welcome!";
        mail.Body = "Registration completed successfully.";
        smtpClient.Send(mail);

        return "Successfully registered customer";
    }
}
