using System; 
using System.Collections.Generic; // Allows us to use Lists

class Program 
{
    static void Main(string[] args) 
    {
        // -------------------------------
        // STRING ARRAY SECTION
        // -------------------------------

        // Create a one-dimensional array of strings
        string[] stringArray = { "Apple", "Banana", "Cherry", "Blueberry", "Watermelon" };

        // Ask the user to select an index
        Console.WriteLine("Select an index for the string array (0 - 4):");

        // Convert it to an integer
        int stringIndex = Convert.ToInt32(Console.ReadLine());

        // Check if the index is valid
        if (stringIndex >= 0 && stringIndex < stringArray.Length)
        {
            // Display the string at the selected index
            Console.WriteLine("You selected: " + stringArray[stringIndex]);
        }
        else
        {
            // Display error message if index is out of range
            Console.WriteLine("Error: That index does not exist in the string array.");
        }

        // -------------------------------
        // INTEGER ARRAY SECTION
        // -------------------------------

        // Create a one-dimensional array of integers
        int[] intArray = { 10, 20, 30, 40, 50 };

        // Ask the user to select an index
        Console.WriteLine("\nSelect an index for the integer array (0 - 4):");

        // Convert it to an integer
        int intIndex = Convert.ToInt32(Console.ReadLine());

        // Check if the index is valid
        if (intIndex >= 0 && intIndex < intArray.Length)
        {
            // Display the integer at the selected index
            Console.WriteLine("You selected: " + intArray[intIndex]);
        }
        else
        {
            // Display error message if index is out of range
            Console.WriteLine("Error: That index does not exist in the integer array.");
        }

        // -------------------------------
        // LIST SECTION
        // -------------------------------

        // A list of strings
        List<string> stringList = new List<string>()
        {
            "Red", "Blue", "Green", "Yellow", "Purple"
        };

        // Ask the user to select an index
        Console.WriteLine("\nSelect an index for the string list (0 - 4):");

        // Convert it to an integer
        int listIndex = Convert.ToInt32(Console.ReadLine());

        // Check if the index is valid
        if (listIndex >= 0 && listIndex < stringList.Count)
        {
            // Display the string at the selected index
            Console.WriteLine("You selected: " + stringList[listIndex]);
        }
        else
        {
            // Display error message if index is out of range
            Console.WriteLine("Error: That index does not exist in the list.");
        }

        // Keep the console window open until user presses a key
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}