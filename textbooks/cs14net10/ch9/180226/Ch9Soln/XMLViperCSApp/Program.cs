using System.IO.Compression;
using System.Xml;
using TPNS.SharedLibrary;

Console.WriteLine("\n ------ Welcome to XML CS App! ------ \n");

// [1] create xml path (DATA LAYER)
string input_file_path = Combine(GetCurrentDirectory(), "viper.xml");
string input_file_path2 = Combine(GetCurrentDirectory(), "viper.txt");


// choose (algo == gzip)    -------> gzip___stream -> xml_writer(stream) -> .xml
// choose else              -------> brotli_stream -> xml_writer(stream) -> .xml
// [2] create stream (TRANSPORT LAYER)
// [3] add Compression: GZ

#region [2] FileStream


//FileStream xml_fstream = File.Create(xml_path)
using (FileStream xml_fstream = File.Create(input_file_path))
using (XmlWriter xml_writer = XmlWriter.Create(xml_fstream,
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
            //WriteLine(call_sign);
        }
        xml_writer.WriteEndElement();
        xml_writer.WriteEndDocument();
        // write each call sign into element
        //xml_writer.Close();
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

#endregion

GetFileInfo(input_file_path);

Console.WriteLine("\n ------ Program Ended! ------ \n");


// [3] ??

