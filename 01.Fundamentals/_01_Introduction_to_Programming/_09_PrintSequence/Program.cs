using System;
using System.Text;
using Microsoft.VisualBasic;

namespace _09_PrintSequence
{
    class Program
    {
        static void Main(string[] args)
        {
           var sb = new StringBuilder();
           var sequenceStart = 2;
           var sequenceSize = 10;
           var loopUpperLimit = sequenceSize + sequenceStart;
           for (int i = sequenceStart; i < loopUpperLimit; i++)
           {
               // Using bitwise check for even: (i & 1) != 0
               if (i % 2 == 0)
               {
                   sb.AppendLine((i.ToString()));
               }
               else
               {
                   sb.AppendLine((i * (-1)).ToString());
               }
           }

           Console.WriteLine(sb);
        }
    }
}