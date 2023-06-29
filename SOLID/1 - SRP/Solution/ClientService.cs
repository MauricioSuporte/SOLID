namespace SOLID.SRP.Solution;

public class ClientService
{
    public static bool AddClient(Client client)
    {
        if (!ClientValidation.IsValid(client.Email, client.CPF))
        {
            Console.WriteLine("Invalid Client!");
            return false;
        }

        ClienteRepository.InsertClient(client);

        EmailService.Send(
            from: "company@company.com",
            to: client.Email,
            subject: "Welcome!",
            messege: "Registration completed successfully.");

        Console.WriteLine("Successfully registered client.");
        return true;
    }
}


