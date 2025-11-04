namespace TP.SharedLibraries;

public partial class Person {
    public static void MarryTwoPersons(Person p1, Person p2)
    {
        ArgumentNullException.ThrowIfNull(p1);
        ArgumentNullException.ThrowIfNull(p2);

        Console.WriteLine("'{0}' & '{1}' attempt to get married...",p1.Name, p2.Name);
        if (p1.Spouses.Contains(p2) | p2.Spouses.Contains(p1) )
        {
            Console.WriteLine("'{0}' & '{1}' are already married!",p1.Name, p2.Name);
        }
        else
        {
            p1.Spouses.Add(p2);
            p2.Spouses.Add(p1);
            Console.WriteLine("Congrats! '{0}' & '{1}' just got hitched!",p1.Name, p2.Name);
        }
    }

    public void MarryAPerson(Person p2) { 
        ArgumentNullException.ThrowIfNull(p2);
        Console.WriteLine($"{this.Name} has proposed to {p2.Name}");
        MarryTwoPersons(this, p2);
    }
}
    