using System;

namespace sample1.oops.inheritance
{
    // Parent class with common properties and methods.
    class ParentClass
    {
        public string Names;
        public int Age;
        public string Gender;

        // Constructor to initialize parent class properties.
        public ParentClass(string name, int age, string gender)
        {
            Names = name;
            Age = age;
            Gender = gender;
        }

        // Method to display the data of the parent class.
        public void DisplayData()
        {
            Console.WriteLine("My name is: " + Names + " age & gender is " + Age + " " + Gender);
        }
    }

    // Child class inheriting from ParentClass.
    class ChaildClass : ParentClass
    {
        public string Color;

        // Constructor to initialize both parent and child properties.
        public ChaildClass(string name, int age, string gender, string color) : base(name, age, gender)
        {
            Color = color;
        }

        // Method to display additional color information.
        public void ColorFunction()
        {
            Console.WriteLine("My name is: " + Names + " age & gender is " + Age + " " + Gender + " color " + Color);
        }

        // Static method to demonstrate the child class functionality.
        //public static void ChaildClassMethod()
        //{
        //    ChaildClass nameObject = new ChaildClass("Rajesh", 23, "Male", "White");
        //    nameObject.DisplayData();
        //    nameObject.ColorFunction();
        //}
    }
}
