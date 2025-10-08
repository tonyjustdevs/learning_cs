Cat oreo = new Cat { Name = "oreo", Legs = 4, DOB = new DateOnly(2018, 12, 1) ,isDomesticated=false};
Cat lilo= new Cat { Name = "lilo", Legs = 4, DOB = new DateOnly(2018, 12, 1) ,isDomesticated=true};
Snake snek = new Snake{ Name = "sneko",Legs= 0, DOB=new DateOnly(2019, 4, 30), isVenomous=false};

var animal_farm = new List<Animal?> { oreo, lilo, null, snek };

foreach (Animal? animal in animal_farm)
{
    //if (animal is null) { continue; }
    //Console.WriteLine($"{animal?.Name} is a {animal?.GetType()} with {animal?.Legs} legs & DOB {animal?.DOB}"); 
    string msg;
    switch (animal)
    {
        case Cat FourLeggedFreak when FourLeggedFreak.Legs == 4 && FourLeggedFreak.isDomesticated == true:
            msg = $"[{nameof(FourLeggedFreak)}]: you four-legged freaky docile nice kitty, {FourLeggedFreak.Name}."; 
            break;
        case Cat WildFeline when WildFeline.isDomesticated == false && WildFeline.Legs == 4:
            msg = $"[{nameof(WildFeline)}]: damn {WildFeline.Name} you are wild one!";
            break;
        case Snake:
            msg = $"why such a normal snake, Snake?";
            break;
        default:
            msg = "a regular animal construct";
            break;
        case null:
            msg = "a non-existent animal!";
            break;
    }
    Console.WriteLine(msg);
}
class Animal
{
    public required string Name;
    public int Legs;
    public DateOnly DOB;
}

class Cat : Animal
{
    public bool isDomesticated;
}

class Snake : Animal
{
    public bool isVenomous;
}
