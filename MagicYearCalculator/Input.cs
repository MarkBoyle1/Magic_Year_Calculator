using System;

namespace MagicYearCalculator
{
    public class Input
    {
        public string firstName;
        public string surname;
        public string annualSalary;
        public string startYear;

        public Input()
        {
            this.firstName = CollectStringInput("first name");
            this.surname = CollectStringInput("surname");
            this.annualSalary = CollectNumberInput("annual salary");
            this.startYear = CollectNumberInput("start year");
        }

        private string CollectStringInput(string inputCategory)
        {
            Console.WriteLine($"Please enter your {inputCategory}:");
            string answer = Console.ReadLine();
            while(String.IsNullOrWhiteSpace(answer))
            {
                Console.WriteLine($"Please enter your {inputCategory}:");
                answer = Console.ReadLine();
            }
            return answer;
        }

        private string CollectNumberInput(string inputCategory)
        {
            Console.WriteLine($"Please enter your {inputCategory}:");
            int number;
            string answer = Console.ReadLine();
            while(!int.TryParse(answer, out number))
            {
                Console.WriteLine("Please enter a valid number:");
                answer = Console.ReadLine();
            }
            return answer;
        }
    }
}