using System;

namespace _03_VarInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "254";
            var intInput = int.Parse(input);
            var hexAsString = IntToHex(intInput);
            var intFromHex = HexToInt(hexAsString);
        }

        public static string IntToHex(int intInput)
        {
            var asHex = Convert.ToString(intInput,16).ToUpper();
            
            #region Logging
            Console.WriteLine($"INT INPUT: {intInput}");
            Console.WriteLine($"HEX INPUT: {asHex}");
            #endregion

            return asHex;
        }

        public static int HexToInt(string hex)
        {
            var asInt = Convert.ToInt32(hex,16);
            
            #region Logging
            Console.WriteLine($"HEX INPUT: {hex}");
            Console.WriteLine($"INT INPUT: {asInt}");
            #endregion
            
            return asInt;
        }
    }
}