
// 1. print current thread id
// 2. create new thread & print id
// 3. run method 

void WriteThreadId1()
{
	for (int i = 0; i < 100; i++)
	{
		Console.WriteLine($"WriteThreadId() [id: {Environment.CurrentManagedThreadId}]");
	}
}
WriteThreadId1(); // main thread [always blocks]
Thread thread1 = new Thread(WriteThreadId1); // new thread [no blocking]
thread1.Start();
// expectations:
// 1. main thread runs (2) and blocks
// 2. new thread runs (other int)

