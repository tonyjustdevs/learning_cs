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

    static async Task DoMultiRequests(List<Task<string>> tasks)
    {

        await foreach (var completedTask in Task.WhenEach(tasks))
        {
            try
            {
                string res = await completedTask; // what does this line do?
                ShowThreadInfo();
                Console.WriteLine(res.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    static List<Task<string>> GetURLTasks()
    {
        HttpClient http_client = new();

        List<string> urls = [
            "https://api.github.com",
    "https://jsonplaceholder.typicode.com/posts/1",
    "https://jsonplaceholder.typicode.com/posts/2"
        ];

        List<Task<string>> tasks = new List<Task<string>>();

        foreach (var url in urls)
        {
            tasks.Add(http_client.GetStringAsync(url));
        }
        return tasks;
    }
}
