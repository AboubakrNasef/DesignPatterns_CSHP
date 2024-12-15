using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Logger
{
    internal class CustomLogger : ILogger
    {
    class CustomScope : IDisposable
    {
        public void Dispose()
        {
            
        }
    }
        public IDisposable? BeginScope<TState>(TState state) where TState : notnull
        {
            return new CustomScope();
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            // Ensure you handle the exception safely here
            if (formatter != null)
            {
                try
                {
                    string logMessage = formatter(state, exception);
                    // Write your log to a destination (e.g., console, file, etc.)
                    Console.WriteLine($"{logLevel}: {logMessage}");
                }
                catch (Exception ex)
                {
                    // Handle exceptions here (logging, rethrowing, etc.)
                    Console.WriteLine($"Error in logging: {ex.Message}");
                }
            }
        }
    }
}
