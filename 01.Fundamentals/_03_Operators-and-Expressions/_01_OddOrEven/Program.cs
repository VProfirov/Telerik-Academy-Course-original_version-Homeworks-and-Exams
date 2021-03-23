using System;

namespace _01_OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            // OddOrEven_FullHQC_in_single_method();
            OddOrEven_LazyEvaluation();
        }

        static void OddOrEven_FullHQC_in_single_method()
        {

            Console.WriteLine($"Enter the number you want to check if its ODD or EVEN: ");
            var userInput = Console.ReadLine();
            var userInput_VerificationMSG = string.Empty;
            var userIpnut_isValid = int.TryParse(userInput, out int userNumber);
            var userInput_log_msg = (userIpnut_isValid) ? "int number was provided" : "invalid input(null, float, string, etc...)";

            // TODO: Validation confirmation and msg_out -> do it parallel in .py; .js; .go
        }

        static void OddOrEven_LazyEvaluation()
        {
            Console.WriteLine($"Insert number to be checked if it is ODD or Even: ");
            // var userInput_Number;
            var log_msg_userInput_isValid = "A valid integer number was the user's input";
            var isValid_userInput = true;
            var userInput_Number = int.Parse(Console.ReadLine());
            // if (!int.TryParse(Console.ReadLine(), out int userInput_Number))
            // {
            //     log_msg_userInput_isValid = "The input is not a valid int. Instead it might be (string, null, decimal num, etc...)";
            //     isValid_userInput = false;
            // }

            var isODD = (userInput_Number & 1) == 1;

            var std_out = (isValid_userInput)
                ? $"The user's number({userInput_Number}) is ODD => {isODD}"
                : "Wrong user input! Check the logs!";
            Console.WriteLine(std_out);
        }
    }
}
