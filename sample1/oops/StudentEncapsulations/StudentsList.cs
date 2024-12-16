using System;

namespace sample1.oops.StudentEncapsulations
{
    // Class demonstrating encapsulation with properties and methods.
    class StudentsListClass
    {
        // Private fields to store student details.
        private string _name;
        private int _marks;

        /// <summary>
        /// Property for accessing and modifying the student's name.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Property for accessing and modifying the student's marks.
        /// </summary>
        public int Marks
        {
            get { return _marks; }
            set { _marks = value; }

        }

        // Auto-implemented property for the student's group.
        public string Group
        {
            get; set;
        }

        /// <summary>
        /// Method to display the student's details.
        /// </summary>
        public void DisplayStudent()
        {
            Console.WriteLine($"Student name is {_name} and marks {_marks} ");
        }       
    }

}
