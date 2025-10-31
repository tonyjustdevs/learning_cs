namespace TP.SharedNamespace;

public record ImmutableVehicle
{
    public required string? Brand { get; init; }
    public required string? Colour { get; init;}
    public int Wheels { get; init; }
}
