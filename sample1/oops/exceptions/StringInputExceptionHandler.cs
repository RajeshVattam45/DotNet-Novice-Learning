using System;

namespace sample1.oops.ExceptionHandler
{
    // Custom exception class for handling string input validation errors.
    class StringInputExceptionHandler : Exception
    {
        /// <summary>
        /// Method to return the error message for the custom exception.
        /// </summary>
        /// <returns></returns>
        public string GetErrorMessage()
        {
            return "Error: input not a string";
        }

        /// <summary>
        /// Method to validate the input, checking for non-numeric values.
        /// </summary>
        public void CheckInputValue()
        {
            Console.Write("Enter text here: ");
            string inputText = Console.ReadLine();

            try
            {
                // Check if the input consists only of numbers.
                if (int.TryParse(inputText, out _))
                {
                    // Throw exception if the input is a number.
                    throw new StringInputExceptionHandler();
                }
                else
                {
                    Console.WriteLine($"You entered: {inputText}");
                }
            }
            catch (StringInputExceptionHandler e)
            {
                // Catch and display custom exception error message.
                Console.WriteLine(e.GetErrorMessage());
            }
        }
    }
}
