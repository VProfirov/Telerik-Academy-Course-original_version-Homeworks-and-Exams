using System;
using System.Collections.Generic;

namespace _03_DivideBy7and5
{
    class Program
    {
        static void Main(string[] args)
        {
            Manual_Solution_Test();
        }

        static bool Divided_Solution(int number)
        {
            Console.WriteLine($"Enter integer number to be checked for possible divison of 7 and 5 without remainder: ");
            var userInput = Console.ReadLine();
            var isValidInput = int.TryParse(userInput, out int num);
            var logValidityOfUserInput = isValidInput ? $"Valid user input as number : {num}" : "Invalid user input! Can't be as integer number.";
            return true; //TODO: finish the solution
        }

        static void Manual_Solution_Test()
        {
            var div_by_35 = new List<double>();
            var isDiv_by_35_noR = new List<bool>();
            // var div_by_5_and_7 = new List<double> ();
            var div_by_5 = new List<double>();
            var div_by_7 = new List<double>();
            var isDiv_by_5_and_7_noR = new List<bool>();
            for (int i = 0; i < 100; ++i)
            {
                div_by_35.Add(i / 35);
                isDiv_by_35_noR.Add(i % 35 == 0);

                div_by_5.Add(i / 5);
                div_by_7.Add(i / 7);
                isDiv_by_5_and_7_noR.Add((i % 5 == 0) && (i % 7 == 0));
            }
            Console.WriteLine($"Check the debugger {Console.ReadLine()}");
        }
    }
}
