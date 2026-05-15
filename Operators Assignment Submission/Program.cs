using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create first Employee2 object
            Employee2 emp1 = new Employee2
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };

            // Create second Employee2 object
            Employee2 emp2 = new Employee2
            {
                Id = 1,
                FirstName = "Jane",
                LastName = "Smith"
            };

            // Compare the two employees using overloaded ==
            bool areEqual = emp1 == emp2;

            // Print result to console
            Console.WriteLine(areEqual);

            Console.ReadLine();
        }
    }
}