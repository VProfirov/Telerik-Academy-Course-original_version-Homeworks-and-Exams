using System;

namespace _05_ThirdDigit
{
    class Program
    {
        static void Main()
        {
            CheckThirdDigit_Solution();
        }

        static void CheckThirdDigit_Solution()
        {
            Console.WriteLine($"Enter positive integer number for witch there will be a check if the 3rd digit is 7(if not what is it): ");
            var userInput = Console.ReadLine();
            var isValidInput = uint.TryParse(userInput, out uint number);
            var logValidityOfUserInput = isValidInput ? $"Valid user input as number : {number}" : "Invalid user input! Can't be parsed as integer number.";

            Console.WriteLine($"is3rd7 as STRING: {is3rdDigit7_StringCheck(number)}");
            Console.WriteLine($"is3rd7 as NUMBER: {is3rdDigit7_NumericCheck(number)}");
            var is3rd7_AsString = is3rdDigit7_StringCheck(number);
            var is3rd7_AsNumeric = is3rdDigit7_NumericCheck(number);

            Console.WriteLine($"{is3rd7_AsString.Item1 ? is3rd7_AsString.Item1.ToString() : is3rd7_AsString}");
            Console.WriteLine($"{is3rd7_AsNumeric.Item1 ? is3rd7_AsNumeric.Item1.ToString() : is3rd7_AsNumeric}");
        }

        static (bool,string) is3rdDigit7_StringCheck(uint number)
        {
            var numberAsString = number.ToString();
            var len = numberAsString.Length;
            var digitAsString = (len >= 3) ? numberAsString[len - 3].ToString() : "0";
            var is3rdDigit7 = digitAsString == "7";

            return (is3rdDigit7, digitAsString);
        }

        static (bool, uint) is3rdDigit7_NumericCheck(uint number)
        {
            var digit = 0U;
            var is3rdDigit7 = false;
            if (number >= 700)
            {
                number /= 100;
                digit = number % 10;
                is3rdDigit7 = digit == 7;
            }

            return (is3rdDigit7, digit);
        }
    }
}
