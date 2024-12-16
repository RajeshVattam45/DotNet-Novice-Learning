using System;

namespace sample1.oops.Encapsulations
{
    class ProperticesClass
    {
        // Public properties can be accessed from anywhere.
        public string Name;

        // Private properties can only be accessed within the class where they are defined.
        private int Age;

        // Protected properties can be accessed within the class and by derived classes (inheritance).
        protected string Gender;

        public ProperticesClass(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public void PublicMethod()
        {
            // Accessing public acces modifier.
            Console.WriteLine(Name);

            // Accessign the private property.
            Console.WriteLine(Age);

            Console.WriteLine(Gender);
        }
    }

}
