using System.IO.Compression;
using System.Xml;
//using TPNS.SharedLibrary;

Console.WriteLine("\n ------ Welcome to ViperXMLDecompApp! ------ \n");

#region [GOALS] Decomp 3 files 
// - viper.xml      [xml]
// - viper.xml.gz   [gzip]
// - viper.xml.br   [brotlin]
#endregion

string xml_file_path = Combine(GetCurrentDirectory(), "viper.xml");
//string xmlgz_file_path = Combine(GetCurrentDirectory(), "viper.xml.gz");
//string xmlbr_file_path = Combine(GetCurrentDirectory(), "viper.xml.br");
//string[] file_paths = [xml_file_path, xmlgz_file_path, xmlbr_file_path];

//foreach (var file_path in file_paths)
//{
//    using (current_stream = GetStream(file_path))
//        RunXmlWriter(current_stream);
//    GetFileInfo(file_path);
//}
using (var fstream =GetStreamBasedOnFileExt(xml_file_path))
using (var xml_reader = XmlReader.Create(fstream))
{
    int i = 0;
    while (xml_reader.Read())
    {
        if (xml_reader.NodeType == XmlNodeType.Element && xml_reader.Name=="call_sign")
        {
            xml_reader.Read();
            Console.WriteLine(xml_reader.Value);
        }
        i++;
    }
}


static Stream GetStreamBasedOnFileExt(string file_path = ".xml")
{
    // create xml stream
    WriteLine($"creating stream for: '{file_path}'");
    var fs = File.OpenRead(file_path);
    return fs;
}


Console.WriteLine("\n ------ Program Ended! ------ \n");

