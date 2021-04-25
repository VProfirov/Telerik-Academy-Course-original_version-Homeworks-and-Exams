using System;
using System.Globalization;

namespace _13_ModifyBit
{
    class Program
    {
        static void Main(string[] args)
        {
            ModifyBit_Solution();
        }

        static void ModifyBit_Solution()
        {
            Console.Write("Number: ");
            var isValidInputNumber = int.TryParse(Console.ReadLine(), out int number);
            Console.Write("Position: ");
            var isValidInputPosition = int.TryParse(Console.ReadLine(), out int position);
            Console.Write("Bit value: ");
            var isValidInputBitValue = int.TryParse(Console.ReadLine(), out int bitValue);
            Console.Write("Expected modified number: ");
            var isValidInputExpectedModifiedNumber = int.TryParse(Console.ReadLine(), out int expected_modified_number);
            VisualAid(number, position, bitValue, expected_modified_number);
        }

        static void VisualAid(int starting_number, int position, int bitValue, int? expected_number)
        {
            Console.WriteLine($"{Convert.ToString(starting_number, 2).PadLeft(32, '0')}");
            // bitValue change is irrelevant for the next XOR as if it is the opposite!
            // BUG POTENTIAL => the bit to change is 1 and it is required to be changed to 1
            // FIXME: insert a bit at position difference check!
            var changed_number = starting_number ^ (1 << position);
            Console.WriteLine($"{Convert.ToString(changed_number, 2).PadLeft(32, '0')}");
            Console.WriteLine($"{Convert.ToString(expected_number ?? 0, 2).PadLeft(32, '0')}");
        }
    }
}
