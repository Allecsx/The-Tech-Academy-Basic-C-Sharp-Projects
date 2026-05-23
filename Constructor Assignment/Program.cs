using System;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a const variable
            const string Header = "=====================================";

            // Display a welcome screen
            Console.WriteLine(Header);
            Console.WriteLine("        WELCOME TO THE APP           ");
            Console.WriteLine(Header);
            Console.WriteLine(); // Prints an empty line for better spacing

            // Ask the user for input
            Console.Write("Please enter your name: ");

            // 2. Create a variable using "var" keyword to read input
            var inputName = Console.ReadLine();

            // 3. Chain constructors by calling the 1-parameter constructor
            Person user = new Person(inputName);

            // Display the final output with spaced layout
            Console.WriteLine();
            Console.WriteLine(Header);
            Console.WriteLine($"-> Success! Created profile for: {user.Name}");
            Console.WriteLine($"-> Default age assigned: {user.Age} years old");
            Console.WriteLine(Header);

            // Pause the screen beautifully at the end
            Console.WriteLine("\nPress Enter to close the application...");
            Console.ReadLine();
        }
    }
}