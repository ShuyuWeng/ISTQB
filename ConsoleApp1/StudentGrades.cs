using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades
{
    public class GradeCalculator
    {
        public string GetGradeByPercentage(int percentage)
        {
            if (percentage >= 90 && percentage <= 100)
                return "A";
            else if (percentage >= 80 && percentage <= 89)
                return "B";
            else if (percentage >= 70 && percentage <= 79)
                return "C";
            else if (percentage >= 60 && percentage <= 69)
                return "D";
            else if (percentage >= 0 && percentage <= 59)
                return "F";
            else
                return "Invalid";
        }
    }
}