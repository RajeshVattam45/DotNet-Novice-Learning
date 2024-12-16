using System;

namespace sample1.oops.exceptions
{
    class ExceptionsClass
    {
        // Method to demonstrate exception handling.
        public void ExceptionMethod()
        {
            string Number = "hi";
            // int Number = 100;
            try
            {
                // Check if 'Number' is an integer.
                if (Number is int)
                {
                    Console.WriteLine("this is integer " + Number);
                }
                else
                {
                    // Throw exception if 'Number' is not an integer.
                    throw new Exception("this is not integer " + Number);
                }
            }
            catch (Exception e)
            {
                // Catch and display the exception message.
                Console.WriteLine(e.Message);
            }
        }
    }
}
