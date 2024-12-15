using Microsoft.Extensions.Configuration;
using SimpleFactoryMethod.Creator.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryMethod.Creator
{
    internal class LoggerFactory
    {
        public ILogger GetLogger(string loggerName)
        {
            return loggerName switch
            {
                "Console" => new ConsoleLogger(),
                "File" => new FileLogger(),
                _ => throw new InvalidOperationException($"No logger for key {loggerName}")
            };
        }
    }
    internal class LoggerFactoryV2 : ILoggerFactoryV2
    {
        public ILogger GetLogger(string loggerName)
        {
            return loggerName switch
            {
                "Console" => new ConsoleLogger(),
                "File" => new FileLogger(),
                _ => throw new InvalidOperationException($"No logger for key {loggerName}")
            };
        }
    }
    internal class ConsoleLoggerFactoryV3 : ILoggerFactoryV3
    {
        public ILogger GetLogger()
        {
            return new ConsoleLogger();
        }
    }
    internal class FileLoggerFactoryV3 : ILoggerFactoryV3
    {
        public ILogger GetLogger()
        {
            return new FileLogger();
        }
    }
}
