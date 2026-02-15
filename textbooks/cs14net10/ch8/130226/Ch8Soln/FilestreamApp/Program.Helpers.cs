partial class Program
{
    private static void CoolerTitle(string title, ConsoleColor title_colour = ConsoleColor.DarkGreen)
    {
        WriteLine();
        var previousForegroundColor = ForegroundColor;
        ForegroundColor = title_colour;
        WriteLine($" ----- {title} ---- ");
        ForegroundColor = previousForegroundColor;
    }
}
