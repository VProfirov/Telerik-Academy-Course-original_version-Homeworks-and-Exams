using System;
using System.Text;

namespace _16_PrintLongSequence
{
    class Program
    {
        static void Main(string[] args)
        {
           var sb = new StringBuilder();
           var sequenceStart = 2;
           var sequenceSize = 1000;
           var loopUpperLimit = sequenceSize + sequenceStart;
           for (int i = sequenceStart; i < loopUpperLimit; i++)
           {
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