namespace ShapeMindBox;

public class Triangle : IShape, IValidatable
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
        
        ValidateSides();
    }

    public double CalculateSquare()
    {
        double s = (_sideA + _sideB + _sideC) / 2;
        
        return Math.Sqrt(s * (s - _sideA) * (s-_sideB) * (s-_sideC));
    }

    public bool CheckIfOrthogonal()
    {
        double[] sortedSides = GetSortedSides();

        double shortSidesSquareSum = Math.Pow(sortedSides[0], 2) + Math.Pow(sortedSides[1], 2) ;
        double longSideSquare = sortedSides[2] * sortedSides[2];

        return (Math.Sqrt(shortSidesSquareSum) - longSideSquare) < 1e-10;
    }
    
    public void ValidateSides()
    {
        double[] sortedSides = GetSortedSides();
        
        if(sortedSides[2] >= sortedSides[0] + sortedSides[1])
            throw new ArgumentException("Sum of two sides are equal or less than a third");
            
        if (_sideA <= 0 || _sideB <= 0 || _sideC <= 0)
            throw new ArgumentException("There is side(s) that is 0 or less");
    }
    
    private double[] GetSortedSides()
    {
        double[] sides = {_sideA, _sideB, _sideC};
        Array.Sort(sides);

        return sides;
    }
}