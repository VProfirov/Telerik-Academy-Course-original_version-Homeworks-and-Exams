using System;

namespace _05_PrintName
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine($"Nice to meet you {string.Join(" ",args)}");
            }
            else
            {
                Console.WriteLine("Please provide your Name: ");
                Console.WriteLine($"Nice to meet you {Console.ReadLine()}");
            }
        }
    }
}