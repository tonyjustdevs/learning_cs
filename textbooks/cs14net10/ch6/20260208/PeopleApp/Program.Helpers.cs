using TPSharedModernLib;

partial class Program
{

    public static void Sayhi()
    {
        WriteLine("hi");
    }

    private static void ShowPeopleNames(IEnumerable<Person> people) 
    {
        WriteLine("In ShowPeopleNames() of [Program.Helpers.cs]");
        foreach (Person person in people)
        {
            WriteLine($"- {person.Name}");
            
        }
    }
    // In Program.Helpers.cs.
    // - 1. define method partial Program class that outputs
    // - 2. all the names collection of people
    // - 3. passed as a parameter
    // - 4. with a title beforehand


}


