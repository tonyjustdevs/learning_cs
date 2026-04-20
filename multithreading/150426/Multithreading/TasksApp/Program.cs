// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;

Console.WriteLine("\nHello TasksApp1");

Task task1 = new Task(SayHello);
Thread thread1 = new Thread(SayHello);
task1.Start();
Task<int> task_int3 = Task.Run(() => GetStrLen());
Task task3 = Task.Run(SayHello);

task1.Wait();
// Create Tasks with Retrun Values
string outer_string = "mate";
Task<int> task_int1 = Task.Run(()=>{
    return outer_string.Length;});
thread1.Start();
thread1.Join();


Task<int> task_int2 = Task.Run(() => GetStrLen(outer_string));


Task task4 = Task.Run(()=> SayHello());
Task task5 = Task.Run(()=> {
    Thread.Sleep(500);
    Console.WriteLine($"hello1 " +
        $"[tid: {Environment.CurrentManagedThreadId}] " +
        $"[tpool:{Thread.CurrentThread.IsThreadPoolThread}]");
});
await Task.Factory.StartNew(() => SayHello());

// does this block or get skipped?

Console.WriteLine("\nGoodbye TasksApp1");
Console.WriteLine($"task_int1: {task_int1.Result}");
Console.WriteLine($"task_int2: {task_int2.Result}");
Console.WriteLine($"task_int3: {task_int3.Result}");

//Console.ReadLine();

//https://learncsharpmastery.com/task-based-asynchronous-pattern/

//1.change symbol status(full, closed, etc) for specific symbols across MT4 / 5
//2.extract MT4 / 5 server journals