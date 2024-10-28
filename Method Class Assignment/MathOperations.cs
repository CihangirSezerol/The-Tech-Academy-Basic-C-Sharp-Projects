using System;

namespace Method_Class_Assignment
{
    public class MathOperations
    {
        public void PerformOperation(int num1, int num2)
        {
            // Perform a math operation on the first integer (add 1 to it)
            var result = num1 + 1;

            // Display the result of the operation
            Console.WriteLine($"The result of adding 1 to {num1} is: {result}");

            // Display the second integer
            Console.WriteLine($"The second integer is: {num2}");
        }
    }
}
