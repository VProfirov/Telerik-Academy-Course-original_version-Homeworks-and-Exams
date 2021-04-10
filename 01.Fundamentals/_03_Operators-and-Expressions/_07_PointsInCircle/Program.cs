using System;
using System.Text;

namespace _07_PointsInCircle
{
    class Program
    {
        static void Main()
        {
            PointsInCircle_Solution();
        }

        private static void PointsInCircle_Solution()
        {
            Console.WriteLine($"Enter Point's data:");
            Console.Write("Point.X: ");
            var userInput_PointX = Console.ReadLine();
            var isValidInput_PointX = double.TryParse(userInput_PointX, out double pointX);
            Console.Write("Point.Y: ");
            var userInput_PointY = Console.ReadLine();
            var isValidInput_PointY = double.TryParse(userInput_PointY, out double pointY);
            var log = new StringBuilder();
            log.AppendLine(isValidInput_PointX && isValidInput_PointY ? "Valid input for both X and Y" : $"Wrong Input for one/both of the Points: Point.X({userInput_PointX}) Point.Y({userInput_PointY})");

            var point = new Point_2D(pointX, pointY);
            var circle = new Circle();

            var msg_result = $"{(point.CheckInsideCircle(circle) ? "yes" : "no")} {point.FindDistanceToCenter():F2}";
            Console.WriteLine(msg_result);
        }

        class Point_2D
        {
            public Point_2D(double x, double y)
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
            public double FindDistanceToCenter()
            {
                return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            }

        }

        class Circle
        {
            public Circle(double x = 0, double y = 0, double radius = 2)
            {
                this.X = x;
                this.Y = y;
                this.Radius = radius;
            }

            public double Radius { get; set; }
            public double X { get; set; }
            public double Y { get; set; }
        }
    }
}
