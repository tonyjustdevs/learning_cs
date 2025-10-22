using TPLibraryProject;

///// create persons /////
// p1 //
Person tony = new();    //  default constructor 
tony.Name = "tony";
tony.Dob = new DateTime(2025, 04, 01);
tony.FavPlace = SightsOfSydney.Auburn;
tony.FavPlaceList = SightsOfSydneyList.Auburn | SightsOfSydneyList.Chatswood;

// p2 //
Person ange = new()     // default constructor + 
{                       // object initializer
    Name = "ange",
    Dob = new DateTime(1956, 1, 5),
    FavPlace = SightsOfSydney.TownHall
    //FavPlaceList = [SightsOfSydney.DulwichHill, SightsOfSydney.Rhodes]

};

// p3 //                // Constructor parms (by posns)
Person mate = new("mate", new DateTime(2025, 12, 06),
    SightsOfSydney.Blacktown);
    //FavPlaceList = [SightsOfSydney.DulwichHill, SightsOfSydney.Rhodes]);

//////////// results ////////////
Console.WriteLine($"Hello, {tony.Name}!");
Console.WriteLine($"Your DOB: {tony.Dob}!");    
Console.WriteLine($"Fav: {tony.FavPlace} [Rank: {(int)tony.FavPlace}]!");
Console.WriteLine($"FavList: {tony.FavPlaceList} (exp: )"); //2+4=6




Console.WriteLine();
Console.WriteLine($"Hello, {ange.Name}!");
Console.WriteLine($"Your DOB: {ange.Dob}!");
Console.WriteLine($"Fav: {ange.FavPlace} [Rank: {(int)ange.FavPlace}]!");
Console.WriteLine($"FavList: {ange.FavPlaceList}");

Console.WriteLine();
Console.WriteLine($"Hello, {mate.Name}!");
Console.WriteLine($"Your DOB: {mate.Dob}!");
Console.WriteLine($"Fav: {mate.FavPlace} [Rank: {(int)mate. FavPlace}]!");
Console.WriteLine($"FavList: {mate.FavPlaceList}");