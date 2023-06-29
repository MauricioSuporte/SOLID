namespace SOLID.SRP.Solution;

public class ClientService
{
    public static bool AddClient(Client client)
    {
        if (!client.IsValid())
        {
            Console.WriteLine("Invalid Client!");
            return false;
        }

        var repository = new ClienteRepository();
        repository.InsertClient(client);

        EmailService.Send("company@company.com", client.Email, "Welcome!", "Registration completed successfully.");

        Console.WriteLine("Successfully registered client.");
        return true;
    }
}