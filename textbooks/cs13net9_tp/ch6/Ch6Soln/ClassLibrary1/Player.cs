
namespace TP.SharedLibraries;

public class Player
{
    public int Points { get; private set; }
    
    public async Task AddPoints(int points)
    {
        Points += points;
        Console.WriteLine($"You earned {points}! Total Points: {Points}.");
        await Task.Delay(200);

        if (Points > 100)
        {
            Console.WriteLine($"Congratulations! You've reached {Points} points.");
        }
    }
}

// [A] add [Player.cs]
// 0.  add add to Namespace
// 1.  add Player cls
// 2.  add Points fld {getter/setter}
// 3a. add async Task AddPoints method(): param int points
// 3b.  add Pts += pts
// 3c.  add CW => pts & Pts
// 3d.  add await Task.Delay(100);
// 3e.  add if => Pts>100 => CW congrats


