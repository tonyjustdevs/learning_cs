
namespace TP.SharedLib;

public class Person
{
    public string? FullName { get; set; }
    public DateTimeOffset DobOfBirth { get; set; }
    public List<Person> Children { get; set; } = new ();
}
