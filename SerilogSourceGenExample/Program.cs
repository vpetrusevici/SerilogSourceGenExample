using Serilog;
using SerilogSourceGenExample;
using ILogger = Microsoft.Extensions.Logging.ILogger;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;
builder.Host.UseSerilog((ctx, lc) => lc
    .ReadFrom.Configuration(config)
    .Enrich.FromLogContext());

var app = builder.Build();

app.MapGet("/", (ILoggerFactory loggerFactory) =>
{
    var logger = loggerFactory.CreateLogger("Start");
    LogsHelper.LogPaymentResponse(logger, new FailedObject
    {
        Details = new Detail[] {
            new() {
                Id = "If",
                Name = "Name"
            }
        },
        PaymentId = "some value",
        PaymentRef = "another one",
        SessionId = "session id"
    });
    return "Hello World!";
});

app.Run();
