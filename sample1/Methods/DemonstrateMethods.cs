using System;

namespace sample1.Methods
{
    /// <summary>
    /// Class to demonstrate types methods.
    /// </summary>
    public class DemonstrateMethodExamples
    {
        /// <summary>
        /// Declearing method.
        /// </summary>
        public void DisplayGreeting()
        {
            Console.WriteLine("hello .net");
        }

        /// <summary>
        /// Declaring a method with parameters.
        /// </summary>
        /// <param name="myName"></param>
        public void DisplayUserName(string myName)
        {
            Console.WriteLine("My name is: " + myName);
        }

        /// <summary>
        /// Declearing funtion with multiple permeters.
        /// </summary>
        /// <param name="myName"></param>
        /// <param name="age"></param>
        public void DisplayNameAndAge(string myName, int age)
        {
            Console.WriteLine("My name: " + myName + " my age is " + age);
        }

        /// <summary>
        /// Declearing function with default perameters.
        /// </summary>
        /// <param name="myName"></param>
        public void DisplayDefaultMessage(string myName = ".net")
        {
            Console.WriteLine(myName);
        }
    }
}
