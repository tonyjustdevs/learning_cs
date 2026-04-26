using System.Threading.Tasks;

Console.WriteLine("Welcome to ThreadsSyncApp1!\n");

//Task task1 = Task.Run(Meth1);
//Task task2 = Task.Run(Meth2);
//Task task3 = Task.Run(Meth3);

//Task[] tasks = [task3, task1,task2];
//Task.WaitAll(tasks);

//await DoAsyncHttpGet();
var task = Step1();
Console.WriteLine($"[pre_delay] task.Status: {task.Status}");
Console.WriteLine($"[pre_delay] task.IsCompleted: {task.IsCompleted}");
Console.WriteLine($"[pre_delay] task.IsFaulted: {task.IsFaulted}");
Console.WriteLine($"[pre_delay] task.IsCanceled: {task.IsCanceled}");
Console.WriteLine($"[pre_delay] task.Exception: {task.Exception}");
//Console.WriteLine($"[pre_delay] task.Result: {task.Result}");

Thread.Sleep(5000);
Console.WriteLine($"[pst_delay] task.Status: {task.Status}");
Console.WriteLine($"[pst_delay] task.IsCompleted: {task.IsCompleted}");
Console.WriteLine($"[pst_delay] task.IsFaulted: {task.IsFaulted}");
Console.WriteLine($"[pst_delay] task.IsCanceled: {task.IsCanceled}");
Console.WriteLine($"[pst_delay] task.Exception: {task.Exception}");
//Console.WriteLine($"[pre_delay] task.Result: {task.Result}");

Console.WriteLine("\nProgram Ended");