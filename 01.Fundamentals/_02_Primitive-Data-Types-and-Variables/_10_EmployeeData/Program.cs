using System;

namespace _10_EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default_Data
            var firstName = "Pesho";
            var lastName = "Peshev";
            var age = 30;
            var gender = "m";
            Random someRandomGen = new Random();
            // add a "guaranteed" factor to the random.gen (like time ticks or something better)
            var personalID = someRandomGen.Next(10000,99999).ToString();
            var employeeID = $"{someRandomGen.Next(1000, 9999)}{someRandomGen.Next(1000, 9999)}";
            #endregion
            
            #region Logging
            Console.WriteLine($"PERSONAL ID: {personalID}");
            Console.WriteLine($"EMPLOYEE ID: {employeeID}");
            #endregion
        }
    }
}