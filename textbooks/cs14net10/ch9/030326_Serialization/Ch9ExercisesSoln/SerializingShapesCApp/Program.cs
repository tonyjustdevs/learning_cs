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


XmlSerializer serializerXml = new(listOfShapes.GetType());
using (FileStream xml_create_filestream = File.Open(xml_file_path, FileMode.Create))
{   
    serializerXml.Serialize(xml_create_filestream, listOfShapes);
}
List<BetterShape>? loadedShapesXml = null;
using (FileStream xml_open_filestream = File.Open(xml_file_path, FileMode.Open))
{
    loadedShapesXml =
    serializerXml.Deserialize(xml_open_filestream) as List<BetterShape>;

    if (loadedShapesXml is not null)
    {
        foreach (BetterShape item in loadedShapesXml)
        {
            WriteLine("{0} is {1} and has an area of {2:N2}",
                item.GetType().Name, item.Color, item.Area);
        }

    }
}



// DESERIALIZE

//Shapes read-only property:Area
//deserialize:
//- output list of shapes,
//- including their areas

//Loading shapes from XML:
//Circle is Red and has an area of 19.63
//Rectangle is Blue and has an area of 200.00
//Circle is Green and has an area of 201.06
//Circle is Purple and has an area of 475.29
//Rectangle is Blue and has an area of 810.00