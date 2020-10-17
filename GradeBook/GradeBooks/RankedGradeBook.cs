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

        //public override char GetLetterGrade(double averageGrade)
        //{
        //    if (Students.Count() < 5) throw new InvalidOperationException();
        //    Students.ForEach(q =>
        //    {
        //        q.AverageGrade
        //    });
        //}

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
