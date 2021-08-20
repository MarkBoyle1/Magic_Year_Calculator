using System;
using System.Linq;
using System.Collections.Generic;

namespace MagicYearCalculator
{
    public class MagicYearCalculator
    {
        public MagicYearDTO ProcessDetails(string firstName, string surname, int annualSalary, int startYear)
        {
            string name = formatName(firstName, surname);
            int monthlySalary = calculateMonthlySalary(annualSalary);
            int magicYear = calculateMagicYear(startYear);
            return new MagicYearDTO(name, monthlySalary, magicYear);
        }

        private string formatName(string firstName, string surname)
        {
            string name = firstName + " " + surname;
            return name;
        }

        private int calculateMonthlySalary(int annualSalary)
        {
            decimal monthlySalary = Math.Round((Convert.ToDecimal(annualSalary) / 12m), MidpointRounding.AwayFromZero);
            return Convert.ToInt32(monthlySalary);
        }

        private int calculateMagicYear(int startYear)
        {
            int magicYear = startYear + 65;
            return magicYear;
        }
    }
}