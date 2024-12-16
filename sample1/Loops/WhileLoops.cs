using System;


namespace sample1.Loops
{
    /// <summary>
    /// Class to demonstract while, do while loops.
    /// </summary>
    public class WhileLoopClass
    {
        public void IterateNumbersFunction()
        {
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine("While loop: " + i);
                i++;
            }
        }

        public void IterateFunction()
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);
        }
    }
}
