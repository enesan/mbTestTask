using ShapeMindBox;

namespace ShapeTests;

[TestClass]
public class CircleTests
{
    [TestMethod]
    public void CalculateSquareCircle_GivenPositiveRadius_ShouldReturnRightSquare()
    {
        // arrange 
        double radius = 3.4;
        double expectedSquare = Double.Pi * radius * radius;
        
        // act
        IShape circle = new Circle(radius);
        double square = circle.CalculateSquare();
        
        // assert
        Assert.AreEqual(expectedSquare, square);
    }
    
    [TestMethod]
    public void CalculateSquareCircle_GivenNegativeRadius_ShouldThrowArgumentException()
    {
        double radius = -2.5;

        Assert.ThrowsException<ArgumentException>(() => new Circle(radius));
    }
}