namespace SOLID.SRP.Solution;

public class ClientService
{
    public static string AddClient(Client client)
    {
        if (!client.IsValid())
            return "Invalid Client!";

        var repository = new ClienteRepository();
        repository.InsertClient(client);

        EmailService.Send("company@company.com", client.Email, "Welcome!", "Registration completed successfully.");

        return "Successfully registered client.";
    }
}