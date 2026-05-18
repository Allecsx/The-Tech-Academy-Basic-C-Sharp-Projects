using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // ---------------------------------------
        // EMPLOYEE OBJECT USING STRING  & INT TYPE
        // ---------------------------------------

        // Instantiate Employee1 object with generic type string
        Employee1<string> stringEmployee = new Employee1<string>();

        // Assign list of strings to Things property
        stringEmployee.Things = new List<string>()
            {"Laptop","Keyboard","Mouse","Monitor"};


        // Instantiate Employee1 object with generic type int
        Employee1<int> intEmployee = new Employee1<int>();

        // Assign list of integers to Things property
        intEmployee.Things = new List<int>()
        { 10, 20, 30, 40 };

        // ---------------------------------------
        // PRINT STRING & INTEGER LIST ITEMS
        // ---------------------------------------

        Console.WriteLine("String Employee Things:");

        // Loop through all string items
        foreach (string item in stringEmployee.Things)
        {
            Console.WriteLine(item);
        }


        Console.WriteLine("\nInteger Employee Things:");

        // Loop through all integer items
        foreach (int item in intEmployee.Things)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}