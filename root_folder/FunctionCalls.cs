using System;

namespace FunctionCallsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main function started.");

            // Call the primary function
            PrimaryFunction();

            Console.WriteLine("Main function ended.");
        }

        static void PrimaryFunction()
        {
            Console.WriteLine("PrimaryFunction called.");

            // Call a helper function
            HelperFunction();

            // Call another function and store the result
            int sum = AddNumbers(5, 10);
            Console.WriteLine("Sum from AddNumbers: " + sum);

            // Call a function that calls other functions internally
            NestedFunctionCaller();
        }

        static void HelperFunction()
        {
            Console.WriteLine("HelperFunction called.");
        }

        static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        static void NestedFunctionCaller()
        {
            Console.WriteLine("NestedFunctionCaller called.");

            // Call multiple functions within this function
            int product = MultiplyNumbers(3, 4);
            Console.WriteLine("Product from MultiplyNumbers: " + product);

            DisplayMessage("This is a nested function call example.");
        }

        static int MultiplyNumbers(int a, int b)
        {
            return a * b;
        }

        static void DisplayMessage(string message)
        {
            Console.WriteLine("Message: " + message);
        }
    }
}
