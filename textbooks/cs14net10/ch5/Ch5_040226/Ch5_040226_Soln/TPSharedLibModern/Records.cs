namespace NSTP.TPSharedLibModern;

public class ImmutablePerson
{
    public string? FirstName {get;init;}
    public string? LastName { get; init; }
}

public record ImmutableCar
{
    public string? Brand{ get; init; }
    public string? Colour{ get; init; }
}

public record ImmutableAnimal(string Name, string Animal);