using TPNS.TPSharedLibraryNet2;

WriteLine("Hello PeopleApp");

Person bob = new();
bob.Name = "bob";
bob.Born = new DateTimeOffset(1990,6,12,0,0,0,offset:TimeSpan.FromHours(-10));


Person jak = new()
{
    Name = "jak",
    Born= new DateTimeOffset(2000,6,12,0,0,0,TimeSpan.Zero)
};

WriteLine($"- {bob.Name} was born on {bob.Born:D}");
WriteLine($"- {jak.Name} was born on {jak.Born:d}");

bob.SportFavourite = EnumPopSports.Volleyball;
WriteLine($"- {bob.Name} chose {bob.SportFavourite} (enum: {(int)bob.SportFavourite})");

bob.SportsHated = EnumBytePopSports.Badminton | EnumBytePopSports.Tennis;
WriteLine($"- {bob.Name} hates: {bob.SportsHated} (bits: {(int)bob.SportsHated})");
bob.SportsHated = (EnumBytePopSports)69;  // Golf 4, Pickleball 64 Football 1 = 69
WriteLine($"- {bob.Name} now hates: {bob.SportsHated} (bits: {(int)bob.SportsHated})");










/// testing ///
//list, inefficient: bad big memory size 
//bob.SportsHated = [PopularSports.Pickleball, PopularSports.Golf, PopularSports.Swimming];
//Write("- {0} hates: ", bob.Name);
//foreach (PopularSports sport in bob.SportsHated) { Write($"{sport} "); };
//Write($" ({bob.SportsHated})");




