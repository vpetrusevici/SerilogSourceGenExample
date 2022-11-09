namespace SerilogSourceGenExample;

public static partial class LogsHelper
{

    [LoggerMessage(3, LogLevel.Error, "Smth failed: {someObject}")]
    public static partial void LogPaymentResponse(ILogger logger, FailedObject someObject);

}
