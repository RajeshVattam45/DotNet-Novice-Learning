using System;

namespace ConsoleApplication.Basics.TypeCasting
{
    // Class to demonstrate typecasting.
    class DemonstrateTypeCasting
    {
        /// <summary>
        /// Implicit Casting - automatically converting a smaller type to a larger type size.
        /// </summary>
        public void DemonstrateImplicitCasting()
        {
            // variable having integer smaller type.
            int myNumber = 10;

            // Automatically convert smaller type to larger type.
            double myDouble = myNumber;
            Console.WriteLine(myNumber);

            // variable with smaller type.
            char charactor = 'a';

            // converted to larger type (string).
            string myCharactor = charactor.ToString();
            Console.WriteLine(myCharactor);

            // smaller type.
            byte smallNumber = 255;

            // implicit conversion.
            int largeNumber = smallNumber;
            Console.WriteLine(largeNumber);

            // Variable with int smaller type.
            short smallValue = 30000;
            // implicit conversion
            long largerValue = smallValue;
            Console.WriteLine(largerValue);

            // Variable with charactor - smaller type.
            char charValue = 'A';
            // implicit conversion converts charactor to int.
            int asciiValue = charValue;
            Console.WriteLine(asciiValue);

        }

        /// <summary>
        /// Method to demonstrate explicit typecasting.
        /// </summary>
        public void DemonstrateExplicitCasting()
        {
            // Explicitly converting a double to an int.
            double pi = 3.14;
            int intPi = (int)pi;
            Console.WriteLine(intPi);

            // Converting a float to an int.
            float value = 5.75f;
            int intValue = (int)value;
            Console.WriteLine(intValue);

            // Explicit casting from object to a specific type.
            object obj = "Hello, World!";
            string str = (string)obj;
            Console.WriteLine(str);

            // Explicit casting from object to string.
            object objNumber = 42;
            string safeCast = objNumber as string;
            Console.WriteLine(safeCast);

        }
    }
}
