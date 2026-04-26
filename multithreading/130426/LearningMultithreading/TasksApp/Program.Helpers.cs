partial class Program
{

    static void Method1()
    {
        Console.WriteLine("\nbeg_meth1");
        OutputThreadInformation();
        Console.WriteLine("end_meth1\n");
        Thread.Sleep(500);
    }

    static void Method2()
    {
        Console.WriteLine("\nbeg_meth2");
        OutputThreadInformation();
        Console.WriteLine("end_meth2\n");
        Thread.Sleep(200);
    }
    static void Method3()
    {
        Console.WriteLine("\nbeg_meth3");
        OutputThreadInformation();
        Console.WriteLine("end_meth3\n");
        Thread.Sleep(5000);
    }

    static void OutputThreadInformation()
    {
        var t = Thread.CurrentThread;
        Console.WriteLine("- id: {0}, name: {1}, state: {2}, tpool: {3}, isBG: {4}, priority: {5}",
            t.ManagedThreadId, t.Name ?? "null", t.ThreadState, t.IsThreadPoolThread, t.IsBackground, t.Priority);
    }


}
