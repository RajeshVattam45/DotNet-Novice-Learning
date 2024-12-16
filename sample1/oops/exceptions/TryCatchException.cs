using System;

namespace sample1.oops.exceptions
{
    class TryCatchClass
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
