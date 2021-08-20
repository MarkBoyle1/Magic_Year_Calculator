using System;

namespace MagicYearCalculator
{
    public class Output
    {
        public void DisplayOnConsole(string name, int monthlySalary, int magicYear)
        {
            Console.WriteLine("Your magic details are:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Monthly Salary: " + monthlySalary);
            Console.WriteLine("Magic Year: " + magicYear);
        }
    }
}
