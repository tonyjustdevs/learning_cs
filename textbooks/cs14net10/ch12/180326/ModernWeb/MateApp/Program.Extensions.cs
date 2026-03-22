

using System.Runtime.CompilerServices;

partial class Program
{
}

public static class TonysStringExtension
{
    public static int TonysWordCounter(this string input_str)
    {
        return input_str.Length;
    }
}

public interface ILogger
{
    void Log(string msg);
}

public class CSLogger : ILogger
{
    public void Log(string msg)
    {
        WriteLine($"[{DateTime.Now.ToString("yyyyMMdd_HHmmss")}] CS-Log: {msg} ");
    }
}

public static class ILoggerExtensions
{
    public static void ErrorLog(this ILogger logger_instance, string msg)
    {
        WriteLine($"[{DateTime.Now.ToString("yyyyMMdd_HHmmss")}] ERROR-Log: {msg} ");
    }
}