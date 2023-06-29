using SOLID.DIP.Violation;

namespace EP.SOLID.DIP.Violacao
{
    public class ClientService
    {
        public static string AddClient(Client client)
        {
            if (!client.IsValid())
                return "Invalid data!";

            var repo = new ClientRepository();
            repo.InsertClient(client);

            EmailService.Send("empresa@empresa.com", client.Email, "Welcome", "Parabéns está Cadastrado");

            return "Cliente cadastrado com sucesso";
        }
    }
}