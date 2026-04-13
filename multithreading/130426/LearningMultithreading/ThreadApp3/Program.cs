
// scenario 3: run 2 new threads asynchronously

// expectations: 
// - unpredictable handling by task scheudler

void WriteThreadId1()
{
    for (int i = 0; i < 50; i++)
    {
        //Thread.Sleep(50);
        //Console.WriteLine($"WriteThreadId() [id: {Environment.CurrentManagedThreadId}]");
        Console.WriteLine($"WriteThreadId() [name: {Thread.CurrentThread.Name}]");
    }
}
Thread thread1 = new Thread(WriteThreadId1);    // new thread [no blocking]

Thread thread2 = new Thread(WriteThreadId1);    // new thread [no blocking]
thread1.Name = "thread1";
thread2.Name ="thread2";
Thread.CurrentThread.Name = "main_thread";
thread2.Start();
thread1.Start();
WriteThreadId1();                               // main thread [always blocks]

