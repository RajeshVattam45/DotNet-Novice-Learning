using System;

namespace ClassLibrary1.SolidPrincipals.SRP
{
    public class StudentsMarksClass
    {
        // Propertices to store subject marks.
        public int TeluguMarks { get; set; }
        public int EnglishMarks { get; set; }
        public int MathsMarks { get; set; }
        public int PhysicsMarks { get; set; }

        /// <summary>
        /// Method to display all the student subject marks.
        /// </summary>
        /// <returns></returns>
        public string DisplayAllSubjectMarks()
        {
            return $"Telugu: {TeluguMarks}, English: {EnglishMarks}, Maths: {MathsMarks}, Physics: {PhysicsMarks}";
        }

    }
}
