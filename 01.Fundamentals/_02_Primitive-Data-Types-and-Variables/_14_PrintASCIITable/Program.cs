using System;
using System.Net.Mime;
using System.Text;

namespace _14_PrintASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (int start = 33, end = 126, index = start; index >= start && index <= end; index++)
            {
                Console.WriteLine((char)index);
            }
        }
    }
}