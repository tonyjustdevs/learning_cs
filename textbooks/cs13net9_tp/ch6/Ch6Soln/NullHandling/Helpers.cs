using NullHandling;
partial class Program
{
    public static void PublishFootballers(IEnumerable<Footballer?> baller_list) {
        foreach (Footballer? baller in baller_list)
        {
            Console.WriteLine("{0} {1} is playing at {2} & is worth {3}",
            baller?.FirstName, baller?.LastName, baller?.Club, baller?.Value);
        }
    }
}
