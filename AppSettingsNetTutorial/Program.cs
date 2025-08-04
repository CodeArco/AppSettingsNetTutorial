

using AppSettingsNetTutorial;
using Microsoft.Extensions.Configuration;

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
        Console.WriteLine($"config1: {config1?.ExampleObjectList.FirstOrDefault()?.Header.Description}");
        Console.WriteLine($"config2: {config2.ExampleObjectList.FirstOrDefault()?.Header.Description}");
    }
}