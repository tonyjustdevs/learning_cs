// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
Console.WriteLine("PROGRAM STARTED");
Stopwatch timer = Stopwatch.StartNew();
///////////---------------- END ----------------///////////
Console.WriteLine("before DoIOWork()");
var res = DoIOWork();
Console.WriteLine("after DoIOWork() 1 ");
Console.WriteLine($"result 1: {res.Result}"); 
Console.WriteLine("after DoIOWork() 2 ");
Console.WriteLine($"result 2: {res.Result}"); 
Console.WriteLine("after DoIOWork() 3 ");

async Task<int> DoIOWork() 
{ 
    HttpClient http_client = new();

    Console.WriteLine("-- started DoIOWork()");
    Task<string> task_str = http_client.GetStringAsync("https://www.google.com/");
    Console.WriteLine("-- doing DoIOWork()");
    string result = await task_str; // RETURNS task_str.Result upon completion / AFTER [pause]

    // [PAUSED] & [RESUMED]
    Console.WriteLine("-- finished DoIOWork()");
    return result.Length;
}

///////////---------------- END ----------------///////////
Console.WriteLine($"{timer.ElapsedMilliseconds:#,##0}ms elapsed.");
Console.WriteLine("PROGRAM ENDED");
