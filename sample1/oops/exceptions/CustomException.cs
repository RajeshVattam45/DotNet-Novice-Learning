using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample1.oops.exceptions
{
    class CustomException : Exception
    {
        public string CustomExceptionMethod()
        {
            return "Error: input not a string";
        }

        public void CheckMethod()
        {
            Console.Write("Enter text here: ");
            string inputText = Console.ReadLine();
            try
            {
                if (inputText is string)
                {
                    Console.WriteLine(inputText);
                }
                else
                {
                    throw new CustomException();
                }
            }
            catch (CustomException e)
            {
                Console.WriteLine(e.CustomExceptionMethod());
            }
          
        }
    }
    
}
