
namespace TP.SharedLibraries;

public class Employee2 : Person
{
    public DateOnly HireDate {  get; set; }

    public new void WriteToConsole() => Console.WriteLine(
    $"'{Name}' " +
    //$"was hired on '{HireDate:dddd}' ");
    $"was hired on '{HireDate:yy-MM-dd}' ");

    //public override string ToString()
    //{
    //    Console.WriteLine("mate");
    //}

    public override string ToString()
    {
        return $"{Name} is a {base.ToString()} hired on {HireDate:dd-MM-yyyy}";
    }

}

// 1. add ee to prog.cs:  instance.WriteToConsole()
// 2. 