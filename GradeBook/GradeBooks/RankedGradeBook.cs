using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count() < 5) throw new InvalidOperationException();
            if (averageGrade >= 80) return 'A';
            else if (averageGrade < 80 && averageGrade >= 60) return 'B';
            else if (averageGrade < 60 && averageGrade >= 40) return 'C';
            else if (averageGrade < 40 && averageGrade >= 20) return 'D';
            return 'F';
        }

        public override void CalculateStatistics()
        {
            if(Students.Count >= 5)
                base.CalculateStatistics();
            else Console.WriteLine("Ranked grading requires at least 5 students.");

        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count >= 5)
                base.CalculateStudentStatistics(name);
            else Console.WriteLine("Ranked grading requires at least 5 students.");
        }
    }
}
