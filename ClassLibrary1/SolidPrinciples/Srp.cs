using System;
using System.Collections.Generic;

namespace ClassLibrary1.SingleResponsibilityPrinciple
{
    class StudentManager
    {
        string StudentName;
        int StudentAge;
        string StudentGrade;
        public StudentManager(string name, int age, string grade)
        {
            StudentName = name;
            StudentAge = age;
            StudentGrade = grade;
        }

        public void AddStudents()
        {
            Console.WriteLine("Adding student details with name " + StudentName + " age & " + StudentAge + " grade " + StudentGrade);
        }
    }

    class StudentPrinter
    {
        string StudentName;
        int StudentAge;
        string StudentGrade;
        public StudentPrinter(string name, int age, string grade)
        {
            StudentName = name;
            StudentAge = age;
            StudentGrade = grade;
        }
        public void PrintStudents()
        {
            // Console.WriteLine("Displaying students Details");
            Console.WriteLine("Student name " + StudentName + " age " + StudentAge + " grade " + StudentGrade);
        }
    }

    class StudentMarks
    {
        public void PrintStudentMarks(dynamic marks)
        {
            Console.WriteLine("Displaying Student Marks:");
            Console.WriteLine($"Telugu: {marks.Telugu}");
            Console.WriteLine($"Mathematics: {marks.Mathematics}");
            Console.WriteLine($"English: {marks.English}");
        }
    }

    class CreateStudentObjects
    {
        public static void CreateObject()
        {
            StudentManager studentManager = new StudentManager("Rajesh", 23, "A");
            studentManager.AddStudents();

            StudentPrinter studentPrinter = new StudentPrinter("Rajesh", 23, "A");
            studentPrinter.PrintStudents();

            // Passing marks using an anonymous object.
            var marks = new { Telugu = 50, Mathematics = 70, English = 66 };

            // Create an instance of StudentMarks and print marks
            StudentMarks studentMarks = new StudentMarks();
            studentMarks.PrintStudentMarks(marks);

        }
    }
}
