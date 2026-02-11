namespace TPNS.TPSharedModernLib;
public abstract class Shape
{ //2. Create a class named Shape: properties named Height, Width, and Area.
    protected double Height { get; set; }
    protected double Width { get; set; }
    protected virtual double Area { get; }
}


// 3. Rectangle, Square, and Circle
// - any additional members: override Area property if appropriate.

public class Rectangle : Shape
{
    //Rectangle r = new(height: 3, width: 4.5);
    public Rectangle() { }

    public Rectangle(double height, double width)
    {
        Height  = height;
        Width   = width;
    }
    protected override double Area => Height * Width;
}

public class Square : Rectangle
{// Square s = new(5);
    public Square() { }

    public Square(double height) : base(height, height) { }

}

public class Circle : Shape
{
    public double Radius { get; }
    public Circle() { }
    public Circle(double radius)
    {
        Radius = radius;
    }

    public new double Area => Math.PI * (Radius * Radius);

}