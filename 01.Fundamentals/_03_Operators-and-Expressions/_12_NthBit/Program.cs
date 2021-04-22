using System;

namespace _12_NthBit
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeNBit_Solution();
        }

        private static void ChangeNBit_Solution()
        {
            Console.Write("Number: ");
            var isValidNumber = int.TryParse(Console.ReadLine(), out int number);
            Console.Write("Position: ");
            var isValidPosition = int.TryParse(Console.ReadLine(), out int position);

            Console.WriteLine($"Result: { (number >> position) & 1}");

        }

        static void BitManipulation_TestingArea()
        {
            Console.WriteLine($"{Convert.ToString(10, 2)}");
            Console.WriteLine($"{Convert.ToString(1 << 3, 2)}");
            Console.WriteLine($"{Convert.ToString(10 ^ (1 << 3), 2).PadLeft(4, '0')}");
        }
    }
}
