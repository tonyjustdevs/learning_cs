using TPNS.TPSharedLibNet2;
using Dumpify;



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


// get sports like by kid
