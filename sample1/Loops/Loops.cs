using System;

namespace sample1.Loops
{
    public class MyLoops
    {
        // Function for 'for' loop.
        public void MyFunction()
        {
            int number = 10;
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Displaying Data " + i);
            }
        }

        // Function for 'foreach' loop.
        public void ForEachLoop()
        {
            string[] names = { "hello", ".Net", "programming", "launguage" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        // Create function for 'while' loop.
        public void WhileLoop()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            int i = 0;
            while (i < numbers.Length)
            {
                Console.WriteLine("While loop " + numbers[i]);
                i++;
            }
        }
    }
}
