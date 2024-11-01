﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the first Employee object and assign values to its properties.
            Employee employee1 = new Employee
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };

            // Instantiate the second Employee object and assign values to its properties.
            Employee employee2 = new Employee
            {
                Id = 1,
                FirstName = "Jane",
                LastName = "Doe"
            };

            // Compare the two Employee objects using the overloaded '==' operator.
            if (employee1 == employee2)
            {
                Console.WriteLine("Both employees are considered equal based on their Id.");
            }
            else
            {
                Console.WriteLine("The employees are not equal based on their Id.");
            }

            // Compare the two Employee objects using the overloaded '!=' operator.
            if (employee1 != employee2)
            {
                Console.WriteLine("The employees are considered different based on their Id.");
            }
            else
            {
                Console.WriteLine("Both employees are considered the same based on their Id.");
            }

            // Keep the console window open until the user presses Enter.
            Console.ReadLine();
        }
    }
}
