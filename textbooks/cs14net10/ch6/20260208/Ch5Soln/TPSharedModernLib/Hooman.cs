namespace TPSharedModernLib;

public class Hooman : IKeys, IGamer
{
    public void Lose() // implicit
    {
        WriteLine("You lost your keys!");
    }

    void IGamer.Lose() // explicit
    {
        WriteLine("You lost the game!");
    }

}
