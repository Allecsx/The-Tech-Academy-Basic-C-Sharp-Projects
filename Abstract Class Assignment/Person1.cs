using System;

// Create an abstract class called Person1
public abstract class Person1
{
    // Property to store the person's first name
    public string firstName { get; set; }

    // Property to store the person's last name
    public string lastName { get; set; }

    // Abstract method declaration
    // This method must be implemented in derived classes
    public abstract void SayName();
}