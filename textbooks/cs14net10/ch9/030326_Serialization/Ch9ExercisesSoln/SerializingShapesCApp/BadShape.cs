
namespace SerializingShapesCApp;

public abstract class BadShape
{
    public double Width{ get; set; }
    public double Height{ get; set; }
    public string? Color{ get; set; }

    public abstract double Area { get; }
}

public class Rectangle : BadShape
{
    public override double Area => Width * Height;
}

public class Circle : BadShape
{
    public override double Area => (Width) * double.Pi;
}