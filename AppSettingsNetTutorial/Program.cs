

using AppSettingsNetTutorial;
using AppSettingsNetTutorial.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        var build = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json")
        .Build();

        // Alternative 1
        var config1 = build.Get<Config>();

        // Alternative 2
        var config2 = new Config();
        build.Bind(config2);

        // Output
        Console.WriteLine($"config1 from Program: {config1?.ExampleObjectList.FirstOrDefault()?.Header.Description}");
        Console.WriteLine($"config2 from Program: {config2.ExampleObjectList.FirstOrDefault()?.Header.Description}");

        // Send config with dependency injection
        var services = new ServiceCollection();
        services.AddSingleton<Config>(config1);
        services.AddSingleton<IServiceDatabase, ServiceDatabase> ();

        // Call service
        var serviceProvider = services.BuildServiceProvider();
        var serviceDatabase = serviceProvider.GetService<IServiceDatabase>();
        serviceDatabase.SaveData("Sample Data");
    }
}