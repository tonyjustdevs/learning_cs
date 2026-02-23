using System.Text.Json;
using System.Xml.Serialization; // To use XmlSerializer.
using Packt.Shared; // To use Person.


partial class Program
{
    private static void SectionTitle(string title)
    {
        ConsoleColor previousColor = ForegroundColor;
        ForegroundColor = ConsoleColor.DarkYellow;
        WriteLine($"*** {title} ***");
        ForegroundColor = previousColor;
    }
    private static void OutputFileInfo(string path)
    {
        WriteLine("**** File Info ****");
        WriteLine($"File: {GetFileName(path)}");
        WriteLine($"Path: {GetDirectoryName(path)}");
        WriteLine($"Size: {new FileInfo(path).Length:N0} bytes.");
        WriteLine("/------------------");
        WriteLine(File.ReadAllText(path));
        WriteLine("------------------/");
    }

    private static void DoSerialization(List<Person> ppl, string file_name)
    {
        XmlSerializer ppl_serializer = new(ppl.GetType());

        // create xml
        string full_file_path = GenerateFullFilePath(file_name);
        WriteLine($"{full_file_path}");
        using (FileStream fs = new(full_file_path, FileMode.Create))
        {
            ppl_serializer.Serialize(fs, ppl);
        }

        //using (FileStream fs = new()) 
        //{
        //    ppl_serializer.Serialize(fs, ppl);
        //}
    }

    static void SerializeOnceAgain(List<Person> peeps,string file_name)
    {   
        XmlSerializer im_very_xml_serial = new(peeps.GetType());

        using (FileStream fs = File.Create(GenerateFullFilePath(file_name))) 
        {
            im_very_xml_serial.Serialize(fs, peeps);
        }
    }

    private static void GenerateFileInfo(string file_name)
    {
        string full_path = GenerateFullFilePath(file_name);
        WriteLine($"File:\t{GetFileName(full_path)}");
        WriteLine($"Dir:\t{GetDirectoryName(full_path)}");
        WriteLine($"Size:\t{new FileInfo(full_path).Length:N0} bytes");
        WriteLine("/-------------------------------");
        WriteLine($"{File.ReadAllText(full_path)}");
        WriteLine("-------------------------------/");
    }

    private static string GenerateFullFilePath(string file_name)
    {
        return Combine(GetCurrentDirectory(), file_name);
    }
    private static void DoJsonSeralzsation(List<Person> people, string file_name = "serial.json") 
    {
        string full_path = GenerateFullFilePath(file_name);
        Newtonsoft.Json.JsonSerializer jss = new();
        using (StreamWriter stream_writer = File.CreateText(full_path))
        {
            jss.Serialize(stream_writer, people);
        }
    }
    
    private static void TPJsonSerialisater(List<Person> ppl, string file_name)
    {
        Newtonsoft.Json.JsonSerializer jss = new();
        using StreamWriter sw = File.CreateText(Combine(GetCurrentDirectory(), file_name));
        jss.Serialize(sw,ppl);
    }

}