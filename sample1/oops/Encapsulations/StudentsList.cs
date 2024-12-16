using System;

namespace sample1.oops.Encapsulations
{
    class StudentsListClass
    {
        private string _name;
        private int _marks;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Marks
        {
            get { return _marks; }
            set { _marks = value; }

        }

        public string Group
        {
            get; set;
        }

        public void DisplayStudent()
        {
            Console.WriteLine($"Student name is {_name} and marks {_marks} ");
        }       
    }

}
