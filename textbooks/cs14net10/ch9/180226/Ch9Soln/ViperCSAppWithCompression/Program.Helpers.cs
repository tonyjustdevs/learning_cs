using System.IO.Compression;
using System.Xml;
using TPNS.SharedLibrary;

partial class Program
{
    private static void GetFileInfo(string file_path)
    {
        WriteLine("[running from XmlViperVSApp Program.Helpers]");
        WriteLine($"File: \t\t{GetFileName(file_path)}");
        WriteLine($"Directory: \t{GetDirectoryName(file_path)}");
        WriteLine($"Size: \t\t{new FileInfo(file_path).Length:N0}");
        WriteLine($"/ -------------------------------- ");
        WriteLine($"{File.ReadAllText(file_path)}");
        WriteLine($"  -------------------------------- / ");

    }

    private static void RunXmlWriter(Stream current_stream)
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

    private static Stream GetStream(string file_path)
    {
        FileStream fs = File.Create(file_path);
        switch (GetExtension(file_path))
        {
            case ".gz":
                WriteLine(" ----- Running [.gz] compresion ----- ");
                return new GZipStream(fs, CompressionMode.Compress, false);
            case ".br":
                WriteLine(" ----- Running [.br] compresion ----- ");
                return new BrotliStream(fs, CompressionMode.Compress, false);
            default:
                WriteLine(" ----- Running [.xml] compression ----- ");
                return fs;
        }

    }



}

