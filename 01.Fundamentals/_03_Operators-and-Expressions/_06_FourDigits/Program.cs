using System;

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

            FourDigits_Solution_Hardcoded_Numeric(9876);
        }

        // The simplest solution to the current problem =>
        // 1. No input checks/validation
        // 2. No logging of anysorts
        // 3. No fault tolerance
        static void FourDigits_Solution_Hardcoded_Numeric(int number)
        {
            FourDigits_Solution_Hardcoded_Numeric_T1(number);
            FourDigits_Solution_Hardcoded_Numeric_T2(number);
            FourDigits_Solution_Hardcoded_Numeric_T3(number);
            FourDigits_Solution_Hardcoded_Numeric_T4(number);
        }
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


        static void FourDigits_Solution_Hardcoded_Numeric_T2(int number)
        {

        }
        static void FourDigits_Solution_Hardcoded_Numeric_T3(int number)
        {

        }
        static void FourDigits_Solution_Hardcoded_Numeric_T4(int number)
        {

        }
    }
}
