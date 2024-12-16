using System;

namespace sample1.Loops
{
    public class IterativeLoops
    {
     // Foreach method
        // Function to iterate array using foreach loop.
        public void IterateStringArray()
        {
            string[] names = { "Hello", ".net", "welcome", "good", "text" };
            foreach (string name in names)
            {
                Console.WriteLine("Out put: " + name);
            }
        }

        //
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
