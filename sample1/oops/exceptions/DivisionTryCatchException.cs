using System;

namespace sample1.oops.ExceptionHandler
{
    /// <summary>
    /// Class to handle division by zero and other exceptions using try/catch exception.
    /// </summary>
    class DivisionByZeroHandler
    {
        public void Division()
        {
            try
            {
                int x = 100;
                int y = 0;
                int a = x / y;
                Console.WriteLine(a);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
