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

Stream current_stream;

foreach (var file_path in file_paths)
{
    using (current_stream = GetStream(file_path)) // [[[[[[[[MUST IMPLEMENT]]]]]]]]]
        RunXmlReader(current_stream); // [[[[[[[[ MUST IMPLEMENT ]]]]]]]]]
    GetFileInfo(file_path); 
}

Console.WriteLine("\n ------ Program Ended! ------ \n");

