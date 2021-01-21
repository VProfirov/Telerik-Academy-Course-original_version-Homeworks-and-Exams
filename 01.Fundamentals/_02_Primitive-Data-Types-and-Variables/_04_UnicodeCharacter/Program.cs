using System;
using System.Text;

namespace _04_UnicodeCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            var strIntInput = "42";
            var charInput = (char) int.Parse(strIntInput);
            var hexInput = Convert.ToString(int.Parse(strIntInput),16).ToUpper();
            var hexIntoUnicodeCharRepresentationAsString = $"\\u00{hexInput}";

            Console.WriteLine($"CHAR as decimal INT: {strIntInput}");
            Console.WriteLine($"HEX INPUT: {hexInput}");
            Console.WriteLine($"HEX into Char as STRING: {hexIntoUnicodeCharRepresentationAsString}");
            Console.WriteLine($"CHAR INPUT: {charInput}");
        }
    }
}