
using System.Xml;
using TPNS.SharedLibrary;

partial class Program
{
    private static void DoXmlElements(XmlWriter xml_writer)
    {
        WriteLine("DoXmlElements() has run....");
        xml_writer.WriteStartDocument();
        xml_writer.WriteStartElement("call_signs");

        foreach (var call_sign in Viper.CallSigns)
        {
            xml_writer.WriteElementString("call_sign", call_sign);
        }
        xml_writer.WriteEndElement();
        xml_writer.WriteEndDocument();
    }
    private static void OutputFileInfo(string file_path)
    {
        // name, dir, size, contents
        WriteLine($"File: {GetFileName(file_path)}");
        WriteLine($"Directory: {GetDirectoryName(file_path)}");
        WriteLine($"Size: {new FileInfo(file_path).Length:N0}");
        WriteLine("/ ------------------------------------ ");
        WriteLine($"{File.ReadAllText(file_path)}");
        WriteLine(" ------------------------------------ /");
    }
}



// 1. add file_path:    data layer              [file_stream, network_stream, memory_stream]    [raw data]
// 2. add stream:       transport layer         [gzip_stream, deflate_stream] -> [input_stream bytes TO ouput_stream bytes] [decorator]
// 3. add compression:  transformation layer
// 3. add encryption:   transformation layer    [CryptoStream]
// 3. add encoding/dec: encode & decode layer   [xml_writer,stream_reader] -> bytes to text
// 4. add buffer:       buffering layer         
// 5. add structure:    parsing layer           [xml, json, csv, binary_parse]
// 6. add business:     domain & business layer

