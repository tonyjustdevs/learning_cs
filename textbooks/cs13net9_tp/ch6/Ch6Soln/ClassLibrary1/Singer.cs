using TP.SharedLibraries;

namespace SharedClassesLibrary;

public abstract class Singer : Person
{
    public abstract void Sing();
}

public class LadyGaga : Singer
{
    //string? Name = "Gaga";
    public sealed override void Sing() => WriteLine("Lady gaga sings uniquely");

    public LadyGaga()
    {
        Name = "Gagagagagagaaaa!";
    }
}
