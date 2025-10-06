
//Cat cat1 = new Cat { Name = "Oreo", Legs = 4, DOB = new DateOnly(2020, 12, 01) };
//Snake snek1 = new Snake { Name = "Hisser", Legs = 0, DOB = new DateOnly(1970, 12, 01) };

//List<Animal> sneks_and_cats = [cat1, snek1];

//var animals = new Animal?[]{
List<Animal> sneks_and_cats = [
    null,
    new Cat {"Oreo", 4, new DateOnly(2018,01, 14) }];
    //new Cat { Name = "Oreo", Legs = 4, DOB = new DateOnly(2020, 12, 01) }];
    //new Cat { "Oreo", 4, new DateOnly(year: 2018, 9, 14) },
    //new Cat {"Lilo", 4, new DateOnly(2020,10, 30) },
    //new Snake {"Hissy",0, new DateOnly(2024,1,15) }
//};

foreach (Animal animal in sneks_and_cats)
{
    WriteLine("{0},{1},{2},{3}", animal.Name, animal.DOB.ToString(), animal.Legs, animal.GetType());
}



// loop list output assign [msg] var:
// 1) cat + fourLeggedCat:  [Legs]  = 4
// 2) cat + wildcat:        [isDom] = False
// 3) cat                   
// 4) default
// 5) spider                [isVen] = True
// 6) null                  

// 7) output var