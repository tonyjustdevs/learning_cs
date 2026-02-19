partial class Program
{
    static void GetFileInfo(string file_path)
    {
        WriteLine("[running from XmlViperVSApp Program.Helpers]");
        WriteLine($"File: \t\t{GetFileName(file_path)}");
        WriteLine($"Directory: \t{GetDirectoryName(file_path)}");
        WriteLine($"Size: \t\t{new FileInfo(file_path).Length:N0}");
        WriteLine($"/ -------------------------------- ");
        WriteLine($"{File.ReadAllText(file_path)}");
        WriteLine($"  -------------------------------- / ");

    }

}

