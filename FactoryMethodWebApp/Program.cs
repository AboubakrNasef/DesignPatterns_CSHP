using Serilog;
using WebApplication1.Logger;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Logging.ClearProviders();
builder.Logging.AddSerilog();
//builder.Logging.AddProvider(new CustomerLoggerProvider());

var app = builder.Build();


app.UseHttpsRedirection();



app.MapGet("/", (ILogger<string> logger) =>
{
    logger.LogInformation("helloworld");
    return "forecast";
});

app.Run();