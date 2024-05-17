using ShapesCalculator.Shapes;

namespace ShapesCalculatorTests;

public class TriangleTests
{
    [Test]
    public void CreateCorrectTriangle_ShouldNotErrors()
    {
        double a = 5;
        double b = 6;
        double c = 7;

        Assert.DoesNotThrow(() => { Triangle triangle = new Triangle(a, b, c); });
    }

    [Test]
    public void CreateIncorrectTriangle_ShouldErrors()
    {
        double a = -1;
        double b = -2;
        double c = -3;

        Assert.Throws<ArgumentException>(() => { Triangle triangle = new Triangle(a, b, c); });
    }        

    [Test]
    public void CalculateTriangleArea_ShouldRightAnswer()
    {
        double a = 7;
        double b = 24;
        double c = 25;
        double expected = 84;

        Triangle triangle = new Triangle(a, b, c);
        Assert.That(expected, Is.EqualTo(triangle.CalculateArea()));
    }

    [Test]
    public void TriangleIsRightAngled_ShouldTrue()
    {
        double a = 7;
        double b = 24;
        double c = 25;
        bool expected = true;

        Triangle triangle = new Triangle(a, b, c);
        Assert.That(expected, Is.EqualTo(triangle.IsRightAngled()));
    }

    [Test]
    public void TriangleIsNotRightAngled_ShouldFalse()
    {
        double a = 1;
        double b = 2;
        double c = 3;
        bool expected = false;

        Triangle triangle = new Triangle(a, b, c);
        Assert.That(expected, Is.EqualTo(triangle.IsRightAngled()));
    }
}
