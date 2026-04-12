// See https://aka.ms/new-console-template for more information
Console.WriteLine("Starting Learning Async...");

var task1 = Task.Run(() => DoSomeWork(5000, 1));
var task2 = Task.Run(() => DoSomeWork(500, 2));
var task3 = Task.Run(() => DoSomeWork(100, 3));

Task.WaitAll(task1, task2, task3);
//https://code-maze.com/csharp-task-run-vs-task-factory-startnew/

void DoSomeWork(int milliseconds, int id)
{
    Thread.Sleep(milliseconds);
    Console.WriteLine($"Task '{id}' Completed");
}
Console.WriteLine("Ending Learning Async...");