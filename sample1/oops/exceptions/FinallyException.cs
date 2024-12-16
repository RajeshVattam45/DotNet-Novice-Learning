using System;

namespace sample1.oops.exceptions
{
    class FinallyExceptionClass
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
