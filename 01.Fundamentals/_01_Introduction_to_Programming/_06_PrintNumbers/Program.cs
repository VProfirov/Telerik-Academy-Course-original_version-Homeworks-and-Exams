using System;
using System.Text;
using System.Xml.Schema;

namespace _06_PrintNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           var sb = new StringBuilder(3);
           sb.AppendLine("1");
           sb.AppendLine("101");
           sb.AppendLine("1001");
           Console.WriteLine(sb);
        }
    }
}