using System.Drawing;

partial class Program
{
    static void SectionTitle(string title)
    {
        var bgcolor = BackgroundColor;
        BackgroundColor = ConsoleColor.DarkBlue;
        WriteLine($"\n ------------ {title} ------------ \n");
        BackgroundColor = bgcolor;
    }

    private static void GetFileInfo(string path)
    {

    }
}
