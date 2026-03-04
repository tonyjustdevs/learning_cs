//namespace TPSharedLib;

using System;
using System.Diagnostics.Tracing;
using System.Xml;
using TPNS.SharedLibrary;

WriteLine("Hello Viper App!");

string viper_xml_file_path = Combine(GetCurrentDirectory(), "viper.xml");

using (FileStream xml_filestream = File.Create(viper_xml_file_path)){ 
    using (XmlWriter xml_writer = XmlWriter.Create(xml_filestream,
        new XmlWriterSettings() { Indent = true }))
    {
        xml_writer.WriteStartDocument();
        xml_writer.WriteStartElement("VIPER");

        foreach (string viper_call_sign in Viper.CallSigns)
        {   
            xml_writer.WriteElementString("viper_call_sign", viper_call_sign);
        }
        xml_writer.WriteEndElement();
        xml_writer.WriteEndDocument();
    }
}

try
{
    GetFileInfo(viper_xml_file_path);
}
catch (Exception e) 
{
    WriteLine($"error opening file: {e}");
}


