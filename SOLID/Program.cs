using SOLID.LSP.Solution;
using SOLID.OCP.Solution;
using SOLID.SRP.Solution;

Console.WriteLine("Choose a SOLID principle:");
Console.WriteLine();
Console.WriteLine("1 - S (Single Responsibility)");
Console.WriteLine("2 - O (Open-Closed)");
Console.WriteLine("3 - L (Liskov Substitution)");
Console.WriteLine("4 - I (Interface Segregation)");
Console.WriteLine("5 - D (Dependency Inversion)");

var opcao = Console.ReadKey();
Console.WriteLine();
Console.WriteLine();

switch (opcao.KeyChar)
{
    case '1':
        Console.WriteLine(
            ClientService.AddClient(
                new Client()
                {
                    ClienteId = 1,
                    CPF = "97895025082",
                    Email = "exemple@email.com",
                    Name = "Sample Exemple",
                    DateRegister = DateTime.Now,
                }));
        break;
    case '2':
        CreditCard creditCard = new();
        creditCard.MakePayment(78.54m);
        break;
    case '3':
        Rectangle rectangle = new(10, 5);
        rectangle.ReportArea();
        break;
    case '4':
        //CalculoArea.Calcular();
        break;
    case '5':
        //CalculoArea.Calcular();
        break;
}