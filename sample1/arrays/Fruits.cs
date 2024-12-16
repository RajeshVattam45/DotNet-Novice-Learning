using System;

namespace sample1.arrays
{
    public class ArrayUtilities
    {
        public void ArrayIterationMethod()
        {
            // Declearing an array with int.
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // Declearing names array.
            string[] names = { "Apple", "Banana", "Mango", "Greaps", "Orange" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
