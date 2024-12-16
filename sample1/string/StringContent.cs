using System;

namespace sample1.@string
{
    public class StringContentClass
    {
        public void DisplayContent()
        {
            // Declare string variable with a description text.
            string description = "hello .net, i am learning .net now which is new to me";
            Console.WriteLine(description);

            // Declare string array with multiple string elements.
            string[] stringArray = { "hello", ".ner", "i", "Rajesh", "programming", "launguage" };

            // Iterate through each element in the string array using a for loop.
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
        }
    }
}
