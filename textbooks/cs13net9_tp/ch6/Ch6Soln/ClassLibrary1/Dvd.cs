
namespace TP.SharedLibraries;

public class Dvd : IPlayable
{
    public void Pause()
    {
        Console.WriteLine("dvd has paused..."); //throw new NotImplementedException();
    }

    public void Play()
    {
        Console.WriteLine("dvd is playing...");
    }
}
