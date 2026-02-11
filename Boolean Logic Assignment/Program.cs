using System; // Gives access to basic system functions like Console

class Program // Defines the Program class
{
    static void Main() // Entry point of the console application
    {
        Console.WriteLine("Welcome to the Car Insurance Qualification Program!"); // Title

        // Enter the age
        Console.WriteLine("What is your age?");

        // Read the input and convert to integer
        int age = Convert.ToInt32(Console.ReadLine());

        // Ask the user if they had a DUI
        Console.WriteLine("Have you ever had a DUI? (true/false)");

        // Read the input and convert to boolean
        bool hasDUI = Convert.ToBoolean(Console.ReadLine());

        // Ask the user how many speeding tickets they have
        Console.WriteLine("How many speeding tickets do you have?");

        // Read the input and convert to integer
        int speedingTickets = Convert.ToInt32(Console.ReadLine());

        // Create a boolean variable that checks all qualification rules:
        // 1. Age must be over 15
        // 2. Applicant must NOT have a DUI
        // 3. Applicant must have 3 or fewer speeding tickets
        bool qualified = (age > 15) && (hasDUI == false) && (speedingTickets <= 3);

        // Display the result of the boolean expression
        // This will print either True or False
        Console.WriteLine("Qualified for car insurance: " + qualified);

        // Prevent the console window from closing immediately
        Console.ReadLine();
    }
}