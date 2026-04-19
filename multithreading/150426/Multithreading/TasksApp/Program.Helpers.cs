
partial class Program
{
    static void SayHello()
    {
        Thread.Sleep(500);
        Console.WriteLine($"hello1 " +
            $"[tid: {Environment.CurrentManagedThreadId}] " +
            $"[tpool:{Thread.CurrentThread.IsThreadPoolThread}]");
    }

    static int GetStrLen(string? name=null)
    {
        Thread.Sleep(3000);
        return name?.Length??0;
    }
}
