using CalculatorLib;

namespace CalculatorLibUnitTests;
public class CalculatorUnitTests
{
    [Fact]
    public void TestAdding2And2()
    {
        // 1. arrange
        double a = 2;
        double b = 2;
        double expected = 4;
        
        // 2. act
        Calculator calc_instance = new();
        double actual = calc_instance.Add(a, b);
        
        // 3. assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void TestAdding2And3()
    {
        // 1. arrange
        double a = 2;
        double b = 3;
        double expected = 5;

        // 2. act
        Calculator calc_instance = new();
        double actual = calc_instance.Add(a, b);

        // 3. assert
        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(1,2,3)]
    [InlineData(3,4,12)]
    public void TestAddingGeneral(double a, double b, double expected)
    {
        Calculator calc = new();
        double actual = calc.Add(a, b);
        Assert.Equal(expected, actual);
    }
}
