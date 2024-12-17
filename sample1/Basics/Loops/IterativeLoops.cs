using System;

namespace ConsoleApplication.Basics.Loops
{
    public class IterativeLoops
    {
        /// <summary>
        /// Function to iterate names array using foreach loop.
        /// </summary>
        public void IterateStringArray()
        {
            string[] names = { "Hello", ".net", "welcome", "good", "text" };
            foreach (string name in names)
            {
                Console.WriteLine("Out put: " + name);
            }
        }

        /// <summary>
        /// Function to iterate numbers array using foreach loop.
        /// </summary>
        public void IterateIntegerArray()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int number in numbers)
            {
                Console.WriteLine("The Number is: " + number);
            }
        }
    }
}
