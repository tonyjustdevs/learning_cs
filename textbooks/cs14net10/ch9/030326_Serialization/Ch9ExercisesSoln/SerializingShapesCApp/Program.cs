using SerializingShapesCApp;
Console.WriteLine("Hello Serializer");

// Create a list of Shapes to serialize.
List<Shape> listOfShapes = new()
{
    new Circle { Color = "Red", Radius = 2.5 },
    new Rectangle { Color = "Blue", Height = 20.0, Width = 10.0 },
    new Circle { Color = "Green", Radius = 8.0 },
    new Circle { Color = "Purple", Radius = 12.3 },
    new Rectangle { Color = "Blue", Height = 45.0, Width = 18.0 }
};

//List<Shape> loadedShapesXml =
//    serializerXml.Deserialize(fileXml) as List<Shape>;

//foreach (Shape item in loadedShapesXml)
//{
//    WriteLine("{0} is {1} and has an area of {2:N2}",
//        item.GetType().Name, item.Color, item.Area);
//}


//Loading shapes from XML:
//Circle is Red and has an area of 19.63
//Rectangle is Blue and has an area of 200.00
//Circle is Green and has an area of 201.06
//Circle is Purple and has an area of 475.29
//Rectangle is Blue and has an area of 810.00