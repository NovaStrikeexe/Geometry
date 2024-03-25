using GeometryLib.Interfaces;

namespace GeometryLib;

public static class ShapeCalculator
{
    public static double CalculateArea(IShape shape) 
        => shape.GetArea();
}