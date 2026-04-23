
// create two threads that add to the same counter
// 1. no lock -> sychronisation issues
// 2. lock -> solved
int ctr = 0;

object _CounterLock = new object();
Thread thread1 = new Thread(IncrementCounter);
Thread thread2 = new Thread(IncrementCounter);

thread1.Start();
thread2.Start();
thread1.Join();
thread2.Join();

Console.WriteLine($"ctr: {ctr}");

void IncrementCounter()
{
    for (int i = 0; i < 1000_000; i++)
    {
        lock (_CounterLock)
        {
            ctr = ctr + 1;
        }
    }
}