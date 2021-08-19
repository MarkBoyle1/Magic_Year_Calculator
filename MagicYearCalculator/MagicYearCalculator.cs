using System;
using System.Linq;
using System.Collections.Generic;

namespace MagicYearCalculator
{
    public class MagicYearCalculator
    {
        public MagicYearDTO ProcessDetails(string firstName, string surname, string annualSalary, string startYear)
        {
            string name = formatName(firstName, surname);
            string monthlySalary = calculateMonthlySalary(annualSalary);
            string magicYear = calculateMagicYear(startYear);
            return new MagicYearDTO(name, monthlySalary, magicYear);
        }

        private string formatName(string firstName, string surname)
        {
            string name = firstName + " " + surname;
            return name;
        }

        private string calculateMonthlySalary(string annualSalary)
        {
            string monthlySalary = (Convert.ToInt32(annualSalary) / 12).ToString();
            return monthlySalary;
        }

        private string calculateMagicYear(string startYear)
        {
            string magicYear = (Convert.ToInt32(startYear) + 65).ToString();
            return magicYear;
        }
    }
}