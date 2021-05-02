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
            var modifiedNumber = ExchangeBits(number, new uint[2] { 3, 24 }, 3);
            Console.Write($"Expected Number: ");
            var isValidInputExpectedNumber = uint.TryParse(Console.ReadLine(), out uint expected_number);

            VisualAid_Stages(number, modifiedNumber, expected_number);
            // RESULT:
            Console.WriteLine($"{modifiedNumber}");
        }

        static uint ExchangeBits(uint number, uint[] indexes, uint modificationLength)
        {
            for (int shift = 0; shift < modificationLength; shift++)
            {
                var position00 = (int)(indexes[0] + shift);
                var position01 = (int)(indexes[1] + shift);
                if (((number >> position00) & 1) != ((number >> position01) & 1))
                {
                    number = ChangeBits(number, position00, position01);
                }
            }
            // VisualAid_Single(number, "Number");

            return number;
        }

        private static uint ChangeBits(uint number, int position00, int position01)
        {
            number ^= 1u << position00;
            number ^= 1u << position01;
            return number;
        }

        static void VisualAid_Stages(uint starting_number, uint modified_number, uint expected_number)
        {
            Console.WriteLine($"____RESULT____");

            var starting_number_bitwise = Convert.ToString(starting_number, 2).PadLeft(64, '0');
            var starting_number_bitwise_formatted = Regex.Replace(starting_number_bitwise, ".{8}(?!$)", "$0 ");
            Console.WriteLine($"{starting_number_bitwise_formatted} \t Starting Number({starting_number})");

            var modified_number_bitwise = Convert.ToString(modified_number, 2).PadLeft(64, '0');
            var modified_number_bitwise_formatted = Regex.Replace(modified_number_bitwise, ".{8}(?!$)", "$0 ");
            Console.WriteLine($"{modified_number_bitwise_formatted} \t Changed Number({modified_number})");

            var expected_number_bitwise = Convert.ToString(expected_number, 2).PadLeft(64, '0');
            var expected_number_bitwise_formatted = Regex.Replace(expected_number_bitwise, ".{8}(?!$)", "$0 ");
            Console.WriteLine($"{expected_number_bitwise_formatted} \t Expected Number({expected_number})");
        }
        static void VisualAid_Single(uint unit, string unitName)
        {
            var bitcomb_bitwise = Convert.ToString(unit, 2).PadLeft(64, '0');
            var bitcomb_bitwise_formatted = Regex.Replace(bitcomb_bitwise, ".{8}(?!$)", "$0 ");
            Console.WriteLine($"{bitcomb_bitwise_formatted} \t {unitName}({unit})");
        }
    }
}
