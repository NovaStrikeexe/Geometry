using GeometryLib.Interfaces;

namespace GeometryLib.Implementation;

public class Circle(double radius) : IShape
{
    public double GetArea() 
        => Math.PI * radius * radius;
}