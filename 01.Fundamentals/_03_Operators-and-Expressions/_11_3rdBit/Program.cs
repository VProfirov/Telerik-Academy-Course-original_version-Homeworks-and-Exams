using System;

namespace _11_3rdBit
{
    class Program
    {
        static void Main(string[] args)
        {
            Check3rdBit_Solution();
        }

        private static void Check3rdBit_Solution()
        {
            Console.Write($"Enter nummber whose 3rd index bit be checked: ");
            var isValidInput = int.TryParse(Console.ReadLine(), out int number);

#if DEBUG
            // in Debug Mode the compiler will execute this, but in a Release Mode it will skip this section entirely!
            static void Debug_Visualise_number(int number)
            {
                Console.WriteLine($"BIT at 3rd index: {Check3rdBit(number)}");
                Console.WriteLine($"Number's  meaningful BITS only: {Convert.ToString(number, 2)}");
                Console.WriteLine($"Number's full BITS representation: {GetIntBinaryString(number)}");
            }
            Debug_Visualise_number(number);
#else
            Console.WriteLine($"{Check3rdBit(number)}");
#endif
        }


        private static int Check3rdBit(int number)
        {
            // shift to index [3]
            var mask = 1 << 3;
            var result = number & mask;
            return result >>= 3;
        }
        private static string GetIntBinaryString(int number)
        {
            char[] b = new char[32];
            int pos = 31;
            int i = 0;

            while (i < 32)
            {
                if ((number & (1 << i)) != 0)
                {
                    b[pos] = '1';
                }
                else
                {
                    b[pos] = '0';
                }
                pos--;
                i++;
            }
            return new string(b);
        }
    }
}
