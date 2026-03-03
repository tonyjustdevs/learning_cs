//using SerializingShapesCApp;
using SerializingShapesCApp;
using System.Xml.Serialization;
Console.WriteLine("Xin Chao Shape Serializer!");

List<BetterShape> listOfShapes = new()
{
    new Circle { Color = "Red", Radius = 2.5 },
    new Rectangle { Color = "Blue", Height = 20.0, Width = 10.0 },
    new Circle { Color = "Green", Radius = 8.0 },
    new Circle { Color = "Purple", Radius = 12.3 },
    new Rectangle { Color = "Blue", Height = 45.0, Width = 18.0 }
};

var xml_file_path = Combine(GetCurrentDirectory(), "shapes.xml");


using (FileStream xml_filestream = File.Open(xml_file_path, FileMode.Create))
{
    XmlSerializer serializerXml = new(listOfShapes.GetType());
    serializerXml.Serialize(xml_filestream, listOfShapes);
}


//Loading shapes from XML:
//Circle is Red and has an area of 19.63
//Rectangle is Blue and has an area of 200.00
//Circle is Green and has an area of 201.06
//Circle is Purple and has an area of 475.29
//Rectangle is Blue and has an area of 810.00