using System;

namespace Assignment2_LoopExamples
{
    /// <summary>
    /// Demonstrates four loop types in C#:
    /// for loop, while loop, nested while loop, and do-while loop.
    /// Each loop type is shown in its own clearly labelled method.
    /// </summary>
    class LoopExamples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Loop Examples ===\n");

            DemonstrateForLoop();
            DemonstrateWhileLoop();
            DemonstrateNestedWhileLoop();
            DemonstrateDoWhileLoop();
        }

        /// <summary>
        /// FOR LOOP: Counts from 0 to 4.
        /// Best used when the number of iterations is known in advance.
        /// </summary>
        static void DemonstrateForLoop()
        {
            Console.WriteLine("--- For Loop (0 to 4) ---");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"  i = {i}");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// WHILE LOOP: Counts from 0 to 9.
        /// Condition is checked BEFORE each iteration — may never run if false from the start.
        /// </summary>
        static void DemonstrateWhileLoop()
        {
            Console.WriteLine("--- While Loop (0 to 9) ---");

            int i = 0;
            while (i < 10)
            {
                Console.WriteLine($"  Value of i: {i}");
                i++;
            }

            Console.WriteLine();
        }

        /// <summary>
        /// NESTED WHILE LOOP: A loop inside a loop.
        /// Outer loop runs m = 0 to 1, inner loop runs j = 0 to 1 for each m.
        /// </summary>
        static void DemonstrateNestedWhileLoop()
        {
            Console.WriteLine("--- Nested While Loop ---");

            int m = 0;
            while (m < 2)
            {
                Console.WriteLine($"  Outer loop — m = {m}");

                int j = 0;
                while (j < 2)
                {
                    Console.WriteLine($"    Inner loop — j = {j}");
                    j++;
                }

                m++;
            }

            Console.WriteLine();
        }

        /// <summary>
        /// DO-WHILE LOOP: Counts from 0 to 2.
        /// The body runs AT LEAST ONCE before the condition is checked.
        /// Useful for menus and "play again?" prompts.
        /// </summary>
        static void DemonstrateDoWhileLoop()
        {
            Console.WriteLine("--- Do-While Loop (always runs at least once) ---");

            int nn = 0;
            do
            {
                Console.WriteLine($"  nn = {nn}");
                nn++;
            } while (nn < 3);

            Console.WriteLine("(Loop finished)\n");
        }
    }
}
