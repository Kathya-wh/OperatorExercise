using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;

            

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");



            var areaOfCircle = CalculateArea(20);

            Console.WriteLine($"The area of a circle with radius of 20 is {CalculateArea(20)}");
        }

        public static double CalculateArea(double radius)
        {
            return Math.PI * (radius * radius);
        }
    }
}
