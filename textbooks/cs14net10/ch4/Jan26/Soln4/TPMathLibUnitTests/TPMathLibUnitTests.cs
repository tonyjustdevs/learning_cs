using TPMathLib;

public class TPMathLibUnitTests
{
    [Fact]
    public void TestAdding2And2()
    {   // [1] ARRANGE
        double a=2; 
        double b=2;
        double expected=4;

        // [2] ACT
        TPMathLibCalc calcuator = new TPMathLibCalc();
        double actual = calcuator.Add(a, b);  

        // [3] ASSERT
        Assert.Equal(expected, actual);  
    }
    [Fact]
    public void TestAdding2And3()
    {   // [1] ARRANGE
        double a = 2;
        double b = 3;
        double expected = 5;

        // [2] ACT
        TPMathLibCalc calcuator = new TPMathLibCalc();
        double actual = calcuator.Add(a, b);

        // [3] ASSERT
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1,0,1)]
    [InlineData(1,1,2)]
    [InlineData(1,2,3)]
    public void TestAdding(double a, double b, double expected)
    {
        TPMathLibCalc calculator = new();
        double actual = calculator.Add(a, b);
        Assert.Equal(expected, actual);
    }
}
