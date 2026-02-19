

using System.Security.AccessControl;
using System.Xml;
using TPNS.SharedLibrary;

partial class Program
{

    private static void OutputFileInfo(string file_path)
    {
        
        WriteLine($"\n Outputting File Information:");
        WriteLine($" - File: \t{GetFileName(file_path)}");
        WriteLine($" - Directory: \t{GetDirectoryName(file_path)}");
        WriteLine($" - Size: \t{new FileInfo(file_path).Length:N0} (Bytes)");
        WriteLine($" - Created: \t{new FileInfo(file_path).CreationTime:yyyy-MM-dd:HH:mm:ss.fff}");
        WriteLine($" - Modified: \t{new FileInfo(file_path).LastAccessTime:yyyy-MM-dd:HH:mm:ss.fff}\n");

        WriteLine(File.ReadAllText(file_path));

        if (GetExtension(file_path)==".gz")
        {
            using (var decompressed_fs = DoGZipDeCompressionofFS(File.Create(file_path)))
            //decompressed_fs.Read()
            //decompressed_fs
            //WriteLine(decompressed_fs);
            //XmlReader xml_reader.crea)
            using (var xml_reader = XmlReader.Create(decompressed_fs)) { 
                WriteLine("start reading .gz --------------- ");
                WriteLine(xml_reader.ReadContentAsString());
                WriteLine("--------------- endreading .gz");
            }
        }
    }

    private static void WriteXmlViperCallSigns(XmlWriter xml_writer) 
    {
        xml_writer.WriteStartDocument();
        xml_writer.WriteStartElement("call_signs");

        foreach (var call_sign in Viper.CallSigns)
        {
            xml_writer.WriteElementString("call_sign", call_sign);
        }
        xml_writer.WriteEndElement();
        xml_writer.WriteEndDocument();
    }

}

