using System;
using System.Collections.Generic;

namespace _02_FloatOrDouble
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = "34.567839023, 12.345, 8923.1234857, 3456.091";
            var numbersAsStringArray = input.Split(", ");

            AccuracyDecisionTree_FloatDoubleAssignement(numbersAsStringArray);
        }

        private static void AccuracyDecisionTree_FloatDoubleAssignement(string[] numsAsStringArray)
        {
            var floats = new List<float>();
            var doubles = new List<double>();

            foreach (var numStr in numsAsStringArray)
            {
                // float :=> check int part if x<=(0-9) => float 9 digits (1.7dig) 7th-last is rounded-up
                // double :=> check int part if it has 15 meaningful digits -> 16 if the 1st "meaningful"(it not considered as such) is 0 

                var numDecimalSplit = numStr.Split('.');
                var intPartLength = numDecimalSplit[0].Length;
                var decimalPartLength = numDecimalSplit[1].Length;
                var meaningfulDigitsLength = intPartLength + decimalPartLength;
                // FLOAT: (7 if 0. // 6 if !0.) -> last digit is rounded (if the input single point number is with larger precision)
                var withinFloatPrecisionRangeCheck = numDecimalSplit[0] == "0" && decimalPartLength <= 7 ||
                                                     numDecimalSplit[0] != "0" && decimalPartLength <= 6;
                var withinFloatRangeCheck = intPartLength + decimalPartLength <= 7;
                if (withinFloatRangeCheck && withinFloatPrecisionRangeCheck)
                {
                    floats.Add(float.Parse(numStr));
                    Console.WriteLine($"{numStr} is FLOAT");
                }

                // DOUBLE: (16 if 0. // 15 if !0.) --> last digit is rounded (if the input single point number is with larger precision)
                var withinDoublePrecisionRangeCheck = numDecimalSplit[0] == "0" && decimalPartLength <= 16 ||
                                                      numDecimalSplit[0] != "0" && decimalPartLength <= 15;
                var notWithinFloatPrecisionRangeCheck = numDecimalSplit[0] == "0" && decimalPartLength > 7 ||
                                                        numDecimalSplit[0] != "0" && decimalPartLength > 6;
                var withinDoubleRangeCheck = intPartLength + decimalPartLength <= 16;

                if (withinDoubleRangeCheck && withinDoublePrecisionRangeCheck && notWithinFloatPrecisionRangeCheck)
                {
                    doubles.Add(double.Parse(numStr));
                    Console.WriteLine($"{numStr} is DOUBLE");
                }
            }

            #region dbs_check

            Console.WriteLine("----floats----");
            foreach (var f in floats) Console.WriteLine(f);

            Console.WriteLine("---doubles-----");
            foreach (var d in doubles) Console.WriteLine(d);

            #endregion
        }
    }
}