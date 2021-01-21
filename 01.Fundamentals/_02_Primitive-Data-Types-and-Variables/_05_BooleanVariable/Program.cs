using System;

namespace _05_BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Are you a female (y/n): ");
            var isFemale = ((Console.ReadLine()?.ToLower()??"no") == "y")? true:false;
            
            if (isFemale) Console.WriteLine("Hi, girl!");
        }
    }
}