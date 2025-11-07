using System.Threading.Channels;

namespace TP.SharedLibraries;

public class Player2
{
    public int Points { get; private set; }
    public delegate void Achieved100PointsHandler(int points);

    //public event Action? Achieved100Points;
    public event Achieved100PointsHandler? Achieved100Points;
    public async Task AddPoints(int points)
    {
        Points += points;
        Console.WriteLine($"{points} p  oints added! Total Points: {Points}");
        await Task.Delay(150);

        if (Points > 100) {
            Achieved100Points?.Invoke(Points);
            //Console.WriteLine($"Congratulations, you've reached {Points} points");
        }
    }
}
// [creating and using event]
// 1.  add eventfld action
// 2a. add eventfld?.invoke() somewhere you want it to be invoked (so people can subscribe to it)
// 2b.   e.g. add insde a method() with if() criteria to reach
// 3. in program.cs  add custom_methods() to the field, so these custom_methods() will run if criteria reached.