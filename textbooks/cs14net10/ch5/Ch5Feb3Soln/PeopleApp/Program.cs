using Dumpify;
using System;
using System.Reflection.Metadata;
using System.Xml.Linq;
using TPNS.TPSharedLibNet2;

ConfigureDumpify();
//Create();
Person bob = Create();
Destroy(bob);

Person Create()
{
    Console.WriteLine("Hello People App!");
    // create instances
    Person bob = new() { 
        Name="bob",
        Born=new DateTimeOffset(1990,1,1,0,0,0,TimeSpan.Zero),
        GameFavourite= EnumGames.Pokemon,
        GameLiked= (EnumByteGames)69,
        Children = [new Person{ Name="kid1"},new Person{ Name="kid2"}],
    };


    Person blank_person = new();

    // output results
    //blank_person.Dump(label:"blank guy");
    bob.Dump(label:"bob");
    var (name1,dob1)= bob;
    WriteLine($"{name1},{dob1}");
    return bob;
}

void Destroy(Person person)
{
    // do tuple deconstrcution
    var (o_name, o_dob) = person;
    WriteLine("{0} is born {1}", o_name, o_dob);
    //var (o_name) = person;
}

