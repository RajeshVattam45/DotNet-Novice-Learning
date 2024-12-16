using System;


namespace sample1.Loops
{
    public class WhileLoopClass
    {
        public void WhileLoopFunction()
        {
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine("While loop: " + i);
                i++;
            }
        }

        public void DoWhileLoopFunction()
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
