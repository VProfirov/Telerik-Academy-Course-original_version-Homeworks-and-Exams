using System;

namespace _09_ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = 10;

            Console.WriteLine($"Value of A: {a}");
            Console.WriteLine($"Value of B: {b}");
            
            a ^= b;
            b ^= a;
            a ^= b;
            
            Console.WriteLine($"Value of A: {a}");
            Console.WriteLine($"Value of B: {b}");
        }
    }
}