using System;

namespace ClassLibrary.SolidPrincipals.SRP
{
    // Class responsible for holding and displaying student details.
    public class StudentsDetailsClass
    {
        // Propertices to store the student data.
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public int StudentAge { get; set; }
        public int StudentId { get; set; }

        /// <summary>
        /// Method to display the student's details.
        /// </summary>
        public void DisplayStudentDetails()
        {
            Console.WriteLine($"Student name is: {StudentName} " + $"Student father name: {FatherName} " + 
                $"Student age: {StudentAge} " + $"Student Id: {StudentId}");
        }
    }
}
