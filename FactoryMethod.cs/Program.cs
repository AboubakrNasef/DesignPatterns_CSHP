// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Logging;
using WebApplication1.Logger;

Console.WriteLine("Hello, World!");
ILogger logger = new CustomerLoggerProvider().CreateLogger("Hello");

logger.LogInformation("helloWorld");


