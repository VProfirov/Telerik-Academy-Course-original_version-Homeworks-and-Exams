using System;
using System.Collections.Generic;
using System.Numerics;

namespace _01_DeclareVariables
{
    class Program
    {
        static void Main()
        {
            var bigIntInputHolder = new List<BigInteger>();
            var input = "52130, -115, 4825932, 97, -10000";
            var stringInput = input.Split(", ");
            Array.ForEach(stringInput,numberString => bigIntInputHolder.Add(BigInteger.Parse(numberString)));
            // Sorted variable declaration by optimal type (simple)
            List<sbyte> sbyte_list = new List<sbyte>();
            List<byte> byte_list = new List<byte>();
            List<short> short_list = new List<short>();
            List<ushort> ushort_list = new List<ushort>();
            List<int> int_list = new List<int>();
            List<uint> uint_list = new List<uint>();
            List<long> long_list = new List<long>();
            List<ulong> ulong_list = new List<ulong>();
            // List<float> float_list = new List<float>();
            // List<double> double_list = new List<double>();
            // List<decimal> decimal_list = new List<decimal>();
            // List<BigInteger> bigInteger_list = new List<BigInteger>();
            
            foreach (var unassignedNumber in bigIntInputHolder)
            {
                if (unassignedNumber <= byte.MaxValue && unassignedNumber >= byte.MinValue)
                {
                    byte_list.Add((byte)unassignedNumber);
                    Console.WriteLine($"{unassignedNumber} is of optimal type -> byte");
                }
                else if ( unassignedNumber  <= sbyte.MaxValue && unassignedNumber >= sbyte.MinValue)
                {
                    sbyte_list.Add((sbyte)unassignedNumber);
                    Console.WriteLine($"{unassignedNumber} is of optimal type -> sbyte");
                }
                else if ( unassignedNumber  <= short.MaxValue && unassignedNumber >= short.MinValue)
                {
                    short_list.Add((short)unassignedNumber);
                    Console.WriteLine($"{unassignedNumber} is of optimal type -> short");
                }
                else if ( unassignedNumber  <= ushort.MaxValue && unassignedNumber >= ushort.MinValue)
                {
                    ushort_list.Add((ushort)unassignedNumber);
                    Console.WriteLine($"{unassignedNumber} is of optimal type -> ushort");
                }
                else if ( unassignedNumber  <= int.MaxValue && unassignedNumber >= int.MinValue)
                {
                    int_list.Add((int)unassignedNumber);
                    Console.WriteLine($"{unassignedNumber} is of optimal type -> int");
                }
                else if ( unassignedNumber  <= uint.MaxValue && unassignedNumber >= uint.MinValue)
                {
                    uint_list.Add((uint)unassignedNumber);
                    Console.WriteLine($"{unassignedNumber} is of optimal type -> uint");
                }
                else if ( unassignedNumber  <= long.MaxValue && unassignedNumber >= long.MinValue)
                {
                    long_list.Add((long)unassignedNumber);
                    Console.WriteLine($"{unassignedNumber} is of optimal type -> long");
                }
                else if ( unassignedNumber  <= ulong.MaxValue && unassignedNumber >= ulong.MinValue)
                {
                    ulong_list.Add((ulong)unassignedNumber);
                    Console.WriteLine($"{unassignedNumber} is of optimal type -> ulong");
                }
            }
        }
    }
}