using System;

namespace MagicYearCalculator
{
    public class MagicYearDTO
    {
        public string name;
        public int monthlySalary;
        public int magicYear;

        public MagicYearDTO(string name, int monthlySalary, int magicYear)
        {
            this.name = name;
            this.monthlySalary = monthlySalary;
            this.magicYear = magicYear;
        }
    }
}