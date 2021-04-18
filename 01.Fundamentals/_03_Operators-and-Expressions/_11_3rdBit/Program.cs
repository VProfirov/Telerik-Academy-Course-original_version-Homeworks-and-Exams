using System;

namespace _11_3rdBit
{
    class Program
    {
        static void Main(string[] args)
        {
            Check3rdBit_Solution();
        }

        private static void Check3rdBit_Solution()
        {
            Console.Write($"Enter nummber whose 3rd index bit be checked: ");
            var isValidInput = int.TryParse(Console.ReadLine(), out int number);
            Check3rdBit(number);
        }

        private static void Check3rdBit(int number)
        {
            var mask = 1;
            // TODO: FINISH 19.04
        }
    }
}
