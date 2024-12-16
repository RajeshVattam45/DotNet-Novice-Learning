using System;

namespace sample1.Variables
{
    /// <summary>
    /// Declearing class to describe variables.
    /// </summary>
    public class Variables
    {
        /// <summary>
        /// Declearing int variable.
        /// </summary>
        public void Integer()
        {
            int numbers = 10;
            Console.WriteLine(numbers);
        }

        /// <summary>
        /// Create function to declear string.
        /// </summary>
        public void DeclearString()
        {
            string Name = "Hello Rajesh";
            Console.WriteLine(Name);
        }

        /// <summary>
        /// Function to declear string variable.
        /// </summary>
        /// <param name="args"></param>
        public void StringFunction(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }

        /// <summary>
        /// Function to declear the const variables.
        /// </summary>
        public void ConstFun()
        {
            const int number = 100;
            // Once declear const variable you can't change the value.
            // number = 190;
            Console.WriteLine(number);
        }
    }
}
