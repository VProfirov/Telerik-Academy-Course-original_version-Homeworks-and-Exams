//#! /usr/bin/env dotnet

using System;

namespace SinglePointPrecision
{
    class Float_or_Double
    {
        public static void Main()
        {
            var float_01 = 0.12345678912346789123456789f;
            Console.WriteLine($"long float_01: {float_01} \n " +
                              $"with len: {float_01.ToString().Length - 1}");
            var f2 = 11.12345678912346789123456789f;

        }
    }
}