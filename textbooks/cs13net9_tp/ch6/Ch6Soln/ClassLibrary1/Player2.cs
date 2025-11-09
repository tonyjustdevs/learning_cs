namespace TP.SharedLibraries;
public class Player2
{
    public int Points { get; private set; }
    public delegate void AchievementUnlockedHandler(int points);
    public event AchievementUnlockedHandler? AchievementUnlocked;
    public async Task AddPoints(int points)
    {
        Points += points;
        Console.WriteLine($"{points} added. Total: {Points}");
        await Task.Delay(250);

        if (Points >= 100)
        {
            AchievementUnlocked?.Invoke(Points);
            //Console.WriteLine($"[Player2.cs] You won at life!");

        }
    }
}
