using Microsoft.Extensions.Configuration;
using SimpleFactoryMethod.Creator;

internal class CustomApplicationV2
{
    private IConfiguration _configuration;
    private ILoggerFactoryV2 _loggerFactory;
    public CustomApplicationV2(IConfiguration configuration, ILoggerFactoryV2 loggerFactory)
    {
        this._configuration = configuration;
        _loggerFactory = loggerFactory;
    }

    internal Controller GetController()
    {
        var loggerName = _configuration.GetValue<string>("Logger");
        return new Controller(_loggerFactory.GetLogger(loggerName));
    }
}