using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace _13_ModifyBit
{
    class Program
    {
        static void Main()
        {
            ModifyBit_Solution();
        }

        static void ModifyBit_Solution()
        {
            Console.Write("Number: ");
            var isValidInputNumber = uint.TryParse(Console.ReadLine(), out uint number);
            Console.Write("Position: ");
            var isValidInputPosition = int.TryParse(Console.ReadLine(), out int position);
            Console.Write("Bit value: ");
            var isValidInputBitValue = uint.TryParse(Console.ReadLine(), out uint bitValue);
            Console.Write("Expected modified number: ");
            var isValidInputExpectedModifiedNumber = uint.TryParse(Console.ReadLine(), out uint expected_modified_number);

            var modifiedNumber = (ModifyBitAtPosition(number, position, bitValue));
#if DEBUG
            VisualAid(number, position, bitValue, expected_modified_number);

            var modifiedNumber_bitwise = Convert.ToString(modifiedNumber, 2).PadLeft(64, '0');
            var modifiedNumber_bitwise_formatted = Regex.Replace(modifiedNumber_bitwise, ".{8}(?!$)", "$0 ");
            Console.WriteLine($"{modifiedNumber_bitwise_formatted} \t Resulted Number({modifiedNumber})");
#endif

#if RELEASE
            Console.WriteLine($"{modifiedNumber}");
#endif
        }

        static uint ModifyBitAtPosition(uint number, int position, uint bit)
        {
            // NOTE: the method VisualAid has a "one-liner" version with "()?:"
            if (((number >> position) & 1) == bit) return number;
            return (uint)(number ^ (1 << position));
        }
        static void VisualAid(uint starting_number, int position, uint bitValue, uint expected_number)
        {
            var starting_number_bitwise= Convert.ToString(starting_number, 2).PadLeft(64, '0');
            var starting_number_bitwise_formatted = Regex.Replace(starting_number_bitwise, ".{8}(?!$)", "$0 ");
            Console.WriteLine($"{starting_number_bitwise_formatted} \t Number({starting_number})");
            // bitValue change is irrelevant for the next XOR as if it is the opposite!
            // BUG POTENTIAL => the bit to change is 1 and it is required to be changed to 1
            // FIXME: insert a bit at position difference check!
            var changed_number = (((starting_number >> position) & 1) != bitValue) ? starting_number ^ (1 << position) : starting_number;
            var changed_number_bitwise = Convert.ToString(changed_number, 2).PadLeft(64, '0');
            var changed_number_bitwise_formatted = Regex.Replace(changed_number_bitwise, ".{8}(?!$)", "$0 ");
            Console.WriteLine($"{changed_number_bitwise_formatted} \t Changed Number({changed_number})");

            var expected_number_bitwise = Convert.ToString(expected_number, 2).PadLeft(64, '0');
            var expected_number_bitwise_formatted = Regex.Replace(expected_number_bitwise, ".{8}(?!$)", "$0 ");
            Console.WriteLine($"{expected_number_bitwise_formatted} \t Expected Number({expected_number})");
        }
    }
}
