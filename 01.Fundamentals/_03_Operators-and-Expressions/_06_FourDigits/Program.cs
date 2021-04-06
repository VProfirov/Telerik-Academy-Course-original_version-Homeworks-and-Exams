using System;
using System.Globalization;
using System.Linq;

namespace _06_FourDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            // TASK: Given an integer number number:
            // 1. print the digits of the number as a sum
            // 2. print the digits of the number in reversed order
            // 3. print abcd as {d}abc
            // 4. print abcd as a{c}{b}d

            FourDigits_Solution();
        }

        // The simplest solution to the current problem =>
        // 1. No input checks/validation
        // 2. No logging of anysorts
        // 3. No fault tolerance

        static void FourDigits_Solution()
        {
            Console.WriteLine($"Enter the four digit integer for transformation:");
            var userInput_number = Console.ReadLine();
            FourDigits_Solution_Hardcoded_AsString(userInput_number);
        }
        static void FourDigits_Solution_Hardcoded_AsString(string number)
        {
            Console.WriteLine($"T1: {FourDigits_Solution_Hardcoded_AsString_T1(number)}");
            Console.WriteLine($"T2: {FourDigits_Solution_Hardcoded_AsString_T2(number)}");
            Console.WriteLine($"T3: {FourDigits_Solution_Hardcoded_AsString_T3(number)}");
            Console.WriteLine($"T4: {FourDigits_Solution_Hardcoded_AsString_T4(number)}");
        }
        static int FourDigits_Solution_Hardcoded_AsString_T1(string number)
        {
            var sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                // Doing arithmetical operations on chars (+-*/)
                // uses for computation their underlying ASCII code '0' = 48 up to '9' = 57
                sum += number[i] - '0';
                // sum += int.Parse(number[i].ToString());
            }
            return sum;
        }

        static string FourDigits_Solution_Hardcoded_AsString_T2(string number)
        {
            var reversed_CharArray = number.Reverse().ToArray();
            var reversed = new string(reversed_CharArray);
            return reversed;
        }
        static string FourDigits_Solution_Hardcoded_AsString_T3(string number)
        {
            return $"{number[3]}{number[0]}{number[1]}{number[2]}";
        }
        static string FourDigits_Solution_Hardcoded_AsString_T4(string number)
        {
            return $"{number[0]}{number[2]}{number[1]}{number[3]}";
        }

        #region NumericVersionOfDigitSum
        // NOTE: Takes "number" as an int, so int.Parse should be done
        static void FourDigits_Solution_Hardcoded_Numeric_T1(int number)
        {
            var sum = 0;
            var counter = 0;
            do
            {
                sum += number % 10;
                number /= 10;
            } while (++counter < 4);
            Console.WriteLine($"SUM: {sum}");
        }
        #endregion
    }
}
