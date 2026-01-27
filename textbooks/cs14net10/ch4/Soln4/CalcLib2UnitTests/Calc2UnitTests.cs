using TPCalcLibraries;

namespace CalcLib2UnitTests;

public class Calc2UnitTests
{
    [Fact]
    public void Test1Add2And2()
    {
        double a = 2;
        double b = 2;
        double expected = 2;
        CalcLib2 calc2 = new();
        double result = calc2.Add(a, b);
        Assert.Equal(expected, result);
    }
}
