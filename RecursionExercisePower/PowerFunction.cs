using System.Numerics;

namespace RecursionExercisePower
{
    public class PowerFunction
    {
        static void Main(string[] args)
        {
            double number = 2;
            int power = 4;
            double result = Power(number, power);
            Console.WriteLine($"{number} ^ {power} = {result}");
            number = 3.2;
            power = 5;
            result = Power(number, power);
            Console.WriteLine($"{number} ^ {power} = {result}");
        }
        public static double Power(double number, int power)
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
