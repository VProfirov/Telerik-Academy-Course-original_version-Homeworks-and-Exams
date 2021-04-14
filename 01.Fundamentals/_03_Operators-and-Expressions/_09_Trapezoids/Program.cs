using System;
using System.Globalization;
using System.Text;

namespace _09_Trapezoids
{
    class Program
    {
        static void Main(string[] args)
        {
            TrapezoidArea_Solution();
        }

        static void TrapezoidArea_Solution()
        {
            Console.WriteLine($"Enter the bases' and height's length: ");
            //this might not be the best idea XD
            var log = new StringBuilder();
            var isValidInput = true;
            Console.Write($"base_one: ");
            log.AppendLine((isValidInput = double.TryParse(Console.ReadLine(), out double base_one)) ? 
            $"Valid user input for 1|2 base: {base_one}" : $"Incorrect user input 1|2 base: {base_one}");
            Console.Write($"base_two: ");
            log.AppendLine((isValidInput = double.TryParse(Console.ReadLine(), out double base_two)) ? 
            $"Valid user input for 2|2 base: {base_two}" : $"Incorrect user input 2|2 base: {base_two}");
            Console.Write($"height: ");
            log.AppendLine((isValidInput = double.TryParse(Console.ReadLine(), out double height)) ? 
            $"Valid user input for height: {height}" : $"Incorrect user input height: {height}");

            var trapezoidArea = 0d;
            log.AppendLine((isValidInput) ? $"Trapezoid Area: {(trapezoidArea = CalculateAreaOfTrapezoid(base_one, base_two, height)).ToString(CultureInfo.InvariantCulture)}" : "Problem with the computation of the trapezoid's area!");
            Console.WriteLine($"{trapezoidArea:F7}");

            // We are exploring the concept of having some sort of logging system, skipping the "cpu heavier" try-catch type of logging or using any other logging lib. And have fault tolerance for our console app(mostly no crashes, without any defaulting behavior)
            // NOTE: After this exercise/task we will not be doing any logging or input validation, and we will assume the input will be always valid and in the bounds required for the correct/expected computaiton!
            // NOTE: For more on Logging libraries in C# : https://michaelscodingspot.com/logging-in-dotnet/
            #region Logging
            // Console.WriteLine($"{log.ToString()}");
            #endregion
        }

        static double CalculateAreaOfTrapezoid(double base_one, double base_two, double height)
        {
            return ((base_one + base_two) * height) / 2;
        }
    }
}
