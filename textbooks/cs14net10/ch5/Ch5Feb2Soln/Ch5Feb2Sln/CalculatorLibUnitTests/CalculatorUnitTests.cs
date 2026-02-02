using TPNS.CalculatorLib;    
namespace TPNS.CalculatorLibUnitTests
{
    public class CalculatorUnitTests
    {
        [Fact]
        public void TestAdd2And2()
        {
            // [1] Arrange
            double a = 2;
            double b = 2;
            double expected = 4;
            // [2] Act
            Calculator calc = new();
            double actual = calc.Add(a, b);
            // [3] Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestAdd2And3()
        {
            // [1] Arrange
            double a = 2;
            double b = 3;
            double expected = 5;
            // [2] Act
            Calculator calc = new();
            double actual = calc.Add(a, b);
            // [3] Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(2,2,4)]
        [InlineData(2,3,5)]
        [InlineData(419,1,420)]
        [InlineData(36,33,69)]
        public void TestAdding(double a, double b, double expected)
        {
            // [1] Arrange
            // [2] Act
            Calculator calc = new();
            double actual = calc.Add(a, b);
            // [3] Assert
            Assert.Equal(expected, actual);
        }
    }
}
