﻿using System.Linq;

namespace TestTask
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

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
            return Math.PI * Math.Pow(_radius, 2);
        }
    }

    public class Triangle : Shape
    {
        private double _a;

        private double _b;

        private double _c;

        public double A
        {
            get => _a;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Sides of a triangle cannot be negative");
                }

                _a = value;
            }
        }

        public double B
        {
            get => _b;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Sides of a triangle cannot be negative");
                }

                _b = value;
            }
        }

        public double C
        {
            get => _c;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Sides of a triangle cannot be negative");
                }

                _c = value;
            }
        }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;            
        }

        public override double CalculateArea()
        {
            double semiPerimeter = (A + B + C) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C));
        }

        public bool IsRightAngled()
        {
            double[] sides = { A, B, C };
            Array.Sort(sides);

            if (Math.Pow(sides[2], 2) == (Math.Pow(sides[1], 2) + Math.Pow(sides[0], 2)))
            {
                return true;
            }

            return false;
        }
    }

    public class Calculator
    {
        public double CalculateArea(Shape shape)
        {
            return shape.CalculateArea();
        }
    }
}
