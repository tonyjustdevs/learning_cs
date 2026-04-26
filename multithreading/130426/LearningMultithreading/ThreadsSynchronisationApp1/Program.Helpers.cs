using System.Diagnostics.Metrics;
using System.Threading.Tasks;

partial class Program
{
    static void ShowThreadInfo()
    {
        Console.WriteLine($"[" +
            $"nm: {Thread.CurrentThread.Name}, " +
            $"pr: {Thread.CurrentThread.Priority}, " +
            $"st: {Thread.CurrentThread.ThreadState}, " +
            $"tp: {Thread.CurrentThread.IsThreadPoolThread}, " +
            $"bg: {Thread.CurrentThread.IsBackground}], " +
            $"id: {Thread.CurrentThread.ManagedThreadId}]");
    }
    static void Meth1()
    {
        Console.WriteLine("[Meth1] started.");
        ShowThreadInfo();
        Thread.Sleep(1000);
        Console.WriteLine("[Meth1] ended.");
    }

    static void Meth2()
    {
        Console.WriteLine("[Meth2] started.");
        ShowThreadInfo();
        Thread.Sleep(2000);
        Console.WriteLine("[Meth2] ended.");
    }

    static void Meth3()
    {
        Console.WriteLine("[Meth3] started.");
        ShowThreadInfo();
        Thread.Sleep(3000);
        Console.WriteLine("[Meth3] ended.");
    }

    static async Task DoAsyncHttpGet()
    {
        Console.WriteLine("Start of DoAsync()...");
        HttpClient http_client = new();

        List<string> urls = [
            "https://api.github.com",
            "https://jsonplaceholder.typicode.com/posts/1",
            "https://jsonplaceholder.typicode.com/posts/2"
        ];

        List<Task<string>> tasks = [
            http_client.GetStringAsync(urls[0]),
            http_client.GetStringAsync(urls[1]),
            http_client.GetStringAsync(urls[2]),
        ];

        await foreach (var completed_tasks in Task.WhenEach(tasks))
        {
            try
            {
                var res = await completed_tasks;
                Console.WriteLine($"response_length: {res.Length}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"failed: {ex.Message}");
            }
        }
        Console.WriteLine("End of DoAsync()...");
    }



    static Task Step1()
    {
        return Task.Delay(2000);
    }
    // v1: actuall returns void but yeh
        // - task is created
        // - [timer] is registered (register a callback: "after 1sec, mark [Task] as [completed]”)
        // - immediately move to next line (aka print 2)
        //Console.WriteLine("2"); // this prints?

        //Console.WriteLine($"task.Status: {task.Status}");
        //Console.WriteLine($"task.IsCompleted: {task.IsCompleted}");
        //Console.WriteLine($"task.IsFaulted: {task.IsFaulted}");
        //Console.WriteLine($"task.IsCanceled: {task.IsCanceled}");
        //Console.WriteLine($"task.Exception: {task.Exception}");
        //Console.WriteLine($"task.Result: {task.Result}");
        
        //await Task.Delay(1000); // v2: PAUSES method right there until 1 sec elapses
        // - Task is created
        // - [continuation] is registered 
        // - gives back control to caller??
        // - code after "await" is [delayed]

        // - task is created,
        // - task represents 'work' to be completed later,
        // - 'work' which MAY be executed by a 'thread', its a receipt, the 'thread' is the actual worker


}
