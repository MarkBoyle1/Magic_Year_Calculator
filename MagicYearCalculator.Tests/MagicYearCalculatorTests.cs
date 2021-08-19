using System;
using Xunit;
using MagicYearCalculator;

namespace MagicYearCalculator.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            MagicYearCalculator calculator = new MagicYearCalculator();
            
            string firstName = "Mark";
            string surname = "Boyle";
            string annualSalary = "65000";
            string startYear = "2021";

            MagicYearDTO output = calculator.ProcessDetails(firstName, surname, annualSalary, startYear);

            string name = "Mark Boyle";
            string monthlySalary = "5416";
            string magicYear = "2086";

            MagicYearDTO expectedMagicYearDTO = new MagicYearDTO(name, monthlySalary, magicYear);

            Assert.Equal(expectedMagicYearDTO.name, output.name);
            Assert.Equal(expectedMagicYearDTO.monthlySalary, output.monthlySalary);
            Assert.Equal(expectedMagicYearDTO.magicYear, output.magicYear);

        }
    }
}


//Given/When/Then

//Prompt input

//Pass details to magic year calcualtor  **Given

//Process details  ** When

//Pass details to output  **Then

//Output to the console