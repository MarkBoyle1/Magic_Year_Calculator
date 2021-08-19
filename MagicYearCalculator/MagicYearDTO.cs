using System;

namespace MagicYearCalculator
{
    public class MagicYearDTO
    {
        public string name;
        public string monthlySalary;
        public string magicYear;

        public MagicYearDTO(string name, string monthlySalary, string magicYear)
        {
            this.name = name;
            this.monthlySalary = monthlySalary;
            this.magicYear = magicYear;
        }
    }
}