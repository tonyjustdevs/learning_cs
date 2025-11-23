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

    public static void PrintYouthAndProBaller(Footballer youth_player, Footballer pro_player)
    {
        Console.WriteLine("checking for nulls...");
        ArgumentNullException.ThrowIfNull(youth_player, nameof(youth_player));
        ArgumentNullException.ThrowIfNull(pro_player, nameof(pro_player));

        Console.WriteLine($"yth: {youth_player}");
        Console.WriteLine($"pro: {pro_player}");
    }
}

