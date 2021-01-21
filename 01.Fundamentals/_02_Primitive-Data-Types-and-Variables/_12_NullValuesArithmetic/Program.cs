using System;

namespace _12_NullValuesArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int? numInt32 = null;
            double? numDouble = null;

            Console.WriteLine($"numInt32: {numInt32}");
            Console.WriteLine($"numDouble: {numDouble}");

            numInt32 += 1;
            numDouble += 1;
            
            Console.WriteLine($"numInt32: {numInt32}");
            Console.WriteLine($"numDouble: {numDouble}");

            numInt32 += null;
            numDouble += null;
            
            Console.WriteLine($"numInt32: {numInt32}");
            Console.WriteLine($"numDouble: {numDouble}");
        }
    }
}