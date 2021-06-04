namespace BitManipulation
{
    class BitManipulator
    {
        static void BitChangeAtPosition()
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

        }
        private static int ChangeBit(int number, int position)
        {
            return number ^ (1 << position);
        }
    }
}