using System;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main()
        {
            // Title
            Console.WriteLine("Anonymous Income Comparison Program");

            // ----- PERSON 1 -----

            // Person 1
            Console.WriteLine("Person 1");

            // Person 1's hourly rate
            Console.WriteLine("Hourly Rate:");
            decimal person1HourlyRate = Convert.ToDecimal(Console.ReadLine());

            // Person 1's hours worked per week
            Console.WriteLine("Hours worked per week:");
            decimal person1HoursPerWeek = Convert.ToDecimal(Console.ReadLine());

            // Calculate Person 1's annual salary (52 weeks)
            decimal person1AnnualSalary = person1HourlyRate * person1HoursPerWeek * 52;


            // ----- PERSON 2 -----

            // Person 2
            Console.WriteLine("Person 2");

            // Person 2's hourly rate
            Console.WriteLine("Hourly Rate:");
            decimal person2HourlyRate = Convert.ToDecimal(Console.ReadLine());

            // Person 2's hours worked per week
            Console.WriteLine("Hours worked per week:");
            decimal person2HoursPerWeek = Convert.ToDecimal(Console.ReadLine());

            // Calculate Person 2's annual salary (52 weeks)
            decimal person2AnnualSalary = person2HourlyRate * person2HoursPerWeek * 52;


            // ----- RESULTS -----

            // Print Person 1's annual salary label
            Console.WriteLine("Annual salary of Person 1:");

            // Print Person 1's exact annual salary
            Console.WriteLine(person1AnnualSalary);

            // Print Person 2's annual salary label
            Console.WriteLine("Annual salary of Person 2:");

            // Print Person 2's exact annual salary
            Console.WriteLine(person2AnnualSalary);

            // Compare the two salaries and store the result as a boolean
            bool person1MakesMore = person1AnnualSalary > person2AnnualSalary;

            // Print comparison statement
            Console.WriteLine("Person 1 makes more money than Person 2");

            // Print true or false result
            Console.WriteLine(person1MakesMore);
        }
    }
}