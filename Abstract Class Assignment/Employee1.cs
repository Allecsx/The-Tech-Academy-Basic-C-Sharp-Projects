using System;

// Employee1 class inherits Person1 class and implements IQuittable interface
public class Employee1 : Person1, IQuittable
{
    // Implement the abstract SayName method
    public override void SayName()
    {
        // Display the employee's full name
        Console.WriteLine("Name: " + firstName + " " + lastName);
    }

    // Implement the Quit method from the interface
    public void Quit()
    {
        // Display quit message
        Console.WriteLine(firstName + " has quit the job.");
    }
}