namespace TP.SharedLibraries;
public class Player2
{
    public int Points { get; private set; }
    public async Task AddPoints(int points)
    {
        Points += points;
        Console.WriteLine($"{points} added. Total: {Points}");
        await Task.Delay(250);

        if (Points >= 100)
        {
            Console.WriteLine($"You won at life! {Points} points.");
        }
    }
}
