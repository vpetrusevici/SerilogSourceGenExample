namespace SerilogSourceGenExample;

public sealed class FailedObject
{
    public required string SessionId { get; init; }

    public required string PaymentId { get; init; }

    public required string PaymentRef { get; init; }

    public required Detail[] Details { get; init; }
}

public sealed class Detail
{
    public required string Id { get; init; }
    public required string Name { get; init; }
}
