using Calculator;
using ShapesCalculator.Shapes;

Circle circle = new Circle(7);
Triangle triangle = new Triangle(7, 25, 24);
Calculator.Calculator calculator = new Calculator.Calculator();
Console.WriteLine(triangle.IsRightAngled());