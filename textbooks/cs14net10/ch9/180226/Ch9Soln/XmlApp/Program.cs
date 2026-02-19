#region Conceptual Layers
// 1. Data source layer: (File on disk)
// 2. Transport (FileStream, socket)
// 3. Middleware layer (logging, auth)
// 4. Transformation layer (GZipStream, CryptoStream)
// 4. Representation layer (StreamReader)
// 5. Application layer (Your application)
#endregion

using System.Xml;
using TPNS.SharedLibrary;
WriteLine("\n");
WriteLine(" ----------------------------------------- ");
WriteLine(" ----------- Program Started ------------- ");
WriteLine(" ----------------------------------------- ");
WriteLine("\n\n");

// 1. create file: (Data Source Layer)
string xml_file_path = Combine(GetCurrentDirectory(), "viper.xml");
string xmlgz_file_path = Combine(GetCurrentDirectory(), "viper.xml.gz");

// 2. create file stream (Transport Layer)
using (FileStream file_stream = File.Create(xml_file_path))
using (FileStream filegz_stream = File.Create(xmlgz_file_path))
using (var gz_stream = DoGZipCompressionOfFileStream(filegz_stream))
{
	try
	{
        using (XmlWriter xml_writer = XmlWriter.Create(file_stream,new XmlWriterSettings { Indent = true }))
        using (XmlWriter xmlgz_writer = XmlWriter.Create(gz_stream, new XmlWriterSettings { Indent = true }))
        {
            WriteXmlViperCallSigns(xml_writer);
            WriteXmlViperCallSigns(xmlgz_writer);
        }  

	}
    catch (UnauthorizedAccessException ex)
    {
        WriteLine($"persmission error: {ex}");
    }
    catch (IOException ex)
	{
		WriteLine($"io error: {ex}");
	}
    catch (Exception ex)
    {
        WriteLine($"error: {ex}");
    }
}

OutputFileInfo(xml_file_path);
OutputFileInfo(xmlgz_file_path);

WriteLine("\n\n");
WriteLine(" ----------------------------------------- ");
WriteLine(" ----------- Program Completed ----------- ");
WriteLine(" ----------------------------------------- ");
WriteLine("\n");
        


