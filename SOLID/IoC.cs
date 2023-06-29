using Microsoft.Extensions.DependencyInjection;
using SOLID.DIP.Solution;

namespace SOLID;

public class IoC
{
    public static void ConfigureAndRunDIP()
    {
        var services = new ServiceCollection();

        services.AddTransient<IClientService, ClientService>();
        services.AddTransient<IEmailService, EmailService>();
        services.AddTransient<ICPFService, CPFService>();
        services.AddTransient<IClientRepository, ClientRepository>();

        services.AddTransient<Menu>();

        using var serviceProvider = services.BuildServiceProvider();

        var menu = serviceProvider.GetRequiredService<Menu>();
        menu.RedirectDIP();
    }
}
