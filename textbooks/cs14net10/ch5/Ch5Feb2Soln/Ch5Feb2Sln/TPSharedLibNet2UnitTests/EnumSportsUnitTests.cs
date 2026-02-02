using TPNS.TPSharedLibNet2;
namespace TPNS.TPSharedLibNet2UnitTests
{
    public class EnumSportsUnitTests
    {
        [Fact]
        public void EnumByteSports69()
        {
            // PREMISE
            // - Test_69 == Tennis(64) + Snowboarding(4) + Football(1)
            // - Test_PickleballGolfSurfing == 8+2+32 == 42            EnumSports.

            // [1] Arrange
            double enum1 = (int)EnumByteSports.Tennis;
            double enum2 = (int)EnumByteSports.Snowboarding;
            double enum3 = (int)EnumByteSports.Football;
            double expected = 69;

            // [2] Act
            double actual = enum1 + enum2 + enum3;

            // [3] Assert
            // Expected: 69
            // Actual: 138
            Assert.Equal(expected, actual);
        }
    }
}
