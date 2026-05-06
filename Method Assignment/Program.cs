using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the MathOperations class
        MathOperations math = new MathOperations();

        // Ask the user for the first number
        Console.WriteLine("Enter the first number:");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        // Ask the user for the second number (optional)
        Console.WriteLine("Enter the second number (or press Enter to skip):");
        string secondInput = Console.ReadLine();

        int result;

        // Check if the user entered a second number
        if (string.IsNullOrWhiteSpace(secondInput))
        {
            // If no second number is entered, call method with one parameter
            // The default value (5) will be used
            result = math.AddNumbers(firstNumber);
        }
        else
        {
            // If a second number is provided, convert it to int
            int secondNumber = Convert.ToInt32(secondInput);

            // Call method with both parameters
            result = math.AddNumbers(firstNumber, secondNumber);
        }

        // Display the result
        Console.WriteLine("Result: " + result);

        // Keep console open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}