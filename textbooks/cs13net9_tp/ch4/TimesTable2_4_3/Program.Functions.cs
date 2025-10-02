partial class Program {
static void TimesTable(byte val, byte size = 12)
    {
        for (int row = 1; row < size + 1; row++)
        {
            Console.WriteLine($"{row} * {val} = {row * val}");
        }
        Console.WriteLine();
    }
}
