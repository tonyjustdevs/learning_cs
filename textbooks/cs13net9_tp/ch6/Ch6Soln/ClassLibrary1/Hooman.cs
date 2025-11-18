namespace TP.SharedLibraries;

public class Hooman : IGamer, IKeyHolder
{
    public void Lose() => Console.WriteLine("you lost a key!");
    void IKeyHolder.Lose() => Console.WriteLine("you lost a life!");
}

public interface IKeyHolder
{
    public void Lose();
}

public interface IGamer
{
    public void Lose();
}
