using Microsoft.Extensions.Configuration;
using SimpleFactoryMethod.Creator;

internal class CustomApplicationV3
{
    private IConfiguration _configuration;
    private ILoggerFactoryV3 _loggerFactory;
    public CustomApplicationV3(IConfiguration configuration, ILoggerFactoryV3 loggerFactory)
    {
        this._configuration = configuration;
        _loggerFactory = loggerFactory;
    }

    internal Controller GetController()
    {
        var logger = _loggerFactory.GetLogger();
        return new Controller(logger);
    }
}