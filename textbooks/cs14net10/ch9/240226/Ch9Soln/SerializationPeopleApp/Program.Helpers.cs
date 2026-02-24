partial class Program
{
    private static void ShowFileInfo(string full_path)
    {
        WriteLine($"File: \t{GetFileName(full_path)}");
        WriteLine($"Dir: \t{GetDirectoryName(full_path)}");
        WriteLine($"Size: \t{new FileInfo(full_path).Length:N0} bytes");
        WriteLine($"Contents: ");
        WriteLine($"/ ----------------------------- /");
        //var string_list = File.ReadAllLines(full_path);
        //foreach (var line in string_list)
        //{
        //    WriteLine(line);
        //}
        WriteLine($"{File.ReadAllText(full_path)}");
        WriteLine($"/ ----------------------------- /");
    }
    static void SectionTitle(string title)
    {
        var bgcolor = BackgroundColor;
        BackgroundColor = ConsoleColor.DarkBlue;
        WriteLine($"\n ------------ {title} ------------ \n");
        BackgroundColor = bgcolor;
    }

}

