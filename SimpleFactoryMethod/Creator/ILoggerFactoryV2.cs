using SimpleFactoryMethod.Creator.Loggers;

namespace SimpleFactoryMethod.Creator
{
    internal interface ILoggerFactoryV2
    {
        public ILogger GetLogger(string loggerName);
    }
    internal interface ILoggerFactoryV3
    {
        public ILogger GetLogger();
    }
}