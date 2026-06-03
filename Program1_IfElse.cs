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

            // Keep asking for an operator until a valid one is entered
            string oprt = ReadOperator("Enter a math operator (+, -, *, /): ");

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
        }

        /// <summary>
        /// Prompts the user for an operator and keeps asking until
        /// one of the four valid operators is entered.
        /// </summary>
        static string ReadOperator(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine()?.Trim();

                if (input == "+" || input == "-" || input == "*" || input == "/")
                    return input;

                Console.WriteLine("  ⚠ Invalid operator. Please enter +, -, *, or /.\n");
            }
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
