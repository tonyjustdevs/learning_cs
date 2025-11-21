namespace TP.SharedLibraries;

public class Car : IFlyable, IDrivable // Car must implement Methods() of Interfaces
{
    public void Move() => Console.WriteLine("I'm moving on the road!");

    void IFlyable.Move() => Console.WriteLine("Oh I'm a flying car!!!");
}


public interface IDrivable 
{
    void Move();
}; //interface is (set up no parentheses) like a cls

public interface IFlyable {
    void Move();

};