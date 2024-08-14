using System;
using System.IO;

namespace _10_FormatCode
{
    class Program
    {
        private static void Main(string[] args)
        {
            // var str = File.ReadAllText("../../../HorribleCode_Formatted.txt");
            var str = File.ReadAllText("./HorribleCode_Formatted.txt");
            Console.WriteLine(str);
        }
    }
}