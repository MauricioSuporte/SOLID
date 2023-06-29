using SOLID;

Console.WriteLine("Choose a SOLID principle:");
Console.WriteLine();
Console.WriteLine("1 - S (Single Responsibility)");
Console.WriteLine("2 - O (Open-Closed)");
Console.WriteLine("3 - L (Liskov Substitution)");
Console.WriteLine("4 - I (Interface Segregation)");
Console.WriteLine("5 - D (Dependency Inversion)");

var option = Console.ReadKey();
Console.WriteLine();
Console.WriteLine();

switch (option.KeyChar)
{
    case '1':
        Menu.RedirectSRP();
        break;
    case '2':
        Menu.RedirectOCP();
        break;
    case '3':
        Menu.RedirectLSP();
        break;
    case '4':
        Menu.RedirectISP();
        break;
    case '5':
        Menu.RedirectDIP();
        break;
}