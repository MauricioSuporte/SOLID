Console.WriteLine("Choose a SOLID principle");
Console.WriteLine("1 - S (Single Responsibility)");
Console.WriteLine("2 - O (Open-Closed)");
Console.WriteLine("3 - L (Liskov Substitution)");
Console.WriteLine("4 - I (Interface Segregation)");
Console.WriteLine("5 - D (Dependency Inversion)");

var opcao = Console.ReadKey();

switch (opcao.KeyChar)
{
    case '1':
        //CaixaEletronico.Operacoes();
        break;
    case '2':
        //CalculoArea.Calcular();
        break;
    case '3':
        //CalculoArea.Calcular();
        break;
    case '4':
        //CalculoArea.Calcular();
        break;
    case '5':
        //CalculoArea.Calcular();
        break;
}