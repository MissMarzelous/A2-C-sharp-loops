using System;

namespace Assignment2__If_else
{
    class Calculator
    {
        static void Main(string[] args)
        {
            double firstOperand, secondOperand, result; // declare four variables
            string oprt;
            Console.Write("Enter first numeric value.");
            Console.WriteLine();
            firstOperand = Convert.ToDouble(Console.ReadLine());// uses given input from user.
            Console.Write("Enter second numeric value");
            Console.WriteLine();
            secondOperand = Convert.ToDouble(Console.ReadLine()); // uses given input from user.
            Console.WriteLine();
            Console.Write("Enter a math operator (+, -, *, /.)");
            Console.WriteLine();
            oprt = Console.ReadLine(); // uses given input from user.
            if (oprt == "+") // if else statements
                Console.WriteLine("Addition: {0) + {1} = {2}", firstOperand, secondOperand, result = firstOperand + secondOperand);
            else
               if (oprt == "-")
                Console.WriteLine("Subtraction: {0} - {1} = {2}", firstOperand, secondOperand, result = firstOperand - secondOperand);
            else
               if (oprt == "*")
                Console.WriteLine("Multiplication : {0} * {1} = {2}", firstOperand, secondOperand, result = firstOperand * secondOperand);
            else
               if (oprt == "/")
                Console.WriteLine("Divide: {0} / {1} = {2}", firstOperand, secondOperand, result = firstOperand / secondOperand);
            else
                Console.WriteLine("Invalid entry, no calculation was done.");




        }
    }
}
