using System;

namespace EmployeeApp
{
    // Employee2 class that stores employee data
    public class Employee2
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        // Overload == operator to compare employees by Id
        public static bool operator ==(Employee2 emp1, Employee2 emp2)
        {
            if (ReferenceEquals(emp1, emp2))
                return true;

            if (emp1 is null || emp2 is null)
                return false;

            return emp1.Id == emp2.Id;
        }

        // Overload != operator (must be paired with ==)
        public static bool operator !=(Employee2 emp1, Employee2 emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals to match == logic
        public override bool Equals(object obj)
        {
            return obj is Employee2 emp && Id == emp.Id;
        }

        // Override GetHashCode when Equals is overridden
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}