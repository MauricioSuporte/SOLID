﻿namespace SOLID.DIP.Solution;

public class ClientRepository : IClientRepository
{
    private static List<Client> clients = new();

    public static List<Client> Clients
    {
        get { return clients; }
        private set { clients = value; }
    }

    public void InsertClient(Client client)
    {
        // Simulates database insert logic
        Clients.Add(client);
    }
}
