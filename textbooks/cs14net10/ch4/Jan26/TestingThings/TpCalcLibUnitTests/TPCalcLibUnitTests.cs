using TPCalcLib;
namespace TPCalcLibUnitTests;

public class TPCalcUnitTests
{
    [Fact]
    public void TestAdding2And2()
    {
        // [1] Arrange
        double a = 2;
        double b = 2;
        double expected = 4;

        // [2] Act
        TPCalc calculator = new();
        double actual = calculator.Add(a, b);

        // [3] Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void TestAdding2And3()
    {
        // [1] Arrange
        double a = 2;
        double b = 3;
        double expected = 5;

        // [2] Act
        TPCalc calculator = new();
        double actual = calculator.Add(a, b);

        // [3] Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1,1,2)]
    [InlineData(1,2,3)]
    [InlineData(12,12,24)]
    public void TestingAdd(double a, double b, double expected)
    {
        TPCalc calculator = new();
        double actual = calculator.Add(a, b);
        Assert.Equal(expected, actual);
    }
    


}
