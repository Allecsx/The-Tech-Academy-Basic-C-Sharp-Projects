using System;
using System.Collections.Generic;

// Created a generic Employee1 class
// <T> represents a generic type parameter
public class Employee1<T>
{
    // Created a property called Things
    // Its type is a generic list matching type T
    public List<T> Things { get; set; }
}
