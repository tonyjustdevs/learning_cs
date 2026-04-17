
// 1. do 1 operationg: shout
// 2. add method doing 1 operation
// 3. create a new thread and run operation
// 3. track thread ids
//Console.WriteLine($"[{Environment.CurrentManagedThreadId}] main hello [prog.cs]");
//Get69();
//Thread thread = new Thread(Hello);
//thread.Start(); // non-blocking

//Thread thread2 = new Thread(Get69);
//// Scenarios:
//// 1: [thread2] finishes before [main_thread]
//// 2: [thread2] finishes after [main_thread]
//// 3: [thread2] during [main_thread] runs

//// Context:
//// [Variables] or [Results] from [thread2]
//// - cant just exist within its own brackets
//// - because dont know exactly when they're used...

//void Hello() { 
//    Console.WriteLine($"[{Environment.CurrentManagedThreadId}] method hello [hello()]");
////}

//int Get69(){ return 69; };  // 








//1.Define CreateFunction   → nothing happens

//2. Call CreateFunction     → function starts
//3. x = 10                  → variable created
//4. return lambda           → function prepared
//5. function exits          → THIS is “ended”

//6. f() is called later     → lambda runs
var f = CreateFunction();
var result = f();
Console.WriteLine($"result: {result}");
Func<int> CreateFunction()
{
    int x = 10;
    return () => x; // int TempMethod(){return x;}
}


Thread thread = new Thread(() => CreateFunction());
Thread thread2 = new Thread(() =>
{
    int x = 10;
    return ()=>x; // int TempMethod(){return x;}
}

);