using System.IO.Compression;
using System.Xml;
using TPNS.SharedLibrary;

Console.WriteLine("\n ------ Welcome to XML CS App (DECOMPRESSION)! ------ \n");

#region [GOALS] Decompress 3 xml-files : [file_path] determines [algorithm]
// - viper.xml      [xml]
// - viper.xml.gz   [gzip]
// - viper.xml.br   [brotlin]
#endregion

string xml_file_path = Combine(GetCurrentDirectory(), "viper.xml");
string xmlgz_file_path = Combine(GetCurrentDirectory(), "viper.xml.gz");
string xmlbr_file_path = Combine(GetCurrentDirectory(), "viper.xml.br");
string[] file_paths = [xml_file_path, xmlgz_file_path, xmlbr_file_path];

//Stream current_stream;

//foreach (var file_path in file_paths)
//{
//    //using (current_stream = OpenStream(file_path)) // [[[[[[[[MUST IMPLEMENT]]]]]]]]]
//    //    RunXmlReader(current_stream); // [[[[[[[[ MUST IMPLEMENT ]]]]]]]]]
//    //GetFileInfo(file_path); 
//}

//using (var current_stream = File.Open(xml_file_path, FileMode.Open))
//{

//    //var xml_reader = new XmlReader.
//    using (var xml_reader = XmlReader.Create(current_stream))
//    while (xml_reader.Read())
//    {
//        WriteLine(xml_reader.NodeType);

//    }
//}
if (new FileInfo(xml_file_path).Length == 0)
{
    WriteLine(xml_file_path);
    Console.WriteLine("File is empty, skipping.");
    return;
}

using var xml_reader = XmlReader.Create(xml_file_path);

while (xml_reader.Read())
{
    WriteLine(xml_reader.NodeType);
}

//using (current_stream = OpenStream(xml_file_path))


//StreamReader stream_reader = new(xml_file_path);


//using (XmlReader xml_reader = XmlReader.Create(current_stream))
//{
//    WriteLine($"attempting to read every node of {GetFileName(xml_file_path)}");
//    int i = 0;
//    while (xml_reader.Read()) // read node by node...
//    {
//        WriteLine("{0}: {1}", i, xml_reader.NodeType);
//        i++;
//    }
//}

//static void RunXmlReader(Stream current_stream)
//{ // create xml reader 
//    XmlReader()
//}


//    static Stream OpenStream(string file_path)
//{
//       FileStream fs = File.Create(file_path);
//    switch (GetExtension(file_path))
//    {
//        case ".gz":
//            WriteLine(" ----- Running [.gz] compresion ----- ");
//            return new GZipStream(fs, CompressionMode.Decompress, false);
//        case ".br":
//            WriteLine(" ----- Running [.br] compresion ----- ");
//            return new BrotliStream(fs, CompressionMode.Decompress, false);
//        default:
//            WriteLine(" ----- Running [.xml] compression ----- ");
//            return fs;
//    }

//}

Console.WriteLine("\n ------ Program Ended! ------ \n");



