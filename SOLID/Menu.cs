using SOLID.ISP.Solution;
using SOLID.LSP.Solution;
using SOLID.OCP.Solution;
using SOLID.SRP.Solution;

namespace SOLID;

public class Menu
{
    public static void RedirectSRP()
    {
        ClientService.AddClient(
            new Client()
            {
                ClienteId = 1,
                CPF = "97895025082",
                Email = "exemple@email.com",
                Name = "Sample Exemple",
                DateRegister = DateTime.Now,
            });
    }

    public static void RedirectOCP()
    {
        CreditCard creditCard = new();
        creditCard.MakePayment(78.54m);
    }

    public static void RedirectLSP()
    {
        Rectangle rectangle = new(10, 5);

        Console.WriteLine($"Rectangle area is {rectangle.Area}m²");
    }

    public static void RedirectISP()
    {
        RegisterClient registerClient = new();
        registerClient.ValidateData();
        registerClient.SaveDatabase();
        registerClient.SendEmail();
    }

    public static void RedirectDIP()
    {
        var a = 2;
    }
}