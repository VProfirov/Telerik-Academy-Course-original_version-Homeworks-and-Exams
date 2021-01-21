using System;

namespace _06_StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var hello = "Hello";
            var world = "World";
            object someObjConcant = hello + " " + world + "!";
            string helloWorld = (string)someObjConcant;

            Console.WriteLine(helloWorld);
        }
    }
}