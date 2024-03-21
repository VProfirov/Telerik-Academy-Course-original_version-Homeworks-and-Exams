using System;
using System.Globalization;

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
            // NOTE: This is idiotic - What was the idea for TRUE
            if (!isValidInput) //not
            {
                Console.WriteLine($"{logValidityOfUserInput}");
                return;
            }
            else
            {
                Console.WriteLine($"{logValidityOfUserInput}");
            }
            // Console.WriteLine($"is3rd7 as STRING: {is3rdDigit7_StringCheck(number)}");
            // Console.WriteLine($"is3rd7 as NUMBER: {is3rdDigit7_NumericCheck(number)}");
            var is3rd7_AsString = is3rdDigit7_StringCheck(number);
            var is3rd7_AsNumeric = is3rdDigit7_NumericCheck(number);
            var is3rd7_AsString_result = $"{(is3rd7_AsString.is3rd7 ? is3rd7_AsString.is3rd7 : $"{is3rd7_AsString.is3rd7} {is3rd7_AsString.digit}")}".ToLower(CultureInfo.InvariantCulture);
            var is3rd7_AsNumeric_result = $"{(is3rd7_AsNumeric.is3rd7 ? is3rd7_AsNumeric.is3rd7 : $"{is3rd7_AsNumeric.is3rd7} {is3rd7_AsNumeric.digit}")}".ToLower(CultureInfo.InvariantCulture);
            Console.WriteLine($"As String = {is3rd7_AsString_result}");
            Console.WriteLine($"As Numeric = {is3rd7_AsNumeric_result}");
        }

        static (bool is3rd7, string digit) is3rdDigit7_StringCheck(uint number)
        {
            var numberAsString = number.ToString();
            var len = numberAsString.Length;
            var digitAsString = (len >= 3) ? numberAsString[len - 3].ToString() : "0";
            var is3rdDigit7 = digitAsString == "7";

            return (is3rdDigit7, digitAsString);
        }

        static (bool is3rd7, uint digit) is3rdDigit7_NumericCheck(uint number)
        {
            var digit = 0U;
            var is3rdDigit7 = false;
            if (number >= 100)
            {
                number /= 100;
                digit = number % 10;
                is3rdDigit7 = digit == 7;
            }

            return (is3rdDigit7, digit);
        }
    }
}
