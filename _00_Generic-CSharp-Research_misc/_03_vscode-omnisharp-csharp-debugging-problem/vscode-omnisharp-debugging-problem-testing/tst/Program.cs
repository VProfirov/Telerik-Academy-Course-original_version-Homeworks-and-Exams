using System;

namespace tst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"My name is {Console.ReadLine()} YAS!");

            Console.WriteLine($"age ... ");
            
            var age = Console.ReadLine();
            
            Console.WriteLine($"motto ...");
            var motto = Console.ReadLine();
            
            Console.WriteLine($"Age: {age} && motto: {motto}");
            
        }
    }
}
