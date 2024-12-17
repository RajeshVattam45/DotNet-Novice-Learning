using System;

namespace ConsoleApplication.Basics.ConditionalStatments
{
    public class TernaryOperatorClass
    {
        public void TerneryOperatorsFunction()
        {
            int number = 10;

            // Ternary operator to check if the number is greater than 5.
            string result = number > 5 ? "Number is greater than 5" : "Number is 5 or less";

            // Print the result.
            Console.WriteLine(result);
        }

    }

}
