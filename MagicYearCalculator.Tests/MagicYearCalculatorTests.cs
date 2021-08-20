using System;
using Xunit;
using MagicYearCalculator;

namespace MagicYearCalculator.Tests
{
    public class MagicYearCalculatorTests
    {
        [Fact]
        public void given_inputsProvided_when_ProcessDetails_then_return_expectedMagicYearDTO()
        {

            MagicYearCalculator calculator = new MagicYearCalculator();
            
            string firstName = "Mark";
            string surname = "Boyle";
            int annualSalary = 65000;
            int startYear = 2021;

            MagicYearDTO calculatorOutput = calculator.ProcessDetails(firstName, surname, annualSalary, startYear);

            string name = "Mark Boyle";
            int monthlySalary = 5417;
            int magicYear = 2086;

            MagicYearDTO expectedMagicYearDTO = new MagicYearDTO(name, monthlySalary, magicYear);

            Assert.Equal(expectedMagicYearDTO.name, calculatorOutput.name);
            Assert.Equal(expectedMagicYearDTO.monthlySalary, calculatorOutput.monthlySalary);
            Assert.Equal(expectedMagicYearDTO.magicYear, calculatorOutput.magicYear);

        }
    }
}


//Given/When/Then

//Prompt input

//Pass details to magic year calcualtor  **Given

//Process details  ** When

//Pass details to output  **Then

//Output to the console