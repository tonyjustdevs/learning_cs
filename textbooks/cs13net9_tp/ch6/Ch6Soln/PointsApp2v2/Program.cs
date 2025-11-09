using TP.SharedLibraries;

Player2 p = new();

p.AchievementUnlocked+= WinningMessage;
await p.AddPoints(40);
await p.AddPoints(30);
await p.AddPoints(50);

static void WinningMessage(int Points)
{
    Console.WriteLine($"[Program.cs] You won at life! {Points} points.");
}