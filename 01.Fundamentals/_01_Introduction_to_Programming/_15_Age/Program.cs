using System;
using System.Globalization;

namespace _15_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            var userinput_DateOfBirth = "11.30.2000";
            var userDateOfBirth = DateTime.Parse(userinput_DateOfBirth);
            var today = DateTime.Now;
           
            var age = today.Year - userDateOfBirth.Year;
            // Accounting for leap years, on the day, a day before and after checks
            if (userDateOfBirth.Date > today.AddYears(-age).Date) age--;
            
            Console.WriteLine($"User's age: {age}");
            Console.WriteLine($"User's age after 10 years {age + 10}");
         
            // Console.WriteLine($"{userDateOfBirth.ToString("MMM-dd-yyyy",CultureInfo.InvariantCulture)}");
        }
    }
}