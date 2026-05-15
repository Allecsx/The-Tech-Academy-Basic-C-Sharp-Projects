using System;

// Create an abstract class called Person1
public abstract class Person1
{
    // Properties to store the person's first name & last name
    public string firstName { get; set; }

    public string lastName { get; set; }

    // Abstract method declaration
    // This method must be implemented in derived classes
    public abstract void SayName();
}