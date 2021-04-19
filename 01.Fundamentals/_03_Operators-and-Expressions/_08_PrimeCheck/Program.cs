using System;
using System.IO;

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

#if DEBUG
            PrimeCheck_Extended_Check();
#endif
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
            // NOTE:  Two main approaches to this:
            // NOTE:  use 1/2 on the number's size for the divider's upper limit or
            // NOTE:  Sqrt of the Number as upper bound to check
            // NOTE:  SQRT is optimal as does less steps => for number=8 (divider-steps = 3 {2,3,4}) vs (sqrt-steps = 2 {2,3})
            if (number < 2) return false;
            if (number == 2) return true;
            for (int i = 2; i <= (int)Math.Sqrt(number); ++i)
            {
                // NOTE: Condition: The number has to divide only to 1 and itself => there has to be always a reminder to be Prime
                // NOTE: (unless divides to itself)
                if (number % i == 0) return false;
            }
            return true;
        }

        static void PrimeCheck_Extended_Check()
        {
            // Testing a concept:
            Console.WriteLine($"-----EXTENDED-PRIME-TESTING-------");

            var primeNumbersAsText = File.ReadAllText("../../../PrimeList.txt");
            var primesAsStringArray = primeNumbersAsText.Trim().Split(new char[] { ' ', ',', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var primesAsInt32Array = Array.ConvertAll<string, int>(primesAsStringArray, new Converter<string, int>(x => Convert.ToInt32(x, 10)));
            // Array.ForEach(primesAsInt32Array, Console.WriteLine);
            // Array.ForEach(primesAsStringArray, Console.WriteLine);

            // Array.ForEach(primesAsInt32Array, x => Console.WriteLine($"{x} : {IsPrimeCheck(x)}"));

            var numbersCheckIfPrimesAsText = File.ReadAllText("../../../PrimeCheckList.txt"); // 1-50 check for primes
            var numbersCheckIfPrimeAsStringArray = numbersCheckIfPrimesAsText.Trim().Split(new char[] { ' ', ',', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var numbersCheckIfPrimeAsInt32Array = Array.ConvertAll<string, int>(numbersCheckIfPrimeAsStringArray, new Converter<string, int>(x => Convert.ToInt32(x, 10)));

            var primeIndex = 0;
            for (int i = 0; i < numbersCheckIfPrimeAsInt32Array.Length; ++i)
            {
                var isPrime = IsPrimeCheck(numbersCheckIfPrimeAsInt32Array[i]);
                Console.WriteLine($"{numbersCheckIfPrimeAsInt32Array[i]} : {isPrime} -> { (isPrime ? primesAsInt32Array[primeIndex++] : "")}");
            }
        }
    }
}