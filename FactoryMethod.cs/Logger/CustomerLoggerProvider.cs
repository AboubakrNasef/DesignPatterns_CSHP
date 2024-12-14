using FactoryMethod.Logger;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Logger
{
    public class CustomerLoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            return new CustomLogger();
        }

        public void Dispose()
        {
           
        }
    }
}
