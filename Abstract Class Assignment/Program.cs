using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate and initialize an Employee1 object
        Employee1 employee = new Employee1()
        {
            // Set first name
            firstName = "Sample",

            // Set last name
            lastName = "Student"
        };

        // Call the implemented SayName method
        employee.SayName();

        // Keep console window open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}