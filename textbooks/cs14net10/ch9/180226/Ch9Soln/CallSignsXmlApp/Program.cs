        using System.Xml;
        using TPNS.SharedLibrary;

        Console.WriteLine("Welcome To ViperCallSigns App!");

        // create directory
        string curr_dir = CurrentDirectory;

        // create xml file path
        string xml_path = Combine(curr_dir, "viper.xml");

        // create filestream
        using (FileStream xml_fstream = File.Create(xml_path)) { 
            using (XmlWriter xml_writer = XmlWriter.Create(xml_fstream, new XmlWriterSettings { Indent = true })){ 
                xml_writer.WriteStartDocument();
                xml_writer.WriteStartElement("call_signs");
            
                foreach (string call_sign in Viper.CallSigns)
                {
                    xml_writer.WriteElementString("call_sign", call_sign);
                }
                xml_writer.WriteEndElement();
                xml_writer.WriteEndDocument();
            }
        }
// UnauthorizedAccessException
// IOException ex
// Exception ex
static void output_file_info(string file_path)
{
    WriteLine($"Name: {GetFileName(file_path)}");
    WriteLine($"Directory: {GetDirectoryName(file_path)}");
    WriteLine($"Size (bytes): {new FileInfo(file_path).Length:N0}");
    WriteLine("/------------------");
    WriteLine(File.ReadAllText(file_path));
    WriteLine("------------------");
    WriteLine(BitConverter.ToString(File.ReadAllBytes(file_path)));
    WriteLine("------------------");    
    foreach (var line in File.ReadAllLines(file_path))
    {
        WriteLine(line);
    };
    //File.open
    WriteLine("------------------/");
}

        output_file_info(xml_path);

        WriteLine("...Program Ended...");