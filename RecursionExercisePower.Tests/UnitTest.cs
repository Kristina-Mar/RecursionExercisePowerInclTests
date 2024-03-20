using System.Numerics;

namespace RecursionExercisePower.Tests
{
    public class UnitTest
    {
        [Theory]
        [InlineData(2, 3)]
        [InlineData(5, 8)]
        [InlineData(25, 3)]
        [InlineData(78, 4)]
        [InlineData(125, 3)]
        public void Test1(int number, int power)
        {
            int result = PowerFunction.Power(number, power);
            Assert.Equal(result, Math.Pow(number, power));
        }
    }
}