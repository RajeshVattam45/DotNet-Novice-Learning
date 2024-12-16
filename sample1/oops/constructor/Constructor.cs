using System;

namespace sample1.oops.constructor
{
    class ConstructorClass
    {
        public string Name;
        public int Weight;
        public int Age;
        public string Gender;
        public ConstructorClass(string name, int weight, int age, string gender)
        {
            Name = name;
            Weight = weight;
            Age = age;
            Gender = gender;
        }

        public void DisplayData()
        {
            Console.WriteLine("My name is: " + Name + " and age: " + Age + " & weight & Gender " + Gender + ", " + Weight);
        }

        //public static void RetriveData()
        //{
        //    ConstructorClass constructorObj = new ConstructorClass("Rajesh", 55, 23, "Male");
        //    constructorObj.DisplayData();
        //}
    }
}
