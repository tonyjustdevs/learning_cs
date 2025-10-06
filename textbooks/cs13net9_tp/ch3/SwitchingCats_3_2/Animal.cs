

class Animal                // A) base animal cls
{
    public string? Name;
    public byte Legs;
    public DateOnly DOB;
}

class Cat : Animal          // B. create cat cls
{
    bool isDomesticated;
}

class Snake : Animal          // B. create SNAKE cls
{
    bool isVenomous;
}



