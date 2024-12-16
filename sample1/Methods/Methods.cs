using System;

namespace sample1.Methods
{
    public class MethodExamples
    {
        // Ddeclearing method.
        public void DisplayGreeting()
        {
            Console.WriteLine("hello .net");
        }

        // Declaring a method with parameters
        public void DisplayUserName(string myName)
        {
            Console.WriteLine("My name is: " + myName);
        }

        // Declearing funtion with multiple permeters.
        public void DisplayNameAndAge(string myName, int age)
        {
            Console.WriteLine("My name: " + myName + " my age is " + age);
        }

        // Declearing function with default perameters.
        public void DisplayDefaultMessage(string myName = ".net")
        {
            Console.WriteLine(myName);
        }
    }
}
