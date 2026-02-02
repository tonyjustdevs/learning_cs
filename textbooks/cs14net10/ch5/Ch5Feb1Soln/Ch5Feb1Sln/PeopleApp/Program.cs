using Dumpify; // To use the Dump extension method.
using TPNS.TPSharedLibModern;
using TPNS.TPSharedLibNet2;
// add person instance


Person bob = new() {
    Name="bob" ,
    Born=new DateTimeOffset(1990,6,12,0,0,0,TimeSpan.Zero)
};

Console.WriteLine("Welcome to People App!");
Console.WriteLine($"{bob.Name} was born:\n- on {bob.Born:D}\n");

bob.CountryFrom = EnumCountrys.Australia;
Console.WriteLine($"{bob.Name} is from:\n- {bob.CountryFrom} (enum: {(int)bob.CountryFrom})\n");

bob.CountryVisited = (EnumByteCountrys)69;
Console.WriteLine($"{bob.Name} has visited:\n- {bob.CountryVisited} (enum: {(int)bob.CountryVisited})\n");

DumpConfig.Default.TableConfig.ShowMemberTypes = true;
DumpConfig.Default.UseAutoLabels = true;

bob.Dump(label: "Default output (no customisation of 'members' field)");
bob.Dump(label: "Include MembersConfig() instance & set true for Fields and Non-Public Members",
  members: new MembersConfig
  {
      IncludeFields = true,
      IncludeNonPublicMembers = true
  });

Person alice = new Person { Name = "alice", Born = new DateTimeOffset(2000, 1, 1, 0, 0, 0, TimeSpan.Zero) };

Console.WriteLine();

//alice.Dump(label: "al", members: new MembersConfig
//{
//    IncludeFields = true,
//    IncludeNonPublicMembers = true,
//    IncludeProperties = true
//});

//Book book = new() { Title = "Harry Potter 1", ISBN="n/a"};

//book.Dump(members: new MembersConfig {
//    IncludeFields=true,
//    IncludeNonPublicMembers=true,
//    IncludeVirtualMembers=true,
//    IncludePublicMembers=true,
//    IncludeProperties=true
//});

Person nameless_person = new();

DumpConfig.Default.MembersConfig.IncludeFields = true;
DumpConfig.Default.MembersConfig.IncludeProperties = true;
DumpConfig.Default.MembersConfig.IncludeNonPublicMembers= true;
nameless_person.Dump();

WriteLine("'{0}' of '{1}' was created '{2:hh:mm:ss:fffffff}' on a '{2:dddd}'",
    nameless_person.Name,
    nameless_person.HomePlanet,
    nameless_person.Instantiated);

Book book = new(
    isbn: "978-1803237800", 
    title: "C# 14 and .NET 10 - Modern Cross-Platform Development Fundamentals")
{};







