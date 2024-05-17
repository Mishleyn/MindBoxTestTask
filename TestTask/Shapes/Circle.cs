namespace ShapesCalculator.Shapes;

public class Circle : Shape
{
    private double _radius;

    public double Radius
    {
        get => _radius;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Circle radius cannot be negative");
            }
            _radius = value;
        }
    }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.Round(Math.PI * Math.Pow(_radius, 2), 1);
    }
}
