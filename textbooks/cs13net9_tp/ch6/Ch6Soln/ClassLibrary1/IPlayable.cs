
namespace TP.SharedLibraries;

public interface IPlayable
{
    public void Play();
    public void Pause();

    public void Stop()
    {
        Console.WriteLine("dvd is stopped (default implementation)");
    }
}


