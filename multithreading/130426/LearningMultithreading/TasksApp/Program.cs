using System.Diagnostics;

Console.WriteLine("Hello to TasksApp!\n");
Stopwatch timer = Stopwatch.StartNew();
//Method1();
//Method2();
//Method3();

Task task1 = new Task(Method1);
task1.Start();
Task task2 = Task.Factory.StartNew(Method2);
Task task3 = Task.Run(Method3);
//task1.Wait();
//task2.Wait();
//task3.Wait();

Task[] tasks = new Task[]{ task1, task2, task3 };

//Task.WaitAny(tasks); //continues after any 1 tasks finishes
Task.WaitAll(tasks);
Console.WriteLine($"{timer.ElapsedMilliseconds:#,##0}ms elapsed.");
Console.WriteLine("\nProgram Ended\n");


