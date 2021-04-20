using System;

namespace _10_PointCircleRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Point INSIDE Circle && OUTSIDE Rectangle check!
            PointCircleRectangle_Solution();
        }

        static void PointCircleRectangle_Solution()
        {
            Console.WriteLine("Enter the coordinates X and Y for the point:");
            Console.Write("X: ");
            var isValidInputX = double.TryParse(Console.ReadLine(), out double pointX);
            Console.Write("Y: ");
            var isValidInputY = double.TryParse(Console.ReadLine(), out double pointY);

            var point = new Point(pointX, pointY);
            var circle = new Circle();
            var rectangle = new Rectangle();

            Console.WriteLine($"{(point.CheckInsideCircle(circle) ? "inside" : "outside")} circle {(point.CheckOutsideRectangle(rectangle) ? "outside" : "inside")} rectangle");

            // Testing work with Tuples :=> don't use!
            // var isInsideCircleOutsideRectangle = (insideCircle: point.CheckInsideCircle(circle), outsideRectangle: point.CheckOutsideRectangle(rectangle));
            // Console.WriteLine($"{(isInsideCircleOutsideRectangle.insideCircle ? "inside" : "outside")} circle {(isInsideCircleOutsideRectangle.outsideRectangle ? "outside" : "inside")} rectangle");
        }

        class Point
        {
            public Point(double x, double y)
            {
                this.X = x;
                this.Y = y;
            }
            public double X { get; set; }
            public double Y { get; set; }
            public bool CheckInsideCircle(Circle circle)
            {
                return Math.Pow((X - circle.X), 2) + Math.Pow((Y - circle.Y), 2) <= Math.Pow(circle.Radius, 2);
            }
            public bool CheckOutsideRectangle(Rectangle rectangle)
            {
                // Reversing an inside check
                return !(rectangle.TopSide >= Y && rectangle.LeftSide <= X && rectangle.BottomSide <= Y && rectangle.RightSide >= X);
            }
            public double FindDistanceToCenter()
            {
                return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            }

        }
        class Circle
        {
            public Circle(double x = 1, double y = 1, double radius = 1.5)
            {
                this.X = x;
                this.Y = y;
                this.Radius = radius;
            }

            public double Radius { get; set; }
            public double X { get; set; }
            public double Y { get; set; }
        }

        class Rectangle
        {
            public Rectangle(double x = -1, double y = 1, double width = 6, double height = 2)
            {
                this.X = x;
                this.Y = y;
                this.Width = width;
                this.Height = height;
            }

            // X & Y are the coordinates for the top-left corner
            public double X { get; set; }
            public double Y { get; set; }
            public double Width { get; set; }
            public double Height { get; set; }
            // Horizontal limits
            public double LeftSide { get { return this.X; } }
            public double RightSide { get { return this.X + this.Width; } }
            // Vertical limits
            public double TopSide { get { return this.Y; } }
            public double BottomSide { get { return this.Y - this.Height; } }
        }
    }
}
