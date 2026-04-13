
// scenario 2: run 2 threads asynchronously
// - create new thread & run task
// - run task in main thread

// expectations: 
// - unpredictable?

void WriteThreadId1()
{
    for (int i = 0; i < 100; i++)
    {
        Thread.Sleep(50);
        Console.WriteLine($"WriteThreadId() [id: {Environment.CurrentManagedThreadId}]");
    }
}
Thread thread1 = new Thread(WriteThreadId1);    // new thread [no blocking]
thread1.Start();
WriteThreadId1();                               // main thread [always blocks]

