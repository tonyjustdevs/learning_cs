using Dumpify;
using NSTP.TPSharedLibModern;
using TPNS.TPSharedLibNet2;
DumpConfig.Default.TableConfig.ShowMemberTypes = true;
DumpConfig.Default.MembersConfig.IncludeFields = true;
DumpConfig.Default.MembersConfig.IncludeProperties = true;
DumpConfig.Default.MembersConfig.IncludeNonPublicMembers = true;
DumpConfig.Default.MembersConfig.IncludePublicMembers = true;
DumpConfig.Default.MembersConfig.IncludeVirtualMembers= true;

Console.WriteLine("Welcome to PeopleWorld!");

Person bob = new()
{
    Name = "bob",
    Born = new DateTimeOffset(1990, 6, 1, 0, 0, 0, TimeSpan.FromHours(5)),
    //SportsByteFav = EnumByteSports.Tennis,
    SportsLiked = (EnumByteSports)69,
    //FavouriteColour = "red"
};

bob.Children.AddRange([         // add children
    new Person {Name="kid0", FavouriteColour="blue"},
    new Person {Name="kid1", FavouriteColour="green"},
    new Person {Name="kid2", FavouriteColour="red"},
]);

bob.Friends.AddRange([
    new Person{Name="Christina"},
    new Person{Name="Soph"},
    new Person{Name="Japeth"},
    new Person{Name="Ronald"},
    new Person{Name="Grace"}
]);
// Deconstruct
// get name and dob via deconstruction
//var (o_name, DateTime o_dob)= bob;
//WriteLine("name: {0} dob: {1} (via implicit Deconstruct())", o_name, o_dob);
//var (o_name,_,o_kiddos)= bob;

//bob.SportsByteFav = EnumByteSports.Golf;  // ok
bob.SportsByteFav = (EnumByteSports)8;      // ok:      one of the valid bits
//bob.SportsByteFav = (EnumByteSports)9;    // not-ok:  one of the valid bits
bob.SportsLiked = EnumByteSports.Golf| EnumByteSports.Surfing; // ok
//bob.SportsLiked = (EnumByteSports)69;     // ok

//WriteLine("{0}'s first kid is: {1}"  ,bob.Name,bob[0].Name);
//WriteLine("{0}'s second kid is: {1}" ,bob.Name,bob[1].Name);
//WriteLine("{0}'s final kid is: {1}"  ,bob.Name,bob[2].Name);

//WriteLine("{0}'s first friend is: {1}"  ,bob.Name,bob[0].Name);

//foreach (var friend in bob.Friends)
//{
//    WriteLine("- {0}", friend.Name);
//}

// 1. set a valid single game
// 2. set a invalid single game

//bob.GamesByteFavProp = EnumByteGames.Terraria;            // ok
//bob.GamesByteFavProp = (EnumByteGames)69;              // ok

//bob.GamesLiked = EnumByteGames.MarioKart64 | EnumByteGames.Tetris | EnumByteGames.Pokemon; // ok
bob.GamesLiked = (EnumByteGames)69; // ok
//bob.GamesLiked = (EnumByteGames)1; // ok

bob.Dump();// Dumpf

Passenger[] passengers = {
    new FirstClassPassenger { AirMiles = 1_419, Name = "Suman" },
    new FirstClassPassenger { AirMiles = 16_562, Name = "Lucy" },
    new BusinessClassPassenger { Name = "Janice" },
    new CoachClassPassenger { CarryOnKG = 25.7, Name = "Dave" },
    new CoachClassPassenger { CarryOnKG = 0, Name = "Amit" }
};

//Lucy: 30000
//Suman: 25000
//Janice: 15000
//Dave: 10000
//Amit: 5000

foreach (var passenger in passengers)
{
    decimal flightcosts = passenger switch
    {
        FirstClassPassenger p when p.AirMiles > 15_000 => 30_000M,
        FirstClassPassenger p when p.AirMiles > 15_000 => 25_000M,
        FirstClassPassenger p when p.AirMiles > 1000 => 20_000M,
        FirstClassPassenger _ => 18000,
        BusinessClassPassenger _ => 15_000M,
        CoachClassPassenger p when p.CarryOnKG > 25 => 10_000M,
        CoachClassPassenger _ => 5_000M
    };

    WriteLine("{0}: {1} ", passenger.Name, flightcosts);
}
//calculate cost for each passenger
// An array containing a mix of passenger types.


// 1. create a immutable car record
// 2. update immutable car record colour

ImmutableCar red_toyota = new() { Brand = "toyota", Colour = "red" };

    
red_toyota.Dump();

ImmutableCar blue_toyota = red_toyota with { Colour = "blue" };
blue_toyota.Dump();

//ImmutableAnimal oreo_cat = new() { Name="Oreo", Animal="cat"};
//oreo_cat.Dump();

ImmutableAnimal oreo = new("oreo", "cat");
oreo.Dump();

// deconstruct
var(oreo_name, oreo_animal) = oreo;
WriteLine("{0} is a {1}", oreo_name, oreo_animal);

// new record: lucky the dog
ImmutableAnimal lucky = oreo with { Name = "lucky", Animal = "dog" };
lucky.Dump();