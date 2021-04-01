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
            //KISS Principle is completely disregarded for the task
            Console.WriteLine($"Enter the HEIGHT and WIDTH of your RECTANGLE to calculate its AREA and PERIMETER: ");
            Console.Write($"WIDTH: ");
            var userInput_width = Console.ReadLine();
            Console.Write($"HEIGHT: ");
            var userInput_height = Console.ReadLine();

            var sb_log = new StringBuilder();
            var isValidInput_width = double.TryParse(userInput_width, out double width);
            var logValidityOfUserInput_width = isValidInput_width ? $"The user's input about width({width}) is valid!" : $"User's input about width({userInput_width}) is invalid! Use double, int,etc...";
            sb_log.AppendLine(logValidityOfUserInput_width);
            var isValidInput_height = double.TryParse(userInput_height, out double height);
            var logValidityOfUserInput_height = isValidInput_height ? $"The user's input about height({height}) is valid!" : $"User's input about height({userInput_height}) is invalid! Use double, int,etc...";
            sb_log.AppendLine(logValidityOfUserInput_height);
            var log = sb_log.ToString();
            var isValidInput = isValidInput_width && isValidInput_height;

            #region interactivity
            // NOTE: This is kind of overdoing it, but it shows inner-functionality encapsulation, fallowed by condition bringing interactivity!
            static void ValidityCheck(bool isValidInput,string log)
            {
                if (!isValidInput)
                {
                    Console.WriteLine($"---LOG---\r\n{log}\r\n---------");
                    Console.WriteLine($"You entered invalid input! Try again");
                }
            }
            if(!isValidInput)
            {
                // NOTE: This is another example of HOW NOT TO DO something.
                // Here we create recursive call into the Main() method and with each call we instantiate new variables and save space for them in the RAM!
                // Meanwhile, the old variables and their data are kept in the RAM! Even, if we meant to make a retry of the task, we are not reseting the task itself!
                // NOTE: How it could have been done:
                // 1. We could initialize/start another/new instance of the exact same application and close the current one. (This is the preferred way for larger and more complex applications)
                // 2. User the "goto" flow-control keyword with a label (like: goto Begining) and place the label at the start of the block code of the method Rectangles_Solution()
                // 3. There are other ways ;) And they mostly depend on the resources the application handles.
                ValidityCheck(isValidInput, log);
                Main();
                return;
            }
            #endregion

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
