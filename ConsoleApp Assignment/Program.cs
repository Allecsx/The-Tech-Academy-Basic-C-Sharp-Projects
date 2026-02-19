using System; // Allows use of Console
class Program // Defines the main program class
{
    static void Main() // Entry point of the application
    {

        // WHILE LOOP WITH BOOLEAN COMPARISON
        // Initialize a counter variable
        int count = 0;

        // This loop will run while count is less than 5
        while (count < 5)
        {
            // Display the current value of count
            Console.WriteLine("While loop: " + count);

            // Add 1 to the count
            count++;
        }


        // DO-WHILE LOOP WITH BOOLEAN COMPARISON
        // Initialize a 2nd counter variable

        int number = 0;

        // The do-while loop runs the code block first,
        // then checks the boolean condition
        do
        {
            // Display the current value of number
            Console.WriteLine("Do-while loop: " + number);

            // Add 1 to the count
            number++;

        } while (number < 5); // Continue looping while this condition is true


        // Pause the program so the console window stays open
        Console.ReadLine();
    }
}