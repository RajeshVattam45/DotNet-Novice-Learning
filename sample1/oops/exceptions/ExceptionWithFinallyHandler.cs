using System;

namespace sample1.oops.ExceptionHandler
{
    // Class to demonstrate exception handling with a finally block.
    class ExceptionWithFinallyHandler
    {
        public void FinallyMethod()
        {
            try
            {
                // int x = 100;
                string x = "hlo";
                if (x is int)
                {
                    Console.WriteLine("Yes its int " + x);
                }
                else
                {
                    throw new Exception("Error occured");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Always execuits this block wether these is error occured or not");
            }
        }
    }
}
