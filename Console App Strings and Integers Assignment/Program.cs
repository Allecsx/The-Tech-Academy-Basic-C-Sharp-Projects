using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of integers
        List<int> numbers = new List<int>() { 10, 20, 30, 40, 50 };

        try
        {
            // Ask the user for a number to divide by
            Console.WriteLine("Enter a number to divide each number in the list by:");

            // Read user input and convert it to an integer
            int divisor = int.Parse(Console.ReadLine());

            // Loop through each number in the list
            foreach (int num in numbers)
            {
                // Divide each number by the user input
                int result = num / divisor;

                // Display the result
                Console.WriteLine(num + " / " + divisor + " = " + result);
            }
        }
        catch (DivideByZeroException)
        {
            // Handles division by zero error
            Console.WriteLine("Error: You cannot divide by zero.");
        }
        catch (FormatException)
        {
            // Handles invalid input (e.g., user enters text instead of number)
            Console.WriteLine("Error: Please enter a valid number.");
        }

        // This message shows that the program continues after try/catch
        Console.WriteLine("\nProgram has continued after the try/catch block.");

        // Keep console open
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}