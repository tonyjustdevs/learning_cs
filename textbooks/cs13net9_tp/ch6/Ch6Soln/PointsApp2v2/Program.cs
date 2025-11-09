using TP.SharedLibraries;

Player2 p = new();

p.AchievementUnlocked+= WinningMessage;
await p.AddPoints(40);
await p.AddPoints(30);
await p.AddPoints(50);

static void WinningMessage()
{
    //Console.WriteLine($"You won at life! {Points} points.");
    Console.WriteLine($"[Program.cs] You won at life!");
}