using System.Numerics;

namespace RecursionExercisePower
{
    public class PowerFunction
    {
        static void Main(string[] args)
        {
            int number = 2;
            int power = 4;
            int result = Power(number, power);
            Console.WriteLine($"{number} ^ {power} = {result}");
        }
        public static int Power(int number, int power)
        {
            if (power == 0)
            {
                return 1;
            }
            else
            {
                return number * Power(number, power - 1);
            }
        }
    }
}
