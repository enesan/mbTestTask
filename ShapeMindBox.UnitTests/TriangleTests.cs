using ShapeMindBox;

namespace ShapeTests;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void CalculateSquareTriangle_Given3_3_5_ShouldReturn6()
    {
        // arrange
        double a = 3;
        double b = 4;
        double c = 5;
        double expectedSquare = 6; 

        // act
        IShape triangle = new Triangle(a,b,c);
        double square = triangle.CalculateSquare();

        // assert
        Assert.AreEqual(expectedSquare, square);
    }
    
    [TestMethod]
    public void CalculateSquareTriangle_SumOfTwoSidesLessThanThird_ThrowsArgumentException()
    {
        double a = 2;
        double b = 2;
        double c = 5;

        Assert.ThrowsException<ArgumentException>(() => new Triangle(a,b,c));
    }
    
    [TestMethod]
    public void CalculateSquareTriangle_GivenNegativeSide_ThrowsArgumentException()
    {
        double a = -1;
        double b = 3;
        double c = 5;

        Assert.ThrowsException<ArgumentException>(() =>  new Triangle(a,b,c));
    }
    
    [TestMethod]
    public void IsTriangleOrthogonal_EgyptianTriangle_ShouldReturnTrue()
    {
        double a = 3;
        double b = 4;
        double c = 5;
        
        IShape triangle = new Triangle(a,b,c);
        bool isOrtho = ((Triangle)triangle).CheckIfOrthogonal();
        
        Assert.IsTrue(isOrtho);
    }
}