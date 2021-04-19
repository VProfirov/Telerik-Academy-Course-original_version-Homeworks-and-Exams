using System;

namespace _10_PointCircleRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // INSIDE Circle && OUTSIDE Rectangle!!
        }

        static void PointCircleRectangle_Solution()
        {
            Console.WriteLine("Enter the coordinates x-y for the point:");
            Console.Write("X: ");
            var isValidInputX = int.TryParse(Console.ReadLine(), out int pointX);
            Console.Write("Y: ");
            var isValidInputY = int.TryParse(Console.ReadLine(), out int pointY);

            var point = new Point(pointX, pointY);
            var circle = new Circle();
        }

        class Point
        {
            public Point(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
            public int X { get; set; }
            public int Y { get; set; }
            public bool CheckInsideCircle(Circle circle)
            {
                return Math.Pow((X - circle.X), 2) + Math.Pow((Y - circle.Y), 2) <= Math.Pow(circle.Radius, 2);
            }
            public double FindDistanceToCenter()
            {
                return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            }

        }
        class Circle
        {
            public Circle(int x = 1, int y = 1, double radius = 1.5)
            {
                this.X = x;
                this.Y = y;
                this.Radius = radius;
            }

            public double Radius { get; set; }
            public int X { get; set; }
            public int Y { get; set; }
        }

        class Rectangle
        {
            public Rectangle(int x = -1, int y = 1, int width = 6, int height = 2)
            {
                this.X = x;
                this.Y = y;
                this.Width = width;
                this.Height = height;
            }

            public int X { get; set; }
            public int Y { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
        }
    }
}
