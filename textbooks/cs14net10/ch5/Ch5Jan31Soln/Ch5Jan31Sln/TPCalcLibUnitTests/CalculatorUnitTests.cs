using TPNS.CalculatorLib;
namespace TPNS.CalculatorLibUnitTests;
public class CalculatorUnitTests
{
    [Fact]
    public void TestAdd2and2()
    {
        // [1] arrange
        double a=2;    
        double b=2;
        double expected=4;

        // [2] act
        Calculator calc = new();
        double result = calc.Add(a,b);

        // [3] assert
        Assert.Equal(expected: expected, actual: result);
    }
    [Fact]
    public void TestAdd2and3()
    {
        // [1] arrange
        double a = 2;
        double b = 3;
        double expected = 5;

        // [2] act
        Calculator calc = new();
        double result = calc.Add(a, b);

        // [3] assert
        Assert.Equal(expected: expected, actual: result);
    }
    [Theory]
    [InlineData(2,2,4)]   
    [InlineData(2,3,5)]   
    [InlineData(64,5,69)]
    [InlineData(419,1,420)]
    public void TestAdding(double a, double b, double expected)
    {
        //arrange
        Calculator calc = new();

        //act
        double result = calc.Add(a, b);

        //assert
        Assert.Equal(expected, result);
    }
}
