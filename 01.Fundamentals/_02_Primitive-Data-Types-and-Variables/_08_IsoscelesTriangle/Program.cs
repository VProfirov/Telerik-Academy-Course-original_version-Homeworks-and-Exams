using System;

namespace _08_IsoscelesTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            char cpr = '\u00A9';
            Console.WriteLine($"   {cpr}   ");
            Console.WriteLine($"  {cpr} {cpr}  ");
            Console.WriteLine($" {cpr}   {cpr} ");
            Console.WriteLine($"{cpr} {cpr} {cpr} {cpr}");
        }
    }
}