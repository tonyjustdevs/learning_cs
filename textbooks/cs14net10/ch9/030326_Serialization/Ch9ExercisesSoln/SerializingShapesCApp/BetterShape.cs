
using System.Xml.Serialization;

namespace SerializingShapesCApp;


[XmlInclude(typeof(Circle))]
[XmlInclude(typeof(Rectangle))]
public abstract class BetterShape
{
    public string? Color { get; set; }
    public abstract double Area { get; }
}

public class Rectangle : BetterShape
{
    public double Height { get; set; }
    public double Width {get;set;}
    public override double Area => Height * Width;
}

public class Circle : BetterShape
{
    public double Radius { get; set; }
    public override double Area => double.Pi*Radius*Radius;
}
