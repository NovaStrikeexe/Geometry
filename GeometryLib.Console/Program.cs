using GeometryLib;
using GeometryLib.Implementation;


const double radius = 3.14d;

var circle = new Circle(radius);

var resultSquare = circle.GetArea();

Console.WriteLine($"Area of a circle = {resultSquare} with radius = {radius}");

const double a = 5.0d;
const double b = 5.0d;
const double c = 5.0d;

var triangle = new Triangle(a, b, c);
var triangleArea = triangle.GetArea();

Console.WriteLine($"Area of a triangle = {triangleArea} with sides: ab:{a}, bc:{b}, ac{c} ");
Console.WriteLine($"Is this a right triangle? {new Triangle(3,4,5).IsRightAngled()}");

Console.WriteLine($"Area of a circle at compile time = {ShapeCalculator.CalculateArea(new Circle(12.49d))}");
Console.WriteLine($"Area of a triangle with sides given at compile time {new Triangle(6.0d,5.0d,5.0d).GetArea()}");