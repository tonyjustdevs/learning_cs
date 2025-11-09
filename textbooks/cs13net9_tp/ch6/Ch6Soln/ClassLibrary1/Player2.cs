namespace TP.SharedLibraries;
public class Player2
{
    public int Points { get; private set; }
    public event Action? AchievementUnlocked;
    public async Task AddPoints(int points)
    {
        Points += points;
        Console.WriteLine($"{points} added. Total: {Points}");
        await Task.Delay(250);

        if (Points >= 100)
        {
            AchievementUnlocked?.Invoke();
            //Console.WriteLine($"[Player2.cs] You won at life!");

        }
    }
}
