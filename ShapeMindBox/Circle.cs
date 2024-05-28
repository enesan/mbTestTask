namespace ShapeMindBox;

public class Circle : IShape, IValidatable
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
        ValidateSides();
    }

    public double CalculateSquare()
    {
        return Math.PI * _radius * _radius;
    }

    public void ValidateSides()
    {
        if (_radius <= 0)
            throw new ArgumentException("Radius is 0 or less");
    }
}