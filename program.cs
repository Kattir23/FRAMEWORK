using System;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first Employee object
            Employee employee1 = new Employee()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Smith"
            };

            // Create the second Employee object
            Employee employee2 = new Employee()
            {
                Id = 1,
                FirstName = "Jane",
                LastName = "Doe"
            };

            // Compare the two Employee objects using the overloaded == operator
            bool areEqual = employee1 == employee2;

            // Display the comparison result
            Console.WriteLine("Are the employees equal? " + areEqual);

            // Compare the two Employee objects using the overloaded != operator
            bool areNotEqual = employee1 != employee2;

            // Display the comparison result
            Console.WriteLine("Are the employees not equal? " + areNotEqual);

            // Keep console window open
            Console.ReadLine();
        }
    }
}
