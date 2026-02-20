using System.Data;
using System.IO.Compression;
using System.Xml;
using TPNS.SharedLibrary;

Console.WriteLine("\nHello to ViperCallSignsApp\n");

string xml_path = Combine(GetCurrentDirectory(), "viper.xml");
string xml_gz_path = Combine(GetCurrentDirectory(), "viper.xml.gz");
string xml_br_path = Combine(GetCurrentDirectory(), "viper.br");
string xml_zip_path = Combine(GetCurrentDirectory(), "viper.xml.zip");

string[] file_paths = [xml_path, xml_gz_path, xml_br_path, xml_zip_path];
//string[] file_paths = [xml_path];

foreach (var file_path in file_paths)
{
    FileStream fs = File.Create(file_path);     // create file_stream
    Stream compressed_stream;
    switch (GetExtension(file_path))            // apply switch to choose compression
    {
        case ".gz":
            WriteLine("do Gzip() compression");
            compressed_stream = new GZipStream(fs, CompressionMode.Compress);
            break;
        case ".br":
            WriteLine("do Brotli() compression");
            compressed_stream = new BrotliStream(fs, CompressionMode.Compress);
            break;
        default:
            compressed_stream = fs;
            WriteLine("do no compression");
            break;
    }

    using (compressed_stream)
    using (XmlWriter xml_writer = XmlWriter.Create(compressed_stream, new XmlWriterSettings { Indent = true }))
    {
        DoXmlElements(xml_writer);
    }

    OutputFileInfo(file_path);
}


Console.WriteLine("\nProgram Ended\n");
