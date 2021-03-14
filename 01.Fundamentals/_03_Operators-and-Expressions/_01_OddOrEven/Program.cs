using System;

namespace _01_OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter the number you want to check if its ODD or EVEN: ");
            var userInput = Console.ReadLine();
            var userInput_VerificationMSG = string.Empty;
            int? userNumber = null;
            var userIpnut_isValid = int.TryParse(userInput,out userNumber?);

            // TODO: Validation confirmation and msg_out -> do it parallel in .py; .js; .go
        }
    }
}
