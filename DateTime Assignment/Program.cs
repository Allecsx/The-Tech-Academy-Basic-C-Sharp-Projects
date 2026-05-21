using System;

class Program
{
    static void Main(string[] args)
    {
        // Print current date and time
        Console.WriteLine("Current date and time: " + DateTime.Now);

        // Ask user for number of hours
        Console.WriteLine("\nEnter a number of hours to add:");

        // Read input and convert directly to int
        int hours = Convert.ToInt32(Console.ReadLine());

        // Calculate future time and print result
        Console.WriteLine(
            "\nIn " + hours + " hours, the time will be: " +
            DateTime.Now.AddHours(hours)
        );

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}