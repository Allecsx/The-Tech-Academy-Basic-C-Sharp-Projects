using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Ask the user for a whole number
            Console.WriteLine("Enter a whole number:");

            // Convert user input to integer
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Variable that will receive the output value
            int dividedResult;

            // Call reusable method
            MathOperations1.DivideByTwo(userNumber, out dividedResult);

            // Display result outside the method
            Console.WriteLine(userNumber + " divided by 2 is: " + dividedResult);

            // --------------------------------------------------
            // OVERLOADED METHOD EXAMPLE
            // --------------------------------------------------

            // Ask the user for a decimal number
            Console.WriteLine("\nEnter a decimal number:");

            // Convert input to double
            double decimalNumber = Convert.ToDouble(Console.ReadLine());

            // Variable for double result
            double decimalResult;

            // Call overloaded method
            MathOperations1.DivideByTwo(decimalNumber, out decimalResult);

            // Display result
            Console.WriteLine(decimalNumber + " divided by 2 is: " + decimalResult);
        }
        catch (FormatException)
        {
            // Handles invalid user input
            Console.WriteLine("Please enter a valid numeric value.");
        }

        // Message showing program continues normally
        Console.WriteLine("\nProgram execution completed.");

        // Keep console open
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}