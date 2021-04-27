using System;
using System.Text.RegularExpressions;

namespace _14_BitExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exchange bits at 3,4,5 with 24,25,26
            ExchangeBits_Solution();
        }

        static void ExchangeBits_Solution()
        {
            Console.Write($"Number: ");
            var isValidInputNumber = uint.TryParse(Console.ReadLine(), out uint number);
            var modifiedNumber = ExchangeBits(number);

            VisualAid(number);
        }

        static uint ExchangeBits(uint number)
        {
            uint bitComb01 = 3;
            var position01 = 3;
            uint bitComb02 = 3;
            var position02 = 24;

            // FIXME: use number based positioning, instead of the quick one <= This causes a BUG
            bitComb01 = (number >> position01) & bitComb01;
            bitComb02 = (number >> position02) & bitComb02;

            // a^=b exchange of the bitcomes
            uint exchangeMask = bitComb01 ^ bitComb02;
            bitComb01 ^= exchangeMask;
            bitComb02 ^= exchangeMask;

            // repositioning and coming FIXME: needs matching bits for (1)
            number ^= bitComb01 << position01;
            number ^= bitComb02 << position02;

            // TODO: Compromising alternative solution is bit per bit check at positions 3,4,5 vs 24,25,26 and apply the bit(1) match and opposites swap
            return number;
        }

        static void VisualAid(uint starting_number, uint expected_number = 0)
        {
            if(expected_number == 0)
            {
                Console.Write($"Expected Number: ");
                var isValidInputExpectedNumber = uint.TryParse(Console.ReadLine(), out expected_number);
            }

            var starting_number_bitwise= Convert.ToString(starting_number, 2).PadLeft(64, '0');
            var starting_number_bitwise_formatted = Regex.Replace(starting_number_bitwise, ".{8}(?!$)", "$0 ");
            Console.WriteLine($"{starting_number_bitwise_formatted} \t Starting Number({starting_number})");

            var changed_number = ExchangeBits(starting_number);
            var changed_number_bitwise = Convert.ToString(changed_number, 2).PadLeft(64, '0');
            var changed_number_bitwise_formatted = Regex.Replace(changed_number_bitwise, ".{8}(?!$)", "$0 ");
            Console.WriteLine($"{changed_number_bitwise_formatted} \t Changed Number({changed_number})");

            var expected_number_bitwise = Convert.ToString(expected_number, 2).PadLeft(64, '0');
            var expected_number_bitwise_formatted = Regex.Replace(expected_number_bitwise, ".{8}(?!$)", "$0 ");
            Console.WriteLine($"{expected_number_bitwise_formatted} \t Expected Number({expected_number})");
        }
    }
}
