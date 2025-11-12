namespace TP.SharedLibraries;
public class Player3
{
    // field Points
    public int Points { get; private set; }
    
    public void WinMsg(int Points) => Console.WriteLine($"You win! {Points}");

    public async Task AddPoints(int points)
    {
        Points += points;
        Console.WriteLine($"{points} points added. Total Points: {Points}");
        await Task.Delay(150);

        if (Points >= 100)
        {
            //Console.WriteLine($"You win! {Points}");
            WinMsg(Points);
            return;
        }
    }
}


public partial class Person
{
    public void SomeMethod(string name) => Console.WriteLine($"gday {name}");
    public delegate void MyDelegate(string some_str);
}