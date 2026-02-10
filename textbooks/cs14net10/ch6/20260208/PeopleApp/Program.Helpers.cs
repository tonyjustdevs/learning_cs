using TPSharedModernLib;

partial class Program
{

    public static void Sayhi()
    {
        WriteLine("hi");
    }

    private static void ShowPeopleNames(IEnumerable<Person?> people) 
    {
        WriteLine("In ShowPeopleNames() of [Program.Helpers.cs]");
        foreach (Person? person in people)
        {
            //WriteLine($"- {person.Name}");
            string? names_string = person is null ? "<null> Person" : person.Name ?? "<null> Name";
            WriteLine(names_string);
        }
    }


  private static void OutputPeopleNames(
    IEnumerable<Person?> people, string title)
    {
        WriteLine(title);
        foreach (Person? p in people)
        {
            WriteLine(" {0}",
              p is null ? "<null> Person" : p.Name ?? "<null> Name");
            /* if p is null then output: <null> Person
               else output: p.Name
               unless p.Name is null then output: <null> Name */
        }
    }
}


