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
        string full_file_path = Combine(GetCurrentDirectory(), file_name);
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

    static void SerializeOnceAgain(List<Person> peeps)
    {
        XmlSerializer im_very_xml_serial = new(peeps.GetType());

        using (FileStream fs = File.Create(Combine(GetCurrentDirectory(), "serials_business.xml"))) 
        {
            im_very_xml_serial.Serialize(fs, peeps);
        }
    }
}