using System;
using System.Collections.Generic;
using System.Linq;

namespace SyntaxDemo
{
    // Enum Example
    public enum DayOfWeek
    {
        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }


    // Record Example
    public record User(string Name, int Age);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Syntax Demo\n");

            // Variables and Data Types
            int number = 42;
            string text = "Hello, World!";
            bool isTrue = true;
            double pi = 3.14159;

            Console.WriteLine($"Variables: {number}, {text}, {isTrue}, {pi}");

            // Decision Making
            int age = 20;
            if (age < 18)
            {
                Console.WriteLine("You are a minor.");
            }
            else if (age >= 18 && age < 65)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior.");
            }

            // Ternary Operator
            string eligibility = age >= 18 ? "Eligible to vote" : "Not eligible to vote";
            Console.WriteLine(eligibility);

            // Switch Case
            DayOfWeek today = DayOfWeek.Friday;
            switch (today)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Start of the work week.");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("It's Friday! Weekend is near.");
                    break;
                default:
                    Console.WriteLine("It's a regular day.");
                    break;
            }

            // Loops
            Console.WriteLine("\nNumbers from 1 to 5:");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            int counter = 0;
            while (counter < 3)
            {
                Console.WriteLine($"Counter is {counter}");
                counter++;
            }

            // LINQ Example
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("\nEven Numbers:");
            foreach (var num in evenNumbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();

            // Method Call
            Console.WriteLine("\nFactorial of 5 is " + CalculateFactorial(5));

            // Classes and Objects
            IGreetable greeter = new Greeter();
            greeter.Greet("User");

            // Records
            User user = new User("Alice", 25);
            Console.WriteLine($"\nUser Record: {user}");

            // Nullable Types
            int? nullableInt = null;
            Console.WriteLine($"Nullable Int: {nullableInt ?? 0}");

            // Exception Handling
            try
            {
                Console.WriteLine("\nAttempting risky operation...");
                int result = number / 0; // This will throw an exception
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Caught an exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Cleaning up...");
            }

            // Async/Await
            Console.WriteLine("\nStarting async task...");
            var task = PerformAsyncOperation();
            task.Wait(); // Blocking here for simplicity

            // Pattern Matching
            object obj = "Pattern Matching in C#";
            if (obj is string str)
            {
                Console.WriteLine($"\nPattern matched: {str}");
            }

            Console.WriteLine("\nProgram completed!");
        }

        // Method Example
        static int CalculateFactorial(int n)
        {
            if (n <= 1) return 1;
            return n * CalculateFactorial(n - 1);
        }

        // Async Method Example
        static async System.Threading.Tasks.Task PerformAsyncOperation()
        {
            await System.Threading.Tasks.Task.Delay(1000);
            Console.WriteLine("Async operation completed.");
        }
    }
}
