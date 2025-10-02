partial class Program
{
    static void TimesTable(byte chosen_val, byte size = 12)
    {
        for (int i = 1; i < size+1; i++)
        {
            // row * col = row*col
            WriteLine($"{i} * {chosen_val} = {i * chosen_val}");
        }
    }

}