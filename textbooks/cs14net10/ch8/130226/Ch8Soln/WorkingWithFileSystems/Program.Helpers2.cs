public partial class Program
{
    // code is attached to main entry point

    public static void CoolTitle(string cool_title)
    {
        var PreviousFGColor = ForegroundColor;
        ForegroundColor = ConsoleColor.DarkBlue;
        WriteLine($" --- {cool_title} --- ");
        ForegroundColor = PreviousFGColor;
    }
}

