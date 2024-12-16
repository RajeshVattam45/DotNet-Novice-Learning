using System;

namespace sample1.Methods
{
    class PerametersClass
    {
        // Frunction with optional perameters.
        public void DisplayMessage(string message = "Welcome to .net")
        {
            Console.WriteLine(message);
        }

        // Function with named perameters.
        public void FunctionWithPerameters(string name, int age)
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        // Function with perams keyword.
        public void PeramsFunction(params int[] numbers)
        {
            int sumOf = numbers.Sum();
            Console.WriteLine("Sum of " + sumOf);
        }

        //public static void CreateObject()
        //{
        //    PerametersClass newObject = new PerametersClass();
        //    newObject.DisplayMessage("Rajesh");

        //    newObject.FunctionWithPerameters("Rajesh", 23);
        //    newObject.PeramsFunction(1, 2, 3, 4);
        //}
    }
}
