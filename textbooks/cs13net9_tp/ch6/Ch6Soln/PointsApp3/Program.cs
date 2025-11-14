
//Player3 p = new();
//await p.AddPoints(20);
//await p.AddPoints(40);
//await p.AddPoints(30);
//await p.AddPoints(50);
//await p.AddPoints(60);
//using TP.SharedLibraries;
//using static TP.SharedLibraries.Person;

////MyDelegate
//MyDelegate mydg = SomeMethod;
//mydg("tony");

//Person
//using TP.SharedLibraries;

//Person messi = new Person();

using System.Runtime.InteropServices.JavaScript;
using TP.SharedLibraries;

Person messi = new(
    "messi",
    new DateTimeOffset(1987, 06, 01, 0, 0, 0, 0, TimeSpan.Zero)
    );

messi.Shout?.Invoke(messi, EventArgs.Empty);

// Shout() is TPEHdlr(sendr, e):s
// // - ONLY RUNS() via parsing of
// // - [Specific Args] - type & format
// if Shout.Invoke() run, all attached-methods run automatically...

// 1. Running with Incorrect Format/Types (wont work)
messi.Shout?.Invoke("mate", EventArgs.Empty); 
// does nothing but why?
// no methods attached ---> Shout? is null, so skipped
messi.Shout += ShoutMeth1;
void ShoutMeth1(object? some_obj, EventArgs some_e) //some meth
{
    Console.WriteLine($"Inside ShoutMeth1 [prog.cs]");
    Console.WriteLine($"some_obj.type: {some_obj?.GetType()}");
    //string? some_str = (string?)some_obj;

    //Console.WriteLine("ShoutMeth1 run...");
    //Console.WriteLine($"some_obj: {some_obj}");
    //Console.WriteLine($"some_obj: {some_obj}")
}



//messi.Shout?.Invoke("mate", EventArgs.Empty);

messi.RunShout();
