using System;

namespace sample1.Loops
{
    public class ForLoopClass
    {
        // Create function to iterate the array using for loop.
        public void ForLoopFunction()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < numbers.Length; i++)
            {
                // Console.WriteLine("Using for loop");
                Console.WriteLine("The Number Is: " + numbers[i]);
            }
        }

        // Create function for the 'for loop'.
        public void AutoIncrementFunction()
        {
            int n = 10;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
