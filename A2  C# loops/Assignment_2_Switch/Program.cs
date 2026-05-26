using System;

namespace Assignment_2_Calculator {

    class Program
    {
        static void Main(string[] args)
        {
            double firstOperand, secondOperand, result; // This declares the four variables
            string oprt;

            Console.WriteLine("Please enter the first numerical value:");
            firstOperand = Convert.ToDouble(Console.ReadLine()); // This takes the input from the user.
            Console.Write("Please enter the second numerical value: ");
            Console.WriteLine("");
            secondOperand = Convert.ToDouble(Console.ReadLine()); // This takes input from the user.
            Console.WriteLine("");
            Console.Write("Enter a math operator ( +, -, *, /):");
            Console.WriteLine("");
            oprt = Console.ReadLine(); // This takes input from the user.
            switch(oprt)// switch-case statements
            {
                case "+": // if case is adding
                    Console.WriteLine("Addition: {0} + {1} = {2})", firstOperand, secondOperand, result = firstOperand + secondOperand);
                    break;
                case "-": // if case is subtracting
                    Console.WriteLine("Subtraction: {0} - {1} = {2}", firstOperand, secondOperand, result = firstOperand - secondOperand);
                    break;
                case "*":// if case is multiplying
                    Console.WriteLine("Multiplication : {0} * {1} = {2}", firstOperand, secondOperand, result = firstOperand * secondOperand);
                    break;
                case "/": //if case is diving
                    Console.WriteLine("Divide: {0} / {1} = {2}", firstOperand, secondOperand, result = firstOperand * secondOperand);
                    break;
                default: // if there is no matching operator
                    Console.WriteLine("Error: Wrong operator was entered. No calculation was completed.");
                    break;
            }
        }
    }
}
