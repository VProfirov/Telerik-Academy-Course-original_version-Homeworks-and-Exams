using System;
using System.Reflection.Emit;
using System.Text;

namespace _04_Rectangles
{
    class Program
    {
        static void Main()
        {
            Rectangles_Solution();
        }

        static void Rectangles_Solution()
        {
            Console.WriteLine($"Enter the HEIGHT and WIDTH of your RECTANGLE to calculate its AREA and PERIMETER: ");
            Console.Write($"WIDTH: ");
            var userInput_width = Console.ReadLine();
            Console.Write($"HEIGHT: ");
            var userInput_height = Console.ReadLine();

            var sb_log = new StringBuilder();
            var isValidInput = double.TryParse(userInput_width, out double width);
            var logValidityOfUserInput_width = isValidInput ? $"The user's input about width({width}) is valid" : $"User's input about width ({userInput_width} is invalid! Use double, int,etc...";
            sb_log.AppendLine(logValidityOfUserInput_width);
            isValidInput = double.TryParse(userInput_height, out double height);
            var logValidityOfUserInput_height = isValidInput ? $"The user's input about height({height}) is valid" : $"User's input about width ({userInput_height} is invalid! Use double, int,etc...";
            sb_log.AppendLine(logValidityOfUserInput_height);

            static void ValidityCheck(bool isValidInput)
            {
                if (!isValidInput)
                {
                    Console.WriteLine($"You entered invalid input! Try again");
                    Main();
                }
            }
            ValidityCheck(isValidInput);

            var rectangle = new Rectangle(width, height);
            var rectangleArea = rectangle.CalculateArea();
            var rectangelPerimeter = rectangle.CalculatePerimeter();

            Console.WriteLine($"Rectangle AREA: {rectangleArea:F2}");
            Console.WriteLine($"Rectangle PERIMETER: {rectangelPerimeter:F2}");
        }

        class Rectangle
        {
            public Rectangle(double width, double height)
            {
                this.Width = width;
                this.Height = height;
            }

            public double Width { get; set; }
            public double Height { get; set; }

            public double CalculateArea()
            {
                return Width * Height;
            }

            public double CalculatePerimeter()
            {
                return (Width + Height) * 2;
            }
        }
    }
}
