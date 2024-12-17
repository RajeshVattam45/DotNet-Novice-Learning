using System;

namespace ConsoleApplication.Basics.Loops
{
    // Class for implementing loops.
    class NumbersClass
    {
        /// <summary>
        /// Create function to iterate the array using for loop.
        /// </summary>
        public void IterateNumbers()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < numbers.Length; i++)
            {
                // Console.WriteLine("Using for loop");
                Console.WriteLine("The Number Is: " + numbers[i]);
            }
        }

        /// <summary>
        /// Create function for the 'for loop'.
        /// </summary>
        public void AutoIncrementFunction()
        {
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
