using Dumpify; // To use the Dump extension method.
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

bob.Dump(label: "Default output");
bob.Dump(label: "Include fields and non-public members",
  members: new MembersConfig
  {
      IncludeFields = true,
      IncludeNonPublicMembers = true
  });