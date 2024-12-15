using Microsoft.Extensions.Configuration;
using SimpleFactoryMethod.Creator;
using SimpleFactoryMethod.Creator.Loggers;

internal class CustomApplicationV1
{
    private IConfiguration _configuration;
    private LoggerFactory _loggerFactory; 
    public CustomApplicationV1(IConfiguration configuration)
    {
        this._configuration = configuration;
        _loggerFactory = new LoggerFactory();
    }

    internal Controller GetController()
    {
        var loggerName = _configuration.GetValue<string>("Logger");
        return new Controller(_loggerFactory.GetLogger(loggerName));
    }
}
