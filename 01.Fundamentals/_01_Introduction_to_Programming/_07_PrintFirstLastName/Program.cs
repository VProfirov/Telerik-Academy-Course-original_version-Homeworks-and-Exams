using System;

namespace _07_PrintFirstLastName
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
                Console.WriteLine("Please provide your First and Last Name: ");
                Console.WriteLine($"Nice to meet you {Console.ReadLine()}");
            }
        }
    }
}