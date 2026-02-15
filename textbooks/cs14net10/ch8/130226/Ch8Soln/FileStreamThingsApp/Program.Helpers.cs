static partial class Program
{
    private static void CoolerTitle(string title)
    {
        var previousFGColor = ForegroundColor;
        ForegroundColor = ConsoleColor.DarkGreen;
        WriteLine($" ***** {title} *****");
        ForegroundColor = previousFGColor;
    }

    private static void MainTitle(string title)
    {
        var previousFGColor = ForegroundColor;
        ForegroundColor = ConsoleColor.Yellow;
        WriteLine($" ***** {title} *****");
        ForegroundColor = previousFGColor;
    }
}

