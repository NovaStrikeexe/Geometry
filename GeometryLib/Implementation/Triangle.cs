using GeometryLib.Interfaces;

namespace GeometryLib.Implementation;

public class Triangle(double sideA, double sideB, double sideC) : IShape
{
    public double GetArea()
    {
        var semiPerimeter = (sideA + sideB + sideC) / 2; //Heron's formula (a + b + c)/2 This is the reason why there is this "magic" int 2 
        
        return Math.Sqrt(semiPerimeter *
                         (semiPerimeter - sideA) *
                         (semiPerimeter - sideB) *
                         (semiPerimeter - sideC));

    }

    public bool IsRightAngled() 
        =>  Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(sideC, 2) ||
            Math.Pow(sideA, 2) + Math.Pow(sideC, 2) == Math.Pow(sideB, 2) ||
            Math.Pow(sideB, 2) + Math.Pow(sideC, 2) == Math.Pow(sideA, 2);
}