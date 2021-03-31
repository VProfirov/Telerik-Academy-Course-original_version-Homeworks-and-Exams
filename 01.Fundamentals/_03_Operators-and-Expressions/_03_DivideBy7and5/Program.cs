using System;
using System.Collections.Generic;

namespace _03_DivideBy7and5
{
    class Program
    {
        static void Main(string[] args)
        {
            DivisibilityBy5and7_Solution();
        }

        static void DivisibilityBy5and7_Solution()
        {
            Console.WriteLine($"Enter integer number to be checked for possible divison of 7 and 5 without remainder: ");
            var userInput = Console.ReadLine();
            var isValidInput = int.TryParse(userInput, out int number);
            var logValidityOfUserInput = isValidInput ? $"Valid user input as number : {number}" : "Invalid user input! Can't be parsed as integer number.";
            var isDivisibleBy5and7 = isValidInput && CheckDivisibilityBy5and7(number);
            Console.WriteLine(isValidInput ? $" Is the number({number}) divisible by 5 and 7 ==> {isDivisibleBy5and7}" : logValidityOfUserInput);
        }

        static bool CheckDivisibilityBy5and7(int number)
        {
            return (number % 5 == 0) && (number % 7 == 0);
        }
    }
}
