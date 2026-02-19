using System.IO.Compression;
using System.Xml;
using TPNS.SharedLibrary;

Console.WriteLine("\n ------ Welcome to XML CS App! ------ \n");
// [GOALS] Creates 3 files (same data): [file_path] determines [algorithm]
// - viper.xml      [xml]
// - viper.xml.gz   [gzip]
// - viper.xml.br   [brotlin]

// [1] create xml path (DATA LAYER)
string xml_file_path = Combine(GetCurrentDirectory(), "viper.xml");
string xmlgz_file_path = Combine(GetCurrentDirectory(), "viper.xml.gz");
string xmlbr_file_path = Combine(GetCurrentDirectory(), "viper.xml.br");

string[] file_paths = [xml_file_path, xmlgz_file_path, xmlbr_file_path];
//string current_file_path = file_paths[0];


Stream current_stream;
foreach (var file_path in file_paths)
{
    using (current_stream = GetStream(file_path))
    RunXmlWriter(current_stream);
    GetFileInfo(file_path);
}

static Stream GetStream(string file_path)
{
    FileStream fs = File.Create(file_path);
    switch (GetExtension(file_path))
    {
        case ".gz":
            WriteLine(" ----- Running [.gz] compresion ----- ");
            return new GZipStream(fs, CompressionMode.Compress,false);
        case ".br":
            WriteLine(" ----- Running [.br] compresion ----- ");
            return new BrotliStream(fs, CompressionMode.Compress, false);
        default:
            WriteLine(" ----- Running [.xml] compression ----- ");
            return fs;
    }
}

static void RunXmlWriter(Stream current_stream)
{
    using (XmlWriter xml_writer = XmlWriter.Create(
        current_stream,
        new XmlWriterSettings { Indent = true }))
    {
        try
        {
            // start element??
            xml_writer.WriteStartDocument();
            xml_writer.WriteStartElement("call_signs");

            foreach (var call_sign in Viper.CallSigns)
            {
                xml_writer.WriteElementString("call_sign", call_sign);
            }
            xml_writer.WriteEndElement();
            xml_writer.WriteEndDocument();
        }
        catch (IOException ex)
        {
            WriteLine($"IO ERROR CAUGHT: {ex}");
        }
        catch (Exception ex)
        {
            WriteLine($"ERROR CAUGHT: {ex}");
        }
    }
}

Console.WriteLine("\n ------ Program Ended! ------ \n");

