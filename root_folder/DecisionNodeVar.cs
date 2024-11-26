using System;

class Calculator
{
    static void PerformOperation(string operation, double num1, double num2)
    {
        if (operation == "add")
        {
            // Variable declaration inside if condition
            double result = num1 + num2;
            Console.WriteLine($"Addition result: {result}");
        }
        else if (operation == "subtract")
        {
            // Variable declaration inside else if condition
            double result = num1 - num2;
            Console.WriteLine($"Subtraction result: {result}");
        }
        else if (operation == "multiply")
        {
            // Another variable declaration inside else if condition
            double result = num1 * num2;
            Console.WriteLine($"Multiplication result: {result}");
        }
        else if (operation == "divide")
        {
            if (num2 != 0)
            {
                // Variable declaration inside nested if condition
                double result = num1 / num2;
                Console.WriteLine($"Division result: {result}");
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
        }
        else
        {
            // Variable declaration inside else block
            string errorMessage = "Invalid operation.";
            Console.WriteLine(errorMessage);
        }
    }

    static void Main(string[] args)
    {
        PerformOperation("add", 10, 5);
        PerformOperation("subtract", 10, 5);
        PerformOperation("multiply", 10, 5);
        PerformOperation("divide", 10, 5);
        PerformOperation("divide", 10, 0);
        PerformOperation("modulus", 10, 5);
    }
}
