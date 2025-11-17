using TP.SharedLibraries;

partial class Program
{
    public static void OutputNames(IEnumerable<Person?> ListOfPersons)
    {
        foreach (Person? person in ListOfPersons)
        {
            string msg = person is null ? "<null>" : person.Name ?? "Person <null>"; 
            Console.WriteLine(msg);
        }
        Console.WriteLine();
    }
}

                                // inside a method, Program.cs is wrapped inside a
                                // static void Main(), therefore it works there.
