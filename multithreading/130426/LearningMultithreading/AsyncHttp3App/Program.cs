// See https://aka.ms/new-console-template for more information
Console.WriteLine("Starting Async3HTTPApp");


//var tasks = GetURLTasks();
//await DoMultiRequests(tasks);

//var task = Task.Factory.StartNew(CallWebService).ContinueWith((PreviousTask) => CallStoredProc(PreviousTask.Result));
var task= Task.Factory.StartNew(CallWebService).
//var task= Task.Run(CallWebService).
    ContinueWith((PreviousTask) => CallStoredProc(PreviousTask.Result));
Console.WriteLine("some cool cpu tasks 1");
Console.WriteLine("some cool cpu tasks 2");
Thread.Sleep(1000);
Console.WriteLine("some cool cpu tasks 3");
Console.WriteLine("some cool cpu tasks 4");
var res = await task;
Console.WriteLine($"res: {res}");
//Console.WriteLine("task started");
//Console.WriteLine($"task.Status: {task.Status}");
//Console.WriteLine($"task.IsCompleted: {task.IsCompleted}");
//Console.WriteLine($"task.IsFaulted: {task.IsFaulted}");
//Console.WriteLine($"task.IsCanceled: {task.IsCanceled}");
//Console.WriteLine($"task.Exception: {task.Exception}");

//Thread.Sleep(8000);
//Console.WriteLine("task completed");
//Console.WriteLine($"task.Status: {task.Status}");
//Console.WriteLine($"task.IsCompleted: {task.IsCompleted}");
//Console.WriteLine($"task.IsFaulted: {task.IsFaulted}");
//Console.WriteLine($"task.IsCanceled: {task.IsCanceled}");
//Console.WriteLine($"task.Exception: {task.Exception}");


//await task;
decimal CallWebService() 
{
    Console.WriteLine("[WebServer() Started]");
    ShowThreadInfo();
    Thread.Sleep(Random.Shared.Next(2000, 4000));
    Console.WriteLine("[WebServer() Ended]");
    return 420.69M;
};

string CallStoredProc(decimal input_money) 
{
    Console.WriteLine("[CallStoredProc() Started]");
    ShowThreadInfo();
    Thread.Sleep(Random.Shared.Next(2000, 4000));
    //Console.WriteLine($"You can buy 666 pokemon cards with ${input_money} (from webservice).");
    Console.WriteLine("[CallStoredProc() Ended]");
    return $"You can buy 666 pokemon cards with ${input_money} (from webservice).";
}
