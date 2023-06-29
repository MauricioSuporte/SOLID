namespace SOLID.SRP.Solution;

public class ClienteRepository
{
    private static List<Client> clients = new();

    public static List<Client> Clients
    {
        get { return clients; }
        private set { clients = value; }
    }

    public static void InsertClient(Client client)
    {
        // Simulates database insert logic
        Clients.Add(client);
    }
}