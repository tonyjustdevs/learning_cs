using System.Xml;
using TPNS.SharedLibrary;

Console.WriteLine("\n ------ Welcome to XML CS App! ------ \n");

// [1] create xml path (DATA LAYER)
string xml_path = Combine(GetCurrentDirectory(), "viper.xml");

// [2] create stream (TRANSPORT LAYER)
#region [2] FileStream
using (FileStream xml_fstream = File.Create(xml_path))
{
    using (XmlWriter xml_writer = XmlWriter.Create(xml_fstream,
        new XmlWriterSettings { Indent=true}))
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
#endregion

GetFileInfo(xml_path);

Console.WriteLine("\n ------ Program Ended! ------ \n");


// [3] ??

