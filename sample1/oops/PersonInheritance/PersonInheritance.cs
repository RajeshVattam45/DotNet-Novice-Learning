using System;

namespace sample1.oops.PersonInheritance
{
    // Parent class with common properties and methods.
    class Person
    {
        public string Names;
        public int Age;
        public string Gender;

        // Constructor to initialize parent class properties.
        public Person(string name, int age, string gender)
        {
            Names = name;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Method to display the data of the parent class.
        /// </summary>
        public void DisplayData()
        {
            Console.WriteLine("My name is: " + Names + " age & gender is " + Age + " " + Gender);
        }
    }

    // Child class inheriting from ParentClass.
    class ExtendedPerson : Person
    {
        public string Color;

        // Constructor to initialize both parent and child properties.
        public ExtendedPerson(string name, int age, string gender, string color) : base(name, age, gender)
        {
            Color = color;
        }

        /// <summary>
        /// Method to display additional color information.
        /// </summary>
        public void ColorFunction()
        {
            Console.WriteLine("My name is: " + Names + " age & gender is " + Age + " " + Gender + " color " + Color);
        }
    }
}
