using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate and initialize an Employee1 object
        Employee1 employee = new Employee1()
        {

            firstName = "Sample",

            lastName = "Student"
        };

        // Call the implemented SayName method
        employee.SayName();

        // ---------------------------------------
        // POLYMORPHISM
        // ---------------------------------------

        // Create object of interface type IQuittable
        IQuittable quittablePerson = employee;

        // Call interface method
        quittablePerson.Quit();

        // Keep console window open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}