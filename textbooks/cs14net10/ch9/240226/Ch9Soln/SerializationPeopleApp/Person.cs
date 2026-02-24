
namespace TP.SharedLib;

public class Person
{
    public string? FullName;
    public DateTimeOffset DobOfBirth;
    public List<Person> Children = new();
}
