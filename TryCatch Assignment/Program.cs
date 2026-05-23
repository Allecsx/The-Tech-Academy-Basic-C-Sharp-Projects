using System;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Ask user for age
                Console.WriteLine("Please enter your age:");
                int age = Convert.ToInt32(Console.ReadLine());

                // Check for invalid input (zero or negative)
                if (age <= 0)
                {
                    throw new ArgumentException("Age must be greater than zero.");
                }

                // Calculate birth year
                int currentYear = DateTime.Now.Year;
                int birthYear = currentYear - age;

                // Display result
                Console.WriteLine("You were born in: " + birthYear);
            }
            catch (FormatException)
            {
                // Handles non-numeric input
                Console.WriteLine("Error: Please enter a valid number.");
            }
            catch (ArgumentException ex)
            {
                // Handles negative or zero age
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception)
            {
                // Handles any other unexpected errors
                Console.WriteLine("An unexpected error occurred.");
            }

            // End message (always runs)
            Console.WriteLine("Program has finished. Press any key to exit.");
            Console.ReadKey();
        }
    }
}