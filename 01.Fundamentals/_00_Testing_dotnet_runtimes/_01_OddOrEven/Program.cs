using System;
using System.Net.Http.Json;

namespace _01_OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            OddOrEven_HQC_SHORT_SingleMethod();
            // OddOrEven_HowNotToDoIt();
        }

        static void OddOrEven_HQC_SHORT_SingleMethod()
        {
            Console.WriteLine($"Enter the number you want to check if its ODD or EVEN: ");
            var userInput = Console.ReadLine();
            var isValidUserInput = int.TryParse(userInput, out int numberUserInput);
            var logUserInputVerificationStatus = isValidUserInput ? "VALID int type castable input!" : $"INVALID Input ({userInput}). Unable to cast to int.";
            var isOdd = (numberUserInput & 1) == 1;
            var result = (isValidUserInput) ? $"The User's number ({numberUserInput}) is {(isOdd ? "ODD" : "EVEN")}" : $"{logUserInputVerificationStatus}";
            Console.WriteLine(result);
        }

        static void OddOrEven_HowNotToDoIt()
        {
            Console.WriteLine($"Insert number to be checked if it is ODD or Even: ");
            // var numberUserInput;
            var logUserInput = "A valid integer number was the user's input";
            var isValidUserInput = true;
            var userInput = Console.ReadLine();
            if (!int.TryParse(userInput, out int numberUserInput))
            {
                logUserInput = "The input is not a valid int.\r\n" +
                               $"The actual input is ({userInput})\r\n" +
                               "Instead of the requested type int it might be string, null, decimal num, etc...";
                isValidUserInput = false;
            }

            var isOdd = (numberUserInput & 1) == 1;

            var stdout = (isValidUserInput)
                ? $"The user's number({numberUserInput}) is {(isOdd? "ODD" : "EVEN")}"
                : $"Wrong user input! Check the logs!";
            Console.WriteLine(stdout);

            if (!isValidUserInput)
            {
                Console.WriteLine($"---LOG---\r\n{logUserInput}\r\n---END-LOG---");
            }
        }
    }
}
