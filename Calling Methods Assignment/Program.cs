using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for a number
        Console.WriteLine("Enter a number to perform math operations on:");

        // Read user input and convert it to an integer
        int userNumber = Convert.ToInt32(Console.ReadLine());

        // Create an instance of the MathOperations class
        MathOperations math = new MathOperations();

        // Call each method and store results
        int result1 = math.AddTen(userNumber);
        int result2 = math.MultiplyByTwo(userNumber);
        int result3 = math.SubtractFive(userNumber);

        // Display results to the user
        Console.WriteLine("Result after adding 10: " + result1);
        Console.WriteLine("Result after multiplying by 2: " + result2);
        Console.WriteLine("Result after subtracting 5: " + result3);

        // Keep console open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}