using System;

namespace _04_Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void Rectangles_Solution()
        {

        }

        class Rectangle
        {
            public Rectangle(int width, int height)
            {
                this.Width = width;
                this.Height = height;
            }

            public int Width { get; set; }
            public int Height { get; set; }
        }
    }
}
