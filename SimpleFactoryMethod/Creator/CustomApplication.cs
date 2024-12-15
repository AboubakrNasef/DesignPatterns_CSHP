using Microsoft.Extensions.Configuration;
using SimpleFactoryMethod.Creator.Loggers;

internal class CustomApplication
{
    private IConfiguration configuration;
    public CustomApplication(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    internal Controller GetController()
    {
        return new Controller(GetLogger());
    }

    private ILogger GetLogger()
    {
        var section = configuration.GetValue<string>("Logger");
        return section switch
        {
            "Console" => new ConsoleLogger(),
            "File" => new FileLogger(),
            _ => throw new InvalidOperationException($"No logger for key {section}")
        };
    }
}