using System;

namespace OperatorsAssignment
{
    // Employee class represents an employee object
    public class Employee
    {
        // Property to store employee Id
        public int Id { get; set; }

        // Property to store employee first name
        public string FirstName { get; set; }

        // Property to store employee last name
        public string LastName { get; set; }

        // Overloading the == operator
        // This checks if two Employee objects are equal
        // by comparing their Id values
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both objects are null, return true
            if (ReferenceEquals(emp1, emp2))
            {
                return true;
            }

            // If one object is null and the other is not, return false
            if (emp1 is null || emp2 is null)
            {
                return false;
            }

            // Compare the Id properties
            return emp1.Id == emp2.Id;
        }

        // Overloading the != operator
        // This checks if two Employee objects are not equal
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Return the opposite result of ==
            return !(emp1 == emp2);
        }

        // Override Equals method for consistency
        public override bool Equals(object obj)
        {
            // Check if obj is an Employee object
            if (obj is Employee employee)
            {
                // Compare Id values
                return this.Id == employee.Id;
            }

            return false;
        }

        // Override GetHashCode method
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}