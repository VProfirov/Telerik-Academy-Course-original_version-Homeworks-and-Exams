using System;

namespace _08_PrimeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            // Note considered to be Prime:
            // 1. Negative ints
            // 2. 0
            // 3. 1
            PrimeCheck_Solution();
        }

        static void PrimeCheck_Solution()
        {
            // if  1 < number >= 2 && number % i !=0 return true
            Console.Write("Enter number to be checked if it is prime: ");
            var userInput = Console.ReadLine();
            var isPrime = int.TryParse(userInput, out int numberINT) && IsPrimeCheck(numberINT);
            Console.WriteLine($"{isPrime}");
        }

        static bool IsPrimeCheck(int number)
        {
            if (number < 2) return false;
            if (number == 2) return true;
            for (int i = 2; i < Math.Sqrt(number); ++i)
            {
                if(number % i == 0) return false;
            }
            return true;
        }
    }
}
