using System;

namespace ClassLibrary1.SolidPrincipals.SRP
{
    public class StudentsDetailsClass
    {
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public int StudentAge { get; set; }
        public int StudentId { get; set; }

        public void DisplayStudentDetails()
        {
            Console.WriteLine($"Student name is: {StudentName} " + $"Student father name: {FatherName} " + 
                $"Student age: {StudentAge} " + $"Student Id: {StudentId}");
        }
    }
}
