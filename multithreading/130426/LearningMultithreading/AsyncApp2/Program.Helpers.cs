
partial class Program
{

    public static Task Step1()
    {
        return Task.Delay(1000);
    }

    public static async Task Step2()
    {
        Console.WriteLine("[Step2] Do something before Delay(1000) [exp: 1]");
        await Task.Delay(1000); // task is return [Incompleted]
        Console.WriteLine("[Step2] Do something after Delay(1000) [exp: 4]");
    }
}
