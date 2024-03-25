using GeometryLib.Implementation;

namespace GeometryLib.Test;

public class ShapeTests
{
    [Fact]
    public void CircleAreaTest()
    {
        const double radius = 5;
        const double expectedArea = Math.PI * radius * radius;
        
        var circle = new Circle(radius);

        var actualArea = circle.GetArea();

        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void TriangleAreaTest()
    {
        const double sideA = 3;
        const double sideB = 4;
        const double sideC = 5;
        const double expectedArea = 6;
        
        var triangle = new Triangle(sideA, sideB, sideC);

        var actualArea = triangle.GetArea();

        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void RightAngledTriangleTest()
    {
        const double sideA = 3;
        const double sideB = 4;
        const double sideC = 5;
        
        var triangle = new Triangle(sideA, sideB, sideC);

        var isRightAngled = triangle.IsRightAngled();

        Assert.True(isRightAngled);
    }
    
    [Fact]
    public void ShapeCalculatorTriangleTest()
    {
        const double sideA = 3;
        const double sideB = 4;
        const double sideC = 5;
        const double expectedArea = 6;
        
        var triangle = new Triangle(sideA, sideB, sideC);

        var actualArea = ShapeCalculator.CalculateArea(triangle);

        Assert.Equal(expectedArea, actualArea);
    }
}