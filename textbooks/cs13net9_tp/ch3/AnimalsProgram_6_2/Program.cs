// 1. declare an array of nullable animals,
// 2. show a message based on what type and attributes each animal has

var animals = new Animal?[]
{
    new Dog{Name="old dawgy dawg", Legs=4, Born=new DateOnly(year: 2000, month: 12, day: 25), isDomesticated=true},
    null,
    new Dog{Name="lil pupz", Legs=8, Born=new DateOnly(year: 2020, month: 01, day: 26),isDomesticated=false},
    new Snake{Name="imma snek", Legs=0, Born=new DateOnly(year: 1930, month: 02, day: 28),isVenomous=true},
};

foreach (Animal? curr_animal in animals)
{
    if (curr_animal is null) {
        continue;
    };
    WriteLine("Name: {0}, a {1}, was born on {2} with {3} legs.", 
        curr_animal?.Name,
        curr_animal?.GetType(),
        curr_animal?.Born,
        curr_animal?.Legs);
}