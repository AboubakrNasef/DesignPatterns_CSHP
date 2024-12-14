using FactoryMethod.Logger;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Logger
{
    public class CustomerLoggerProvider : ILoggerProvider
    {
  private readonly Dictionary<string,ILogger> keyValuePairs = new Dictionary<string,ILogger>();

        public ILogger CreateLogger(string categoryName)
        {
            if (!keyValuePairs.TryGetValue(categoryName, out var logger))
            {
                Console.WriteLine($"creating logger {categoryName}");
                logger = new CustomLogger();
                keyValuePairs.Add(categoryName, logger);
            }  
            return logger;
        }

        public void Dispose()
        {
            keyValuePairs.Clear();
        }
    }
}
