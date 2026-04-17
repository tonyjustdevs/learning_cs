// Scenario 1: all on main thread
// 1.  print thread id: from program.cs
Console.WriteLine($"[id: {Environment.CurrentManagedThreadId}] (Program.cs)");

// 2.  create method [cpu_work]:
//     - output string
//     - output threadid

void SayHello() { Console.WriteLine($"[id: {Environment.CurrentManagedThreadId}] hello mate (SayHello())"); }

Thread thread1 = new(SayHello);

thread1.Start();
// 3.  thread id1 & id2 are the same (main) thread

