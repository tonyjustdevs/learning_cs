
using System;
using System.Text;

namespace TPNS.TPSharedModernLib;

public abstract class Shape2
{
    protected double Width { get; set; }
    protected double Height { get; set; }
    protected virtual double Area { get; }
}

public class Rectangle2 : Shape2
{
    public Rectangle2(){}
    public Rectangle2(double height, double width)
    {
        Width = width;
        Height = height;
    }

    protected override double Area => Height * Width;
}

public class Square2 : Rectangle2 
{
    public Square2(){}
    public Square2(double width) : base(width, width){} // takes only one input
}
public class Circle2 : Square2
{
    public Circle2() { }
    public Circle2(double radius) : base(radius) { } // takes only one input
    public override double Area => Math.PI * Height * Width;

}

//Rectangle r = new(height: 3, width: 4.5);
//WriteLine($"Rectangle H: {r.Height}, W: {r.Width}, Area: {r.Area}");
//    Square s = new(5);
//    WriteLine($"Square H: {s.Height}, W: {s.Width}, Area: {s.Area}");
//    Circle c = new(radius: 2.5);
//    WriteLine($"Circle H: {c.Height}, W: {c.Width}, Area: {c.Area}");

//Rectangle H: 3, W: 4.5, Area: 13.5
//Square H: 5, W: 5, Area: 25
//Circle H: 5, W: 5, Area: 19.6349540849362


