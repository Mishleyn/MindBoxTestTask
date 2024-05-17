using ShapesCalculator.Shapes;

namespace CircleTests;

public class CircleTests
{
    [Test]
    public void CreateCorrectCircle_ShouldNotErrors()
    {
        double radius = 5;
        Assert.DoesNotThrow(() => { Circle circle = new Circle(radius); });
    }

    [Test]
    public void CreateIncorrectCircle_ShouldErrors()
    {
        double radius = -1;
        Assert.Throws<ArgumentException>(() => { Circle circle = new Circle(radius);});
    }    

    [Test]
    public void CalculateCircleArea_ShouldRightAnswer()
    {
        double radius = 5;
        double expected = 78.5;

        Circle circle = new Circle(radius);
        Assert.That(expected, Is.EqualTo(circle.CalculateArea()));
    }        
}