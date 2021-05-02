using System;
using System.Text.RegularExpressions;

namespace _14_BitExchange
{
    public static class WrongSolutions
    {
        static uint ExchangeBits(uint number)
        {
            VisualAid_Single(number, "Number");
            uint bitComb01 = 7;
            var position01 = 3;
            uint bitComb02 = 7;
            var position02 = 24;

            // FIXME: use number based positioning, instead of the quick one <= This causes a BUG
            bitComb01 = (number >> position01) & bitComb01;
            bitComb02 = (number >> position02) & bitComb02;
            VisualAid_BitCombs(new uint[02] { bitComb01, bitComb02 });
            // Possible need of an XOR(111) in order to extract differences : BUT : the exchange mask should handle it

            // a^=b exchange of the bitcomes
            uint exchangeMask = bitComb01 ^ bitComb02;
            VisualAid_Single(exchangeMask, "Exchange Mask");
            bitComb01 ^= exchangeMask;
            bitComb02 ^= exchangeMask;
            VisualAid_BitCombs(new uint[02] { bitComb01, bitComb02 });


            // repositioning and coming FIXME: needs matching bits for (1) :=> FIX: differwithcombsize = combSize(bits:1)
            uint differwithcombsize = 7;
            number ^= differwithcombsize << position01;
            VisualAid_Single(number, "NUMBER-differed");
            VisualAid_Single(bitComb01 << position01, "bitComb01");
            number ^= bitComb01 << position01;
            VisualAid_Single(number, "Combed_01 NUMBER");

            number ^= differwithcombsize << position02;
            VisualAid_Single(number, "NUMBER-differed");
            VisualAid_Single(bitComb02 << position01, "bitComb02");
            number ^= bitComb02 << position02;
            VisualAid_Single(number, "Combed_02 NUMBER");

            // TODO: Compromising alternative solution is bit per bit check at positions 3,4,5 vs 24,25,26 and apply the bit(1) match and opposites swap
            number ^= differwithcombsize << position01;
            VisualAid_Single(number, "NUMBER-differed");
            
            number ^= differwithcombsize << position02;
            VisualAid_Single(number, "NUMBER-differed");

            return number;
        }
        static void VisualAid_Single(uint unit, string unitName)
        {
                var bitcomb_bitwise = Convert.ToString(unit, 2).PadLeft(64, '0');
                var bitcomb_bitwise_formatted = Regex.Replace(bitcomb_bitwise, ".{8}(?!$)", "$0 ");
                Console.WriteLine($"{bitcomb_bitwise_formatted} \t {unitName}({unit})");
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
        static void VisualAid_BitCombs(uint[] bitCombs)
        {
            uint counter = 0;
            foreach (var bitcomb in bitCombs)
            {
                var bitcomb_bitwise = Convert.ToString(bitcomb, 2).PadLeft(64, '0');
                var bitcomb_bitwise_formatted = Regex.Replace(bitcomb_bitwise, ".{8}(?!$)", "$0 ");
                Console.WriteLine($"{bitcomb_bitwise_formatted} \t Bitcomb_{++counter:##} as Number({bitcomb})");
            }
        }
    }
}