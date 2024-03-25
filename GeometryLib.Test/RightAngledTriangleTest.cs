using GeometryLib.Implementation;

namespace GeometryLib.Test;

public class RightAngledTriangleTest
{
    [Fact]
    public void Test()
    {
        const double sideA = 3;
        const double sideB = 4;
        const double sideC = 5;
        
        var triangle = new Triangle(sideA, sideB, sideC);

        var isRightAngled = triangle.IsRightAngled();

        Assert.True(isRightAngled);
    }
}