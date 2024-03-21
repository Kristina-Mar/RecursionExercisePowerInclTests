using System.Numerics;

namespace RecursionExercisePower.Tests
{
    public class UnitTest
    {
        [Theory]
        [InlineData(2, 3)]
        [InlineData(5, 0)]
        [InlineData(0, 3)]
        [InlineData(78, 4)]
        [InlineData(125, 3)]
        [InlineData(7.8, 5)]
        [InlineData(3.25, 8)]
        public void TestPowerMethod(double number, int power)
        {
            double result = PowerFunction.Power(number, power);
            Assert.Equal(result, Math.Pow(number, power));
        }
    }
}