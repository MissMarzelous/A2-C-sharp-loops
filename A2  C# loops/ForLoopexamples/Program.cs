using System;

namespace ForLoopexamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // fix CAMELCASE if not working when you undo comments.
            //for (int i = 0; i < 5; i++)
            //{
            //    console.writeline(i);
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //        break; // will break and stop the loop
            //    console.writeline("value of i: {0}", i);


            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = i; j < 10; j++)
            //        console.writeline("value of i : {0}, j: {1} ", i, j); 
            //    // loop inside a loop
            //}


            int n = 0;
            while (n < 5)
            {
                Console.WriteLine(n);
                n++;

            }

            int i = 0;
            while (true)
            {
                Console.WriteLine("Value of i: {0}");

                i++;
                if (i > 10)
                    break;

            }

            int m = 0;

            while (m < 2)
            {
                Console.WriteLine(" Value of m: {0}", m);
                int j = 1;
                m++;
                while (j < 2)
                {
                    Console.WriteLine("Value of j: {0}", j);
                    j++;

                }

            } int nn = 10;
            do
            {
                Console.WriteLine(nn);
                nn++;

            } while (nn < 5);
            // do while loop will execute code even if false
            // do while loop is good for video games ( to continue/ stop/ play again)

        }
    }
}
