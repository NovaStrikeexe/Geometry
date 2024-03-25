using GeometryLib.Implementation;

namespace GeometryLib.Test;

public class TriangleAreaTest
{
    [Fact]
    public void Test()
    {
        const double sideA = 3;
        const double sideB = 4;
        const double sideC = 5;
        const double expectedArea = 6;
        
        var triangle = new Triangle(sideA, sideB, sideC);

        var actualArea = triangle.GetArea();

        Assert.Equal(expectedArea, actualArea);
    }
}