using System;

namespace sample1.ConditionalStatments
{
    public class ConditionalLogicClass
    {
        public void ConditionalLogic()
        {
            // If condition.
            if (true)
            {
                Console.WriteLine("Hello .Net");
            }

            // if else condition.
            string name = "Rajesh";
            if (name == "hello")
            {
                Console.WriteLine("welcome to .net");
            }
            else
            {
                Console.WriteLine(name);
            }

            // elseif condition.
            int number = 0;
            if (number == 1)
            {
                Console.WriteLine("The num is: " + number);
            }
            else if (number == 0)
            {
                Console.WriteLine("The number is: " + number);
            }
            else
            {
                Console.WriteLine("the number is: " + number);
            }
        }
    }
}
