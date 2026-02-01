using System.Diagnostics.CodeAnalysis;
using TPNS.CalculatorLib;
namespace TPNS.CalculatorLibUnitTests;


public class Calculator2UnitTests
{
    [Fact]
    public void TestAdd2And2()
    {
        // [1] arrange        
        double a = 2;
        double b = 2;
        double expected = 4;

        // [2] act        
        Calculator2 calc2 = new();
        double actual = calc2.Add(a, b);

        // [3] assert        
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestAdd2And3()
    {
        // [1] arrange        
        double a = 2;
        double b = 3;
        double expected = 5;

        // [2] act        
        Calculator2 calc2 = new();
        double actual = calc2.Add(a, b);

        // [3] assert        
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(2,2,4)]
    [InlineData(2,3,5)]
    [InlineData(64,5,69)]
    [InlineData(418,2,420)]
    public void TestAdding(double a, double b, double expected) // arrange
    {
        Calculator2 calc2 = new();                              // act
        double actual = calc2.Add(a, b);
        Assert.Equal(expected,actual);
    }
}

