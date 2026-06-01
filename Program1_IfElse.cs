using System;

namespace Assignment2_IfElse
{
    /// <summary>
    /// Demonstrates an arithmetic calculator using nested if-else statements.
    /// The user enters two numbers and an operator symbol to get a result.
    /// </summary>
    class IfElseCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== If-Else Calculator ===\n");

            double firstOperand  = ReadDouble("Enter first numeric value:  ");
            double secondOperand = ReadDouble("Enter second numeric value: ");

            Console.Write("Enter a math operator (+, -, *, /): ");
            string oprt = Console.ReadLine()?.Trim();

            // Nested if-else to determine which operation to perform
            if (oprt == "+")
                Console.WriteLine($"\nAddition:       {firstOperand} + {secondOperand} = {firstOperand + secondOperand}");
            else if (oprt == "-")
                Console.WriteLine($"\nSubtraction:    {firstOperand} - {secondOperand} = {firstOperand - secondOperand}");
            else if (oprt == "*")
                Console.WriteLine($"\nMultiplication: {firstOperand} * {secondOperand} = {firstOperand * secondOperand}");
            else if (oprt == "/")
            {
                // Nested if-else: guard against division by zero before calculating
                if (secondOperand == 0)
                    Console.WriteLine("\nError: Cannot divide by zero.");
                else
                    Console.WriteLine($"\nDivision:       {firstOperand} / {secondOperand} = {firstOperand / secondOperand}");
            }
            else
                Console.WriteLine($"\nInvalid operator '{oprt}'. Please use +, -, *, or /.");
        }

        /// <summary>
        /// Prompts the user for input and validates it is a real number.
        /// Keeps asking until valid input is provided.
        /// </summary>
        static double ReadDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out double value))
                    return value;
                Console.WriteLine("  ⚠ Invalid input. Please enter a number.\n");
            }
        }
    }
}
