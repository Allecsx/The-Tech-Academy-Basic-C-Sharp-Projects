using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate and initialize an Employee object
        Employee employee = new Employee()
        {
            // Set first name
            FirstName = "Sample",

            // Set last name
            LastName = "Student",

            // Set employee ID
            Id = 1
        };

        // Call inherited method from Person class
        employee.SayName();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}