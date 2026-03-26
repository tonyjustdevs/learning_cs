using static System.Environment;
namespace TP.EntityModels.Sqlite;

public static class TPContextLogger
{
    // creates file: "db-log-datetime.txt": eg "db-log-yyyymmdd_hhmmss.txt
    // create direcoty full path
    public static string LogDirFolderFullPath = Path.Combine(GetFolderPath(SpecialFolder.Desktop), "logs");
    public static string FileName = "nw-" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
    public static string LogFileFullPath = Path.Combine(LogDirFolderFullPath, FileName);
    public static void WriteToLog(string log_msg)
    {
        // 1.  create direcotry if not exist
        if (!Directory.Exists(LogDirFolderFullPath))
        {
            WriteLine($"{LogDirFolderFullPath} folder created! (because it didnt exist...) ");
            Directory.CreateDirectory(LogDirFolderFullPath);
        }
        //LogDirFolderFullPath
        WriteLine($"msg: {log_msg}");
        // create file stream
        using (var fs = File.AppendText(LogFileFullPath)){
            fs.WriteLine(log_msg);
        }
        // write to file?
    }
    

}
