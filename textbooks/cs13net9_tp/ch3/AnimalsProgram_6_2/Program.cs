
class Animal
{
    public string? Name;
    public DateOnly Born;
    public byte Legs;
}

class Dog : Animal
{
    public bool isDomesticated;
}

class Snake : Animal
{
    public bool isVenomous;
}
