using System;

namespace _12_NthBit
{
    class Program
    {
        static void Main(string[] args)
        {

            // VisualAid(6);
            // VisualAid(1<<3);
            // VisualAid(6 ^ (1<<3));

            Console.WriteLine($"{Convert.ToString(10, 2)}");
            Console.WriteLine($"{Convert.ToString(1 << 3, 2)}");
            Console.WriteLine($"{Convert.ToString(10 ^ (1 << 3), 2).PadLeft(4, '0')}");
            // CR();

            Strange_Solution();
        }

        static void Strange_Solution()
        {
              Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter position: ");
            int position = int.Parse(Console.ReadLine());
            Console.Write("Enter value: ");
            int value = int.Parse(Console.ReadLine());

            if (((number >> position) & 1) != value) number = ChangeBit(number, position);

            Console.Clear();
            Console.WriteLine("Result: " + number);

            //while (true)
            //{
            //    Main(new string[]{});
            //}
        }

        static int ChangeBit(int number, int position)
        {
            return number ^ (1 << position);
        }

        static void VisualAid(int number)
        {
            Console.WriteLine($"{Convert.ToString(number, 2)}");
        }

        static void CR()
        {
            int codeRead = 0;
            do
            {
                codeRead = Console.Read();
                Console.WriteLine($"code: {codeRead} => char: {(char)codeRead}");
            } while (codeRead != 10);
        }
    }
}
