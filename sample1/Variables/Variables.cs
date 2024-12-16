using System;

namespace sample1.Variables
{
    // Declearing class.
    public class Variables
    {
        // Declearing int variable.
        public void Integer()
        {
            int numbers = 10;
            Console.WriteLine(numbers);
        }

        // Create function to declear string.
        public void DeclearString()
        {
            string Name = "Hello Rajesh";
            Console.WriteLine(Name);
        }

        // Function to declear string variable.
        public void StringFunction(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }

        // Function to declear the const variables.
        public void ConstFun()
        {
            const int number = 100;
            // Once declear const variable you can't change the value.
            // number = 190;
            Console.WriteLine(number);
        }
    }
}
