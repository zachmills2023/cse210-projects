using System;

public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Return the area of the circle.
    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius,2);
    }
}