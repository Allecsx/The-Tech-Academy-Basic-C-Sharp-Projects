using System;

// Employee1 class inherits from the abstract Person1 class
public class Employee1 : Person1
{
    // Implement the abstract SayName method
    public override void SayName()
    {
        // Display the employee's full name
        Console.WriteLine("Name: " + firstName + " " + lastName);
    }
}