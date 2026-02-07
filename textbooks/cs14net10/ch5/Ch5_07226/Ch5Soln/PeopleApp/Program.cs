using Dumpify;
using System;
using TPNS.TPSharedLibNet2;
using TPNS.TPSharedModernLib;

ConfigureDumpify();
Console.WriteLine("Hello People App!");

Person bob = new()
{
    Name = "bob",
    Dob = new DateTimeOffset(2000, 1, 1, 0, 0, 0, TimeSpan.FromHours(5)),
    Children = [
        new Person{Name="kiddo1", SportLiked=(EnumByteSports)66},
        new Person{Name="kiddo2", SportLiked=(EnumByteSports)12},
        new Person{Name="kiddo3", SportLiked=(EnumByteSports)42}],
    SportsFav = EnumSports.Football,
    SportLiked = (EnumByteSports)69
};

bob.Dump();

var (out_name, out_dob) = bob;
WriteLine("{0} is born on {1}", out_name, out_dob);

WriteLine(bob.PropGetOrigin);
WriteLine(bob.PropGreeting);
WriteLine($"{bob.PropGetAge}");


// set prop sport
WriteLine(bob.PropSportsTop);
bob.PropSportsTop = EnumByteSports.Football;
WriteLine(bob.PropSportsTop);

WriteLine("bobs_kids via indexing: {0}, {1}, {2}", bob[0].Name, bob[1].Name, bob[2].Name);


WriteLine("bobs_kids via string:\n-{0}\n-{1}\n-{2}",
    bob["kiddo1"].SportLiked,
    bob["kiddo2"].SportLiked,
    bob["kiddo3"].SportLiked);


// 1. create passengers
Passenger[] passengers = [
    new FirstClass{Name="Albert",AirMiles=100_000},     // 90k
    new FirstClass{Name="Bob",AirMiles=51_000},         // 85k
    new FirstClass{Name="Brenda",AirMiles=49_000},      // 80k
    new FirstClass{Name="Brenda",AirMiles=1_000},       // 70k
    new BusinessClass{Name="Calvin"},                   // 60k
    new CoachClass{Name="Dominic",CarryOnKg=2_000},     // 55k
    new CoachClass{Name="Dominic",CarryOnKg=800},       // 45k
    new CoachClass{Name="Elliot",CarryOnKg=600},        // 35k
    new CoachClass{Name="Francis"}                      // 30k
    ];

foreach (Passenger passenger in passengers)
{
    decimal flight_costs = passenger switch
    {
        FirstClass p when p.AirMiles >  99_000  => 90_000M,
        FirstClass p when p.AirMiles >= 50_000  => 85_000M,
        FirstClass p when p.AirMiles >= 30_000  => 80_000M,
        FirstClass _                            => 70_000M,
        BusinessClass _                         => 60_000M,
        CoachClass p when p.CarryOnKg >=  1000  => 55_000M,
        CoachClass p when p.CarryOnKg >= 700    => 45_000M,
        CoachClass p when p.CarryOnKg >= 500    => 35_000M,
        CoachClass                              => 30_000M,
        _ => 100M
    };

    WriteLine($"{passenger} has flight costs of: ${flight_costs}");
}


// compare record and classes

AnimalClass animal_cls_1 = new() {Name="Kevin" };
AnimalClass animal_cls_2 = new() {Name="Kevin"};
AnimalRecord animal_rcd_2 = new(){Name="Kevin"};
AnimalRecord animal_rcd_1 = new(){Name="Kevin"};

WriteLine("comparing animal classes: {0}",animal_cls_1 == animal_cls_2);
WriteLine("comparing animal records: {0}",animal_rcd_1== animal_rcd_2);

WriteLine("comparing ac.Names: {0}", animal_cls_1.Name == animal_cls_2.Name);
WriteLine("comparing ar.Names: {0}", animal_rcd_1.Name == animal_rcd_2.Name);

// test records
ImmutableAnimals cat = new("oreo", "cat");
ImmutableAnimals spot = new("spot", "dog");
ImmutableAnimals pikachu = new("pikachu ", "pokemon");

WriteLine($"{cat}");
WriteLine($"{pikachu}");
WriteLine($"{spot}");
//public record ImmutableAnimals(string Name, string Species);


// test headphones
Headset default_headset = new();
WriteLine($"default_headset: {default_headset.ManuName}");
Headset vision_pro = new("Vision Pro","Apple");
Headset hololens = new("Holo Lens", "MS");
Headset quest3 = new("Quest3", "Meta");

vision_pro.Dump();
hololens.Dump();
quest3.Dump();