
Console.WriteLine("Hello, World!");

// [1] create a task that [immediately returns]
// - check pre-completed
// - check pst-completed
//var task = Step1();
//Console.WriteLine($"\nPre-Delay:");
//Console.WriteLine($"- task.Status: {task.Status}");
//Console.WriteLine($"- task.IsCompleted: {task.IsCompleted}");
//Console.WriteLine($"- task.IsCompletedSuccessfully: {task.IsCompletedSuccessfully}");
//Console.WriteLine($"- task.Exception: {task.Exception}");
//Console.WriteLine($"- task.IsFaulted: {task.IsFaulted}");
//Console.WriteLine($"- task.IsCanceled: {task.IsCanceled}");

//Thread.Sleep(3000);

//Console.WriteLine($"\nPst-Delay:");
//Console.WriteLine($"- task.Status: {task.Status}");
//Console.WriteLine($"- task.IsCompleted: {task.IsCompleted}");
//Console.WriteLine($"- task.IsCompletedSuccessfully: {task.IsCompletedSuccessfully}");
//Console.WriteLine($"- task.Exception: {task.Exception}");
//Console.WriteLine($"- task.IsFaulted: {task.IsFaulted}");
//Console.WriteLine($"- task.IsCanceled: {task.IsCanceled}");

// [2] create a task that [awaits]
// - check pre-completed
// - check pst-completed


var t = Step2();
// [INNER.TASK][INCOMPLETED] t.delay(2000) is already running and completes in 2 seconds
Console.WriteLine("[main] Immediately does some stuff [exp: 2]");
Console.WriteLine("[main] Immediately does some stuff [exp: 3]");

Thread.Sleep(6000); // blocks [main] for 6 seconds
// [INNER.TASK][COMPLETED] t.delay(2000) completes in 2 seconds
// - [exp:4] prints

await t; // this line is irrelevant as Step2() is already complete ?

Console.WriteLine("[main] Runs after Thread.Sleep(6000) [exp: 5]");
