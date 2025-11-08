namespace TP.SharedLibraries;

public class Player2
{
    public int Points { get; private set; }
    public delegate void AchievementUnlockedIntHandler(int points);
    //public delegate void AchievementUnlockedStrHandler(string points);
    public event AchievementUnlockedIntHandler? AchievementIntUnlocked;
    //public event AchievementUnlockedStrHandler? AchievementStrUnlocked;
    public async Task AddPoints(int points)
    {
        Points += points;
        await Task.Delay(200);
        Console.WriteLine($"{points} added, Total: {Points}");
        if (Points >= 100) { 
            AchievementIntUnlocked?.Invoke(Points);
            //AchievementStrUnlocked?.Invoke((string)Points);
            //Console.WriteLine($"{Points} reached! You Win!"); 
        }
        ;
    }
}