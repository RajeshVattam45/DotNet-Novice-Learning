using System;

namespace sample1.oops.PersonsConstructor
{
    // This class demonstrates the use of a constructor to initialize object properties.
    class PersonsDetails
    {
        // Propertices to store persons details.
        public string Name;
        public int Weight;
        public int Age;
        public string Gender;

        /// <summary>
        /// Parameterized constructor to initialize the person's details.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="weight"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        public PersonsDetails(string name, int weight, int age, string gender)
        {
            Name = name;
            Weight = weight;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Displays the details of the person.
        /// </summary>
        public void DisplayPersonsData()
        {
            Console.WriteLine("My name is: " + Name + " and age: " + Age + " & weight & Gender " + Gender + ", " + Weight);
        }
    }
}
