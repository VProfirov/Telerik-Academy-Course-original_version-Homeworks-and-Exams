using System;

namespace _02_MoonGravity
{
    class Program
    {
        static void Main()
        {
            MoonGravity_Solution();
        }

        static void MoonGravity_Solution()
        {
            Console.WriteLine($"Enter a weight of an object of worth, which weight you want ot check on the Moon: ");
            var userInput = Console.ReadLine();
            var isValidUserInput = double.TryParse(userInput, out double weight);
            var logValidityOfUserInput = isValidUserInput ? $" User input ({weight}) is valid" : "The user input is an invalid entry (retry with a numeric value)";
            double weightOnMoon = isValidUserInput ? CalculateMoonGravity(weight) : -1;
            Console.WriteLine(isValidUserInput ? $"Weight on EARTH({weight}) and on Moon({weightOnMoon:F3})" : logValidityOfUserInput);
        }
        static double CalculateMoonGravity(double weightOnEarth)
        {
            var moonGravityAsPercentageOfEarths = 0.17d;
            return weightOnEarth * moonGravityAsPercentageOfEarths;
        }
    }
}
