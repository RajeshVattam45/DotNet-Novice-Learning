using System;

namespace ClassLibrary1.SolidPrincipals.SRP
{
    public class StudentsMarksClass
    {
        public int TeluguMarks { get; set; }
        public int EnglishMarks { get; set; }
        public int MathsMarks { get; set; }
        public int PhysicsMarks { get; set; }


        public string DisplayAllSubjectMarks()
        {
            return $"Telugu: {TeluguMarks}, English: {EnglishMarks}, Maths: {MathsMarks}, Physics: {PhysicsMarks}";
        }

    }
}
