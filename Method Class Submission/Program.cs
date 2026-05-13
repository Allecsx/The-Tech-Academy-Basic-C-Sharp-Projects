using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the MathOperations class
        MathOperations math = new MathOperations();

        // ---------------------------------------
        // CALL METHOD USING POSITIONAL PARAMETERS
        // ---------------------------------------

        // Pass two integers in order
        math.DisplayNumbers(10, 20);

        // ---------------------------------------
        // CALL METHOD USING NAMED PARAMETERS
        // ---------------------------------------

        // Pass parameters by naming them
        math.DisplayNumbers(num1: 5, num2: 15);

        // Keep console open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}