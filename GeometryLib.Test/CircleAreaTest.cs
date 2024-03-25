using GeometryLib.Implementation;

namespace GeometryLib.Test;

public class CircleAreaTest
{
    [Fact]
    public void Test()
    {
        const double radius = 5;
        const double expectedArea = Math.PI * radius * radius;
        
        var circle = new Circle(radius);

        var actualArea = circle.GetArea();

        Assert.Equal(expectedArea, actualArea);
    }
}