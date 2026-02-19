using System; // Provides access to Console and basic system functions

class Program // Defines the main program class
{
    static void Main() // Entry point of the console application
    {
        // Display the required welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // --- GET PACKAGE WEIGHT ---
        // Enter the package weight
        Console.WriteLine("Please enter the package weight:");

        // Read the input and convert it from string to decimal
        decimal weight = Convert.ToDecimal(Console.ReadLine());

        // Check if the package is too heavy (greater than 50)
        if (weight > 50)
        {
            // Display error message if weight exceeds the limit
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

            // End the program immediately
            return;
        }

        // --- GET PACKAGE WIDTH ---
        Console.WriteLine("Please enter the package width:");

        // Read input and convert to decimal
        decimal width = Convert.ToDecimal(Console.ReadLine());

        // --- GET PACKAGE HEIGHT ---
        Console.WriteLine("Please enter the package height:");

        // Read input and convert to decimal
        decimal height = Convert.ToDecimal(Console.ReadLine());

        // --- GET PACKAGE LENGTH ---
        Console.WriteLine("Please enter the package length:");

        // Read input and convert to decimal
        decimal length = Convert.ToDecimal(Console.ReadLine());
        34
        // --- CHECK DIMENSION LIMIT ---
        // Add all dimensions together
        decimal dimensionTotal = width + height + length;

        // If total dimensions exceed 50, the package is too large
        if (dimensionTotal > 50)
        {
            // Display error message
            Console.WriteLine("Package too big to be shipped via Package Express.");

            // End the program immediately
            return;
        }

        // --- CALCULATE SHIPPING QUOTE ---
        // Multiply dimensions together, multiply by weight, then divide by 100
        decimal quote = (width * height * length * weight) / 100;

        // --- DISPLAY RESULT ---
        // Show the quote formatted as a dollar amount (currency)
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote);

        // Prevent the console window from closing immediately
        Console.ReadLine();
    }
}