// brain storm
// house    - enter
// website  - enter

namespace TP.SharedLibraries;

public class Patron : IHouse, IWebsite
{
    public void Enter()
    {
        Console.WriteLine("You entered the House!");
    }

    void IWebsite.Enter()
    {
        Console.WriteLine("You entered the Website! Naughty!");
    }
}   

public interface IHouse
{
    void Enter();
}
public interface IWebsite
{ 
    void Enter();
}