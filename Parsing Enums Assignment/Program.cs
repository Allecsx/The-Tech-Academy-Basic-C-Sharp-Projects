using System;

// Create an enum for the days of the week
public enum DaysOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Ask the user to enter the current day
            Console.WriteLine("Enter the current day of the week:");

            // Read user input
            string userInput = Console.ReadLine();

            // Parse the string input into the enum type
            // Ignore case sensitivity by using 'true'
            DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);

            // Display the parsed enum value
            Console.WriteLine("Today is: " + currentDay);
        }
        catch
        {
            // Display message if parsing fails
            Console.WriteLine("Please enter an actual day of the week.");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
