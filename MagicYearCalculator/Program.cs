using System;

namespace MagicYearCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Input userInput = new Input();
            MagicYearCalculator magicYearCalculator = new MagicYearCalculator();

            MagicYearDTO magicYearDTO = magicYearCalculator.ProcessDetails(userInput.firstName, userInput.surname, userInput.annualSalary, userInput.startYear);
            Output consoleOutput = new Output();
            consoleOutput.DisplayOnConsole(magicYearDTO.name, magicYearDTO.monthlySalary, magicYearDTO.magicYear);
        }
    }
}
