using System;

namespace _13_ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            float f2 = 1.5f;
            float f3 = 3f/2f;

            var isEqualWithPrecision_6PP= Math.Abs(f2 - f3) < (float)0.000001;
            
            // areEqual?  
            if (isEqualWithPrecision_6PP) Console.WriteLine($"true"); else Console.WriteLine("false");
            
            #region Logging
            Console.WriteLine(f2);
            Console.WriteLine(f3);
            #endregion
            
            // Basic comparison (Check if they improved something in the recent versions)
            if (f2 == f3) Console.WriteLine($"true"); else Console.WriteLine("false");
            if (f3 == f3) Console.WriteLine($"true"); else Console.WriteLine("false");
            
        }
    }
}