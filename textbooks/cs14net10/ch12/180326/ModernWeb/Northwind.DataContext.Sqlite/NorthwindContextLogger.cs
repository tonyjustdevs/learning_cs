namespace Northwind.EntityModels;

public class NorthwindContextLogger
{
    // create desktop file path
    //Environment.GetFolderPat
    // create directory if not exists

    public static void WriteLine(string msg) // instance method
    //public static void WriteToNwLogs(string msg) // instance method
    {
        string log_folder = Combine(Environment.GetFolderPath(SpecialFolder.Desktop), "nw_logs");
        if (!Directory.Exists(log_folder))
        {
            CreateDirectory(log_folder);
        }
        string datetimestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
        string northwind_filename = $"nwlog-{datetimestamp}.txt";  // northwindlog-<date_time>.txt,
        string northwind_full_path = Combine(log_folder, northwind_filename);
        WriteLine($"full_file_path: {northwind_full_path}");
        using StreamWriter northwind_filestream = File.AppendText(northwind_full_path);
        northwind_filestream.WriteLine(msg);
    }

    private static void WriteToLog(string? msg)
    {
        string log_dir_fullpath = Combine(Environment.GetFolderPath(SpecialFolder.Desktop), "nw_logs2");
        
        if (msg is null) return;

        if (!Directory.Exists(log_dir_fullpath))
        {
            Directory.CreateDirectory(log_dir_fullpath);
        }
        var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
        string log_filename_txt = $"nw-log-{timestamp}.txt";
        string log_filename_txt_fullpath = Combine(log_dir_fullpath, log_filename_txt);
        //File.AppendText 
        // 
    }












}
