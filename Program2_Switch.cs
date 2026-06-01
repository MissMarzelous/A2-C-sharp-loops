using System;

namespace Assignment2_Switch
{
    /// <summary>
    /// Demonstrates an arithmetic calculator using a switch statement.
    /// Solves the same problem as Program1 but with a switch instead of if-else.
    /// </summary>
    class SwitchCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Switch Calculator ===\n");

            double firstOperand  = ReadDouble("Enter first numeric value:  ");
            double secondOperand = ReadDouble("Enter second numeric value: ");

            // Keep asking for an operator until a valid one is entered
            string oprt = ReadOperator("Enter a math operator (+, -, *, /): ");

            double result = 0;

            // Switch statement matches the operator the user entered
            switch (oprt)
            {
                case "+":
                    result = firstOperand + secondOperand;
                    Console.WriteLine($"\nAddition:       {firstOperand} + {secondOperand} = {result}");
                    break;

                case "-":
                    result = firstOperand - secondOperand;
                    Console.WriteLine($"\nSubtraction:    {firstOperand} - {secondOperand} = {result}");
                    break;

                case "*":
                    result = firstOperand * secondOperand;
                    Console.WriteLine($"\nMultiplication: {firstOperand} * {secondOperand} = {result}");
                    break;

                case "/":
                    // Guard against division by zero before performing the calculation
                    if (secondOperand == 0)
                    {
                        Console.WriteLine("\nError: Cannot divide by zero.");
                    }
                    else
                    {
                        result = firstOperand / secondOperand;
                        Console.WriteLine($"\nDivision:       {firstOperand} / {secondOperand} = {result}");
                    }
                    break;
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
